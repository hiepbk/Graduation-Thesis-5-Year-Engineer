using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using MetroFramework;
using Newtonsoft.Json.Linq;
using Microsoft.Office;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;
using Application = Microsoft.Office.Interop.Excel._Application;
// Giao tiếp qua Serial
using System.IO;
using System.IO.Ports;
using System.Xml;
// Thêm ZedGraph
using ZedGraph;
//Thêm live chart
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.Defaults;
using LiveCharts.WinForms; //the WinForm wrappers
using rtChart;

namespace bunifuapp
{

    public partial class Form1 : Form
    {
        SerialPort Port1 = new SerialPort(); // Khai báo 1 Object SerialPort mới.
        string InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        delegate void SetTextCallback(string text);       // Khai bao delegate SetTextCallBack voi tham so string
        string uart_json,mqtt_json;
        bool mode;
        int tick1 = 0; // Bien thoi gian
        String key_Id, key_U1, key_U2, key_I1, key_I2, key_cosP1, key_cosP2, key_S, key_P, key_Q, key_cosP, key_freq, key_P_peak, key_Q_peak =String.Empty;
        float U1=0,U2=0,I1=0,I2=0, cosP1 = 0, cosP2 = 0, S=0,  P = 0,Q=0,freq=0,cosP=0, P_peak=0 ,Q_peak=0;


        private void btn_rsmode_Click(object sender, EventArgs e)
        {
            panel_rs485.Visible = true;
            panel_wifi.Visible = false;
            toolStripStatusLabel1.Text = "Chế độ RS485";
            mode = true;
            lb_tieude.Text = "GIÁM SÁT THÔNG SỐ TỔ MÁY PHÁT ĐIỆN (RS485)";
        }


        private void btn_Export_Click(object sender, EventArgs e)
        {
            // Xuất ra file exel và lưu lại giá trị đỉnh thôi
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            int i = 1;

            int j = 1;

            foreach (ListViewItem comp in listView1.Items)

            {
                ws.Cells[i, j] = comp.Text.ToString();
                //MessageBox.Show(comp.Text.ToString());
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    ws.Cells[i, j] = drv.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }
        }

        private void btn_ConnectMQTT_Click(object sender, EventArgs e)
        {
            try
            {
                client = new MqttClient(txb_BrokerName.Text, int.Parse(txb_Port.Text), false, MqttSslProtocols.None, null, null);
                client.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                byte code = client.Connect(Guid.NewGuid().ToString(), txb_UserName.Text, txb_Password.Text);
                if (code == 0)
                {
                    MetroMessageBox.Show(this, "Đã kết nối tới MQTT Cloud", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel_wifi.Visible = true;
                    Status_mqtt.Checked = true;
                    //Subcribe Topic
                    client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    client.Subscribe(new string[] { "ESP_SUB/T1", "ESP_SUB/T2", "test", "ESP_PUB" }, new byte[] { 0, 0, 0, 0 });
                    //READ LED STATUS

                    panel_main.Visible = true;
                }

                else MetroMessageBox.Show(this, "Connect Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MetroMessageBox.Show(this, "Wrong Format", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }

        private void btn_DisconnectMQTT_Click(object sender, EventArgs e)
        {
            panel_main.Visible = false;
            if (client.IsConnected)
            {
                client.Disconnect();
                Status_mqtt.Checked = false;
                panel_wifi.Visible = false;
                MetroMessageBox.Show(this, "Ngắt kết nối tới MQTT Cloud", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_openport_Click(object sender, EventArgs e)
        {
            try
            {
                Port1.Open();
                btn_closeport.Enabled = true;
                btn_openport.Enabled = false;
                // Hiện thị Status
                panel_main.Visible = true;
                toolStripStatusLabel1.Text = "Đang kết nối với cổng " + cbCom.SelectedItem.ToString();
                MetroMessageBox.Show(this, "Đã kết nối tới cổng "+ cbCom.SelectedItem.ToString(), "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MetroMessageBox.Show(this,"Không kết nối được","Error",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_closeport_Click(object sender, EventArgs e)
        {
            Port1.Close();
            panel_main.Visible = false;
            btn_openport.Enabled = true;
            btn_closeport.Enabled = false;
            // Hiện thị Status
            MetroMessageBox.Show(this, "Đã ngắt kết nối tới cổng " + cbCom.SelectedItem.ToString(), "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            toolStripStatusLabel1.Text = "Đã Ngắt Kết Nối";
        }

        private void btn_wifimode_Click_2(object sender, EventArgs e)
        {
            panel_rs485.Visible = false;
            panel_wifi.Visible = true;
            toolStripStatusLabel1.Text = "Chế độ Wifi";
            mode = false;
            lb_tieude.Text = "GIÁM SÁT THÔNG SỐ TỔ MÁY PHÁT ĐIỆN (WIFI)";
        }

        public Form1()
        {
            InitializeComponent();
            cbCom.DataSource = SerialPort.GetPortNames(); // Lấy nguồn cho comboBox là tên của cổng COM

            //cbCom.Text = Properties.Settings.Default.ComName; // Lấy ComName đã làm ở bước 5 cho comboBox
            Port1.ReadTimeout = 1000;
            // Khai báo hàm delegate bằng phương thức DataReceived của Object SerialPort;
            // Cái này khi có sự kiện nhận dữ liệu sẽ nhảy đến phương thức DataReceive
            // Nếu ko hiểu đoạn này bạn có thể tìm hiểu về Delegate, còn ko cứ COPY . Ko cần quan tâm
            Port1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            // Cài đặt cho BaudRate
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cbRate.Items.AddRange(BaudRate);

            // Cài đặt cho DataBits
            string[] Databits = { "6", "7", "8" };
            cbBits.Items.AddRange(Databits);

            //Cho Parity
            string[] Parity = { "None", "Odd", "Even" };
            cbParity.Items.AddRange(Parity);

            //Cho Stop bit
            string[] stopbit = { "1", "1.5", "2" };
            cbBit.Items.AddRange(stopbit);

        }
        static MqttClient client;
        private void cbCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close(); // Nếu đang mở Port thì phải đóng lại
            }
            Port1.PortName = cbCom.SelectedItem.ToString(); // Gán PortName bằng COM đã chọn 
        }
        private void cbRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close();
            }
            Port1.BaudRate = Convert.ToInt32(cbRate.Text);
        }

        private void cbBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close();
            }
            Port1.DataBits = Convert.ToInt32(cbBits.Text);
        }
        private void cbParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close();
            }
   
            switch (cbParity.SelectedItem.ToString())
            {
                case "Odd":
                    Port1.Parity = Parity.Odd;
                    break;
                case "None":
                    Port1.Parity = Parity.None;
                    break;
                case "Even":
                    Port1.Parity = Parity.Even;
                    break;
            }
        }

        private void cbBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close();
            }
            switch (cbBit.SelectedItem.ToString())
            {
                case "1":
                    Port1.StopBits = StopBits.One;
                    break;
                case "1.5":
                    Port1.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    Port1.StopBits = StopBits.Two;
                    break;
            }
        }
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            InputData = Port1.ReadLine();

    
            if (InputData != String.Empty)
            {
                 //txinputdata.Text = InputData; // Ko dùng đc như thế này vì khác threads .
                SetText(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.
            }
        }
        //Hàm SetText khi dữ liệu xử lý khác thread
        kayChart SerialDataChart;
        private void SetText(string text)
        {

            if (this.txtkq.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });

            }

            else
            {
                this.uart_json = text;
                txt_1dong.Text = uart_json;
                this.txtkq.Text += text;


                if (mode==true) {
                    try
                    {
                        //a++;
                        JObject com_json = JObject.Parse(uart_json);// Chuyen chuoi string msg sang dang json
                        key_Id = (string)com_json["Id"];
                        txb_Id.Text = key_Id;
                        //Lấy giá trị U1
                        key_U1 = (string)com_json["U1"];
                        txb_U1.Text = key_U1;
                        U1 = float.Parse(key_U1);
                        cir_U1.Value = (int)U1;
                        lb_U1.Text = key_U1;

                        //Lấy giá trị U2
                        key_U2 = (string)com_json["U2"];
                        txb_U2.Text = key_U2;
                        U2 = float.Parse(key_U2);
                        cir_U2.Value = (int)U2;
                        lb_U2.Text = key_U2;

                        //Lấy giá trị I1
                        key_I1 = (string)com_json["I1"];
                        txb_I1.Text = key_I1;
                        I1 = float.Parse(key_I1);
                        cir_I1.Value = (int)(I1 * 10);
                        lb_I1.Text = key_I1;

                        //Lấy giá trị I2
                        key_I2 = (string)com_json["I2"];
                        txb_I2.Text = key_I2;
                        I2 = float.Parse(key_I2);
                        cir_I2.Value = (int)(I2 * 10);
                        lb_I2.Text = key_I2;

                        //Lấy giá trị cosP1
                        key_cosP1 = (string)com_json["cosP1"];
                        txb_cosP1.Text = key_cosP1;
                        cosP1 = float.Parse(key_cosP1);
                        cir_cosP1.Value = (int)(cosP1 * 100);
                        lb_cosP1.Text = key_cosP1;

                        //Lấy giá trị cosP2
                        key_cosP2 = (string)com_json["cosP2"];
                        txb_cosP2.Text = key_cosP2;
                        cosP2 = float.Parse(key_cosP2);
                        cir_cosP2.Value = (int)(cosP2 * 100);
                        lb_cosP2.Text = key_cosP2;

                        // Lấy giá trị S
                        key_S = (string)com_json["csS"];
                        txb_S.Text = key_S;
                        S = float.Parse(key_S); // chuyen sang bien so thuc
                        chart1.Series["S"].Points.AddY(S);

                        // Lấy giá trị P
                        key_P = (string)com_json["csP"];
                        txb_P.Text = key_P;
                        P = float.Parse(key_P);
                        cir_P.Value = (int)P;
                        lb_P.Text = key_P;
                        chart1.Series["P"].Points.AddY(P);

                        //Lấy giá trị Q
                        key_Q = (string)com_json["csQ"];
                        txb_Q.Text = key_Q;
                        Q = float.Parse(key_Q);
                        chart1.Series["Q"].Points.AddY(Q);
                        cir_Q.Value = (int)Q;
                        lb_Q.Text = key_Q;

                        //Lấy giá trị cosP
                        key_cosP = (string)com_json["cosP"];
                        txb_cosP.Text = key_cosP;
                        cosP = float.Parse(key_cosP);
                        cir_cosP.Value = (int)(cosP * 100);
                        lb_cosP.Text = key_cosP;

                        //Lấy giá trị tần số
                        key_freq = (string)com_json["freq"];
                        txb_freq.Text = key_freq;
                        freq = float.Parse(key_freq);
                        cir_freq.Value = (int)freq;
                        lb_freq.Text = key_freq;

                        //Lấy giá trị đỉnh P
                        key_P_peak = (string)com_json["P_peak"];
                        txb_P_peak.Text = key_P_peak;
                        P_peak = float.Parse(key_P_peak);
                        cir_P_peak.Value = (int)P_peak;
                        lb_P_peak.Text = key_P_peak;

                        //Lấy giá trị đỉnh Q
                        key_Q_peak = (string)com_json["Q_peak"];
                        txb_Q_peak.Text = key_Q_peak;
                        Q_peak = float.Parse(key_Q_peak);
                        cir_Q_peak.Value = (int)Q_peak ;
                        lb_Q_peak.Text = key_Q_peak;
                    }
                    catch { }
                    

                    //Math.Round(get_Oat, 2);
                    //chart1.Series["getOat"].Points.AddY(get_Oat);



                }









            }
        }

      
        private void Form1_Load_1(object sender, EventArgs e)
        {
            cbCom.SelectedIndex = 0;
            cbRate.SelectedIndex = 7; // 115200
            cbBits.SelectedIndex = 2; // 8
            cbParity.SelectedIndex = 0; // None
            cbBit.SelectedIndex = 0; // None

            SerialDataChart = new kayChart(chart1, 60);
            txt_time.Text = DateTime.Now.ToLongTimeString();
            txt_date.Text = DateTime.Now.ToLongDateString();
            txtkq.Visible = false;
            txt_1dong.Visible = false;
            panel_rs485.Visible = false;
            panel_wifi.Visible = false;
            panel_main.Visible = false;
            lb_tieude.Text = String.Empty;


            timer1.Interval = 1000;



            // khai báo MQTT
            txb_BrokerName.Text = "tailor.cloudmqtt.com";
            txb_Port.Text = "16370";
            txb_UserName.Text = "hiepbk";
            txb_Password.Text = "8286597";
            Status_mqtt.Checked = false;
            toolStripStatusLabel1.Text = "Hãy chọn chế độ RS485 hoặc Wifi.";



        }
        // Hàm Tick 
        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToLongTimeString();
            txt_date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            if (cb_laymau.Text =="Liên tục") 
            {
                if (tick1 % 2 == 0) 
                {
                    add_data_list_view();
                
                }

            }
            if (cb_laymau.Text == "Theo giờ")
            {
                if ((txt_time.Text == "12:00:00 AM") || (txt_time.Text == "1:00:00 AM") || (txt_time.Text == "2:00:00 AM")
                    || (txt_time.Text == "3:00:00 AM") || (txt_time.Text == "4:00:00 AM") || (txt_time.Text == "5:00:00 AM")
                    || (txt_time.Text == "6:00:00 AM") || (txt_time.Text == "7:00:00 AM") || (txt_time.Text == "8:00:00 AM")
                    || (txt_time.Text == "9:00:00 AM") || (txt_time.Text == "10:00:00 AM") || (txt_time.Text == "11:00:00 AM")
                    || (txt_time.Text == "12:00:00 PM") || (txt_time.Text == "1:00:00 PM") || (txt_time.Text == "2:00:00 PM")
                    || (txt_time.Text == "3:00:00 PM") || (txt_time.Text == "4:00:00 PM") || (txt_time.Text == "5:00:00 PM")
                    || (txt_time.Text == "6:00:00 PM") || (txt_time.Text == "7:00:00 PM") || (txt_time.Text == "8:00:00 PM")
                    || (txt_time.Text == "9:00:00 PM") || (txt_time.Text == "10:00:00 PM") || (txt_time.Text == "11:00:00 PM"))
                {
                    add_data_list_view();

                }

            }
            if (cb_laymau.Text == "Theo ngày")
            {
                if (txt_time.Text=="12:00:00 AM")
                {
                    add_data_list_view();

                }

            }
            tick1++;

        }
        private void add_data_list_view()
        {
            string[] arr = new string[10];
            ListViewItem itm;
            //add items to ListView
            arr[0] = txt_time.Text;
            arr[1] = txt_date.Text;
            arr[2] = key_Id;
            arr[3] = key_P;
            arr[4] = key_Q;
            arr[5] = key_cosP;
            arr[6] = key_freq;
            arr[7] = key_P_peak;
            arr[8] = key_Q_peak;
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }


        Action<string, string> ReceiveAction;

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            ReceiveAction = Receive;
            try
            {
                this.BeginInvoke(ReceiveAction, Encoding.UTF8.GetString(e.Message), e.Topic);
            }
            catch { };
        }
        void Receive(string message, string topic)
        {
            if (topic == "ESP_PUB")
            {

                if (mode == false) {

                    mqtt_json = message;
                    try
                    {
                        JObject wifi_json = JObject.Parse(mqtt_json);// Chuyen chuoi string msg sang dang json


                        string chuoi_json = wifi_json.ToString();

                        if (chuoi_json[6] == 'I')
                        {
                            // Lấy giá trị ID
                            key_Id = (string)wifi_json["Id"];
                            txb_Id.Text = key_Id;
                            //Lấy giá trị U1
                            key_U1 = (string)wifi_json["U1"];
                            txb_U1.Text = key_U1;
                            U1 = float.Parse(key_U1);
                            cir_U1.Value = (int)U1;
                            lb_U1.Text = key_U1;

                            //Lấy giá trị U2
                            key_U2 = (string)wifi_json["U2"];
                            txb_U2.Text = key_U2;
                            U2 = float.Parse(key_U2);
                            cir_U2.Value = (int)U2;
                            lb_U2.Text = key_U2;

                            //Lấy giá trị I1
                            key_I1 = (string)wifi_json["I1"];
                            txb_I1.Text = key_I1;
                            I1 = float.Parse(key_I1);
                            cir_I1.Value = (int)(I1 * 10);
                            lb_I1.Text = key_I1;

                            //Lấy giá trị I2
                            key_I2 = (string)wifi_json["I2"];
                            txb_I2.Text = key_I2;
                            I2 = float.Parse(key_I2);
                            cir_I2.Value = (int)(I2 * 10);
                            lb_I2.Text = key_I2;

                            //Lấy giá trị cosP1
                            key_cosP1 = (string)wifi_json["cosP1"];
                            txb_cosP1.Text = key_cosP1;
                            cosP1 = float.Parse(key_cosP1);
                            cir_cosP1.Value = (int)(cosP1 * 100);
                            lb_cosP1.Text = key_cosP1;

                            //Lấy giá trị cosP2
                            key_cosP2 = (string)wifi_json["cosP2"];
                            txb_cosP2.Text = key_cosP2;
                            cosP2 = float.Parse(key_cosP2);
                            cir_cosP2.Value = (int)(cosP2 * 100);
                            lb_cosP2.Text = key_cosP2;

                        }
                        else
                        {
                            // Lấy giá trị S
                            key_S = (string)wifi_json["csS"];
                            txb_S.Text = key_S;
                            S = float.Parse(key_S); // chuyen sang bien so thuc
                            chart1.Series["S"].Points.AddY(S);

                            // Lấy giá trị P
                            key_P = (string)wifi_json["csP"];
                            txb_P.Text = key_P;
                            P = float.Parse(key_P);
                            cir_P.Value = (int)P;
                            lb_P.Text = key_P;
                            chart1.Series["P"].Points.AddY(P);

                            //Lấy giá trị Q
                            key_Q = (string)wifi_json["csQ"];
                            txb_Q.Text = key_Q;
                            Q = float.Parse(key_Q);
                            chart1.Series["Q"].Points.AddY(Q);
                            cir_Q.Value = (int)Q ;
                            lb_Q.Text = key_Q;

                            //Lấy giá trị cosP
                            key_cosP = (string)wifi_json["cosP"];
                            txb_cosP.Text = key_cosP;
                            cosP = float.Parse(key_cosP);
                            cir_cosP.Value = (int)(cosP * 100);
                            lb_cosP.Text = key_cosP;

                            //Lấy giá trị tần số
                            key_freq = (string)wifi_json["freq"];
                            txb_freq.Text = key_freq;
                            freq = float.Parse(key_freq);
                            cir_freq.Value = (int)freq;
                            lb_freq.Text = key_freq;

                            //Lấy giá trị đỉnh P
                            key_P_peak = (string)wifi_json["P_peak"];
                            txb_P_peak.Text = key_P_peak;
                            P_peak = float.Parse(key_P_peak);
                            cir_P_peak.Value = (int)P_peak;
                            lb_P_peak.Text = key_P_peak;

                            //Lấy giá trị đỉnh Q
                            key_Q_peak = (string)wifi_json["Q_peak"];
                            txb_Q_peak.Text = key_Q_peak;
                            Q_peak = float.Parse(key_Q_peak);
                            cir_Q_peak.Value = (int)Q_peak ;
                            lb_Q_peak.Text = key_Q_peak;
                        }

                    }
                    catch { }

                   


                    //{ key1: [ '1', '0','1','0' ],key2:['1','0','1'] ,key2:['26','50']}


                }
                



           }


        }







    }
}
