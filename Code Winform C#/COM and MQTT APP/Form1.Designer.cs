namespace bunifuapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Port = new System.Windows.Forms.TextBox();
            this.txb_BrokerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_rs485 = new System.Windows.Forms.Panel();
            this.btn_closeport = new MetroFramework.Controls.MetroButton();
            this.btn_openport = new MetroFramework.Controls.MetroButton();
            this.cbBit = new System.Windows.Forms.ComboBox();
            this.cbBits = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel_wifi = new System.Windows.Forms.Panel();
            this.btn_DisconnectMQTT = new MetroFramework.Controls.MetroButton();
            this.btn_ConnectMQTT = new MetroFramework.Controls.MetroButton();
            this.label20 = new System.Windows.Forms.Label();
            this.Status_mqtt = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lb_tieude = new System.Windows.Forms.Label();
            this.pn_chonmode = new System.Windows.Forms.Panel();
            this.btn_wifimode = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label48 = new System.Windows.Forms.Label();
            this.btn_rsmode = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_date = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.cb_laymau = new MetroFramework.Controls.MetroComboBox();
            this.btn_Export = new MetroFramework.Controls.MetroButton();
            this.label50 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.lb_U1 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.lb_I1 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lb_cosP1 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lb_freq = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lb_P = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lb_Q_peak = new System.Windows.Forms.Label();
            this.lb_U2 = new System.Windows.Forms.Label();
            this.cir_Q_peak = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label46 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lb_Q = new System.Windows.Forms.Label();
            this.lb_I2 = new System.Windows.Forms.Label();
            this.cir_Q = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label44 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lb_P_peak = new System.Windows.Forms.Label();
            this.lb_cosP2 = new System.Windows.Forms.Label();
            this.cir_P_peak = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lb_cosP = new System.Windows.Forms.Label();
            this.cir_I2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cir_U2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cir_U1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cir_I1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cir_cosP1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cir_cosP2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cir_freq = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cir_cosP = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cir_P = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label26 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.txb_cosP2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txb_S = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_P = new System.Windows.Forms.TextBox();
            this.txb_U2 = new System.Windows.Forms.TextBox();
            this.txb_Q = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_cosP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_U1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txb_cosP1 = new System.Windows.Forms.TextBox();
            this.txb_freq = new System.Windows.Forms.TextBox();
            this.txb_I2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txb_I1 = new System.Windows.Forms.TextBox();
            this.txb_P_peak = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Q_peak = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Device_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cong_suat_P = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cong_suat_Q = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cos_phi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tan_so = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.P_dinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Q_dinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_1dong = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel_rs485.SuspendLayout();
            this.panel_wifi.SuspendLayout();
            this.pn_chonmode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(329, 48);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(127, 20);
            this.txb_Password.TabIndex = 4;
            // 
            // txb_Port
            // 
            this.txb_Port.Location = new System.Drawing.Point(85, 48);
            this.txb_Port.Name = "txb_Port";
            this.txb_Port.Size = new System.Drawing.Size(127, 20);
            this.txb_Port.TabIndex = 2;
            // 
            // txb_BrokerName
            // 
            this.txb_BrokerName.Location = new System.Drawing.Point(85, 13);
            this.txb_BrokerName.Name = "txb_BrokerName";
            this.txb_BrokerName.Size = new System.Drawing.Size(127, 20);
            this.txb_BrokerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Broker Name";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(329, 13);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(127, 20);
            this.txb_UserName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(245, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Broker Port";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel_rs485);
            this.panel1.Controls.Add(this.panel_wifi);
            this.panel1.Controls.Add(this.lb_tieude);
            this.panel1.Controls.Add(this.pn_chonmode);
            this.panel1.Controls.Add(this.txt_date);
            this.panel1.Controls.Add(this.txt_time);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 132);
            this.panel1.TabIndex = 15;
            // 
            // panel_rs485
            // 
            this.panel_rs485.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_rs485.Controls.Add(this.btn_closeport);
            this.panel_rs485.Controls.Add(this.btn_openport);
            this.panel_rs485.Controls.Add(this.cbBit);
            this.panel_rs485.Controls.Add(this.cbBits);
            this.panel_rs485.Controls.Add(this.label21);
            this.panel_rs485.Controls.Add(this.label13);
            this.panel_rs485.Controls.Add(this.label23);
            this.panel_rs485.Controls.Add(this.cbParity);
            this.panel_rs485.Controls.Add(this.label22);
            this.panel_rs485.Controls.Add(this.cbRate);
            this.panel_rs485.Controls.Add(this.cbCom);
            this.panel_rs485.Controls.Add(this.label15);
            this.panel_rs485.Location = new System.Drawing.Point(443, 48);
            this.panel_rs485.Name = "panel_rs485";
            this.panel_rs485.Size = new System.Drawing.Size(651, 53);
            this.panel_rs485.TabIndex = 106;
            // 
            // btn_closeport
            // 
            this.btn_closeport.Location = new System.Drawing.Point(515, 25);
            this.btn_closeport.Name = "btn_closeport";
            this.btn_closeport.Size = new System.Drawing.Size(75, 23);
            this.btn_closeport.TabIndex = 118;
            this.btn_closeport.Text = "Close";
            this.btn_closeport.UseSelectable = true;
            this.btn_closeport.Click += new System.EventHandler(this.btn_closeport_Click);
            // 
            // btn_openport
            // 
            this.btn_openport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_openport.ForeColor = System.Drawing.Color.YellowGreen;
            this.btn_openport.Location = new System.Drawing.Point(426, 25);
            this.btn_openport.Name = "btn_openport";
            this.btn_openport.Size = new System.Drawing.Size(75, 23);
            this.btn_openport.TabIndex = 117;
            this.btn_openport.Text = "Open";
            this.btn_openport.UseSelectable = true;
            this.btn_openport.Click += new System.EventHandler(this.btn_openport_Click);
            // 
            // cbBit
            // 
            this.cbBit.FormattingEnabled = true;
            this.cbBit.Location = new System.Drawing.Point(331, 27);
            this.cbBit.Name = "cbBit";
            this.cbBit.Size = new System.Drawing.Size(75, 21);
            this.cbBit.TabIndex = 63;
            this.cbBit.SelectedIndexChanged += new System.EventHandler(this.cbBit_SelectedIndexChanged);
            // 
            // cbBits
            // 
            this.cbBits.FormattingEnabled = true;
            this.cbBits.Location = new System.Drawing.Point(169, 27);
            this.cbBits.Name = "cbBits";
            this.cbBits.Size = new System.Drawing.Size(75, 21);
            this.cbBits.TabIndex = 64;
            this.cbBits.SelectedIndexChanged += new System.EventHandler(this.cbBits_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(184, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 66;
            this.label21.Text = "Databits";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Select Device";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(347, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 13);
            this.label23.TabIndex = 68;
            this.label23.Text = "Stopbit";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(250, 27);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(75, 21);
            this.cbParity.TabIndex = 61;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(263, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 67;
            this.label22.Text = "Parity";
            // 
            // cbRate
            // 
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Location = new System.Drawing.Point(88, 27);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(75, 21);
            this.cbRate.TabIndex = 62;
            this.cbRate.SelectedIndexChanged += new System.EventHandler(this.cbRate_SelectedIndexChanged);
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(7, 27);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(75, 21);
            this.cbCom.TabIndex = 60;
            this.cbCom.SelectedIndexChanged += new System.EventHandler(this.cbCom_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(99, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "Baud rate";
            // 
            // panel_wifi
            // 
            this.panel_wifi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_wifi.Controls.Add(this.btn_DisconnectMQTT);
            this.panel_wifi.Controls.Add(this.btn_ConnectMQTT);
            this.panel_wifi.Controls.Add(this.label20);
            this.panel_wifi.Controls.Add(this.txb_UserName);
            this.panel_wifi.Controls.Add(this.Status_mqtt);
            this.panel_wifi.Controls.Add(this.label3);
            this.panel_wifi.Controls.Add(this.txb_BrokerName);
            this.panel_wifi.Controls.Add(this.label1);
            this.panel_wifi.Controls.Add(this.label2);
            this.panel_wifi.Controls.Add(this.txb_Port);
            this.panel_wifi.Controls.Add(this.txb_Password);
            this.panel_wifi.Location = new System.Drawing.Point(443, 45);
            this.panel_wifi.Name = "panel_wifi";
            this.panel_wifi.Size = new System.Drawing.Size(604, 78);
            this.panel_wifi.TabIndex = 19;
            // 
            // btn_DisconnectMQTT
            // 
            this.btn_DisconnectMQTT.Location = new System.Drawing.Point(479, 48);
            this.btn_DisconnectMQTT.Name = "btn_DisconnectMQTT";
            this.btn_DisconnectMQTT.Size = new System.Drawing.Size(75, 20);
            this.btn_DisconnectMQTT.TabIndex = 119;
            this.btn_DisconnectMQTT.Text = "Disconnect";
            this.btn_DisconnectMQTT.UseSelectable = true;
            this.btn_DisconnectMQTT.Click += new System.EventHandler(this.btn_DisconnectMQTT_Click);
            // 
            // btn_ConnectMQTT
            // 
            this.btn_ConnectMQTT.Location = new System.Drawing.Point(479, 13);
            this.btn_ConnectMQTT.Name = "btn_ConnectMQTT";
            this.btn_ConnectMQTT.Size = new System.Drawing.Size(75, 20);
            this.btn_ConnectMQTT.TabIndex = 118;
            this.btn_ConnectMQTT.Text = "Connect";
            this.btn_ConnectMQTT.UseSelectable = true;
            this.btn_ConnectMQTT.Click += new System.EventHandler(this.btn_ConnectMQTT_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(245, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Password";
            // 
            // Status_mqtt
            // 
            this.Status_mqtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Status_mqtt.ChechedOffColor = System.Drawing.Color.Red;
            this.Status_mqtt.Checked = true;
            this.Status_mqtt.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Status_mqtt.ForeColor = System.Drawing.Color.White;
            this.Status_mqtt.Location = new System.Drawing.Point(571, 13);
            this.Status_mqtt.Name = "Status_mqtt";
            this.Status_mqtt.Size = new System.Drawing.Size(20, 20);
            this.Status_mqtt.TabIndex = 6;
            this.Status_mqtt.Tag = "";
            // 
            // lb_tieude
            // 
            this.lb_tieude.AutoSize = true;
            this.lb_tieude.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieude.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_tieude.Location = new System.Drawing.Point(414, 10);
            this.lb_tieude.Name = "lb_tieude";
            this.lb_tieude.Size = new System.Drawing.Size(655, 68);
            this.lb_tieude.TabIndex = 108;
            this.lb_tieude.Text = "GIÁM SÁT THÔNG SỐ TỔ MÁY PHÁT ĐIỆN RS485\r\n\r\n";
            // 
            // pn_chonmode
            // 
            this.pn_chonmode.BackColor = System.Drawing.Color.Transparent;
            this.pn_chonmode.Controls.Add(this.btn_wifimode);
            this.pn_chonmode.Controls.Add(this.label48);
            this.pn_chonmode.Controls.Add(this.btn_rsmode);
            this.pn_chonmode.Location = new System.Drawing.Point(139, 12);
            this.pn_chonmode.Name = "pn_chonmode";
            this.pn_chonmode.Size = new System.Drawing.Size(211, 109);
            this.pn_chonmode.TabIndex = 116;
            // 
            // btn_wifimode
            // 
            this.btn_wifimode.ActiveBorderThickness = 1;
            this.btn_wifimode.ActiveCornerRadius = 1;
            this.btn_wifimode.ActiveFillColor = System.Drawing.Color.LightGreen;
            this.btn_wifimode.ActiveForecolor = System.Drawing.Color.White;
            this.btn_wifimode.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_wifimode.BackColor = System.Drawing.Color.Transparent;
            this.btn_wifimode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_wifimode.BackgroundImage")));
            this.btn_wifimode.ButtonText = "WIFI";
            this.btn_wifimode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wifimode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wifimode.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_wifimode.IdleBorderThickness = 1;
            this.btn_wifimode.IdleCornerRadius = 1;
            this.btn_wifimode.IdleFillColor = System.Drawing.Color.White;
            this.btn_wifimode.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_wifimode.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_wifimode.Location = new System.Drawing.Point(113, 42);
            this.btn_wifimode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_wifimode.Name = "btn_wifimode";
            this.btn_wifimode.Size = new System.Drawing.Size(63, 54);
            this.btn_wifimode.TabIndex = 115;
            this.btn_wifimode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_wifimode.Click += new System.EventHandler(this.btn_wifimode_Click_2);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.Snow;
            this.label48.Location = new System.Drawing.Point(21, 18);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(180, 19);
            this.label48.TabIndex = 111;
            this.label48.Text = "CHỌN CHẾ ĐỘ KẾT NỐI";
            // 
            // btn_rsmode
            // 
            this.btn_rsmode.ActiveBorderThickness = 1;
            this.btn_rsmode.ActiveCornerRadius = 1;
            this.btn_rsmode.ActiveFillColor = System.Drawing.Color.Tomato;
            this.btn_rsmode.ActiveForecolor = System.Drawing.Color.White;
            this.btn_rsmode.ActiveLineColor = System.Drawing.Color.Ivory;
            this.btn_rsmode.BackColor = System.Drawing.Color.Transparent;
            this.btn_rsmode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rsmode.BackgroundImage")));
            this.btn_rsmode.ButtonText = "RS485";
            this.btn_rsmode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rsmode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rsmode.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_rsmode.IdleBorderThickness = 1;
            this.btn_rsmode.IdleCornerRadius = 1;
            this.btn_rsmode.IdleFillColor = System.Drawing.Color.White;
            this.btn_rsmode.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_rsmode.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_rsmode.Location = new System.Drawing.Point(41, 42);
            this.btn_rsmode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_rsmode.Name = "btn_rsmode";
            this.btn_rsmode.Size = new System.Drawing.Size(63, 54);
            this.btn_rsmode.TabIndex = 114;
            this.btn_rsmode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_rsmode.Click += new System.EventHandler(this.btn_rsmode_Click);
            // 
            // txt_date
            // 
            this.txt_date.AutoSize = true;
            this.txt_date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_date.Location = new System.Drawing.Point(1256, 58);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(102, 13);
            this.txt_date.TabIndex = 21;
            this.txt_date.Text = "12 Tháng Sáu 2020";
            // 
            // txt_time
            // 
            this.txt_time.AutoSize = true;
            this.txt_time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_time.Location = new System.Drawing.Point(1272, 31);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(68, 13);
            this.txt_time.TabIndex = 20;
            this.txt_time.Text = "00:00:00 AM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_main.Controls.Add(this.cb_laymau);
            this.panel_main.Controls.Add(this.btn_Export);
            this.panel_main.Controls.Add(this.label50);
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Controls.Add(this.label26);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.listView1);
            this.panel_main.Controls.Add(this.chart1);
            this.panel_main.Controls.Add(this.txt_1dong);
            this.panel_main.Controls.Add(this.txtkq);
            this.panel_main.Location = new System.Drawing.Point(0, 138);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1376, 585);
            this.panel_main.TabIndex = 20;
            // 
            // cb_laymau
            // 
            this.cb_laymau.FormattingEnabled = true;
            this.cb_laymau.ItemHeight = 23;
            this.cb_laymau.Items.AddRange(new object[] {
            "Liên tục",
            "Theo giờ",
            "Theo ngày"});
            this.cb_laymau.Location = new System.Drawing.Point(1152, 291);
            this.cb_laymau.Name = "cb_laymau";
            this.cb_laymau.Size = new System.Drawing.Size(121, 29);
            this.cb_laymau.TabIndex = 175;
            this.cb_laymau.UseSelectable = true;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(1279, 291);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(91, 29);
            this.btn_Export.TabIndex = 174;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseSelectable = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(242, 295);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(202, 24);
            this.label50.TabIndex = 173;
            this.label50.Text = "THÔNG SỐ TỔ MÁY ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label43);
            this.panel3.Controls.Add(this.lb_U1);
            this.panel3.Controls.Add(this.label45);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label47);
            this.panel3.Controls.Add(this.label49);
            this.panel3.Controls.Add(this.lb_I1);
            this.panel3.Controls.Add(this.label38);
            this.panel3.Controls.Add(this.label40);
            this.panel3.Controls.Add(this.label39);
            this.panel3.Controls.Add(this.label41);
            this.panel3.Controls.Add(this.lb_cosP1);
            this.panel3.Controls.Add(this.label42);
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.lb_freq);
            this.panel3.Controls.Add(this.label37);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.lb_P);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.lb_Q_peak);
            this.panel3.Controls.Add(this.lb_U2);
            this.panel3.Controls.Add(this.cir_Q_peak);
            this.panel3.Controls.Add(this.label46);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.lb_Q);
            this.panel3.Controls.Add(this.lb_I2);
            this.panel3.Controls.Add(this.cir_Q);
            this.panel3.Controls.Add(this.label44);
            this.panel3.Controls.Add(this.label36);
            this.panel3.Controls.Add(this.lb_P_peak);
            this.panel3.Controls.Add(this.lb_cosP2);
            this.panel3.Controls.Add(this.cir_P_peak);
            this.panel3.Controls.Add(this.lb_cosP);
            this.panel3.Controls.Add(this.cir_I2);
            this.panel3.Controls.Add(this.cir_U2);
            this.panel3.Controls.Add(this.cir_U1);
            this.panel3.Controls.Add(this.cir_I1);
            this.panel3.Controls.Add(this.cir_cosP1);
            this.panel3.Controls.Add(this.cir_cosP2);
            this.panel3.Controls.Add(this.cir_freq);
            this.panel3.Controls.Add(this.cir_cosP);
            this.panel3.Controls.Add(this.cir_P);
            this.panel3.Location = new System.Drawing.Point(0, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 264);
            this.panel3.TabIndex = 172;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Maroon;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.LightYellow;
            this.label43.Location = new System.Drawing.Point(660, 232);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(59, 16);
            this.label43.TabIndex = 170;
            this.label43.Text = "Q Peak";
            this.label43.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_U1
            // 
            this.lb_U1.AutoSize = true;
            this.lb_U1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_U1.ForeColor = System.Drawing.Color.Black;
            this.lb_U1.Location = new System.Drawing.Point(48, 46);
            this.lb_U1.Name = "lb_U1";
            this.lb_U1.Size = new System.Drawing.Size(23, 13);
            this.lb_U1.TabIndex = 109;
            this.lb_U1.Text = "U1";
            this.lb_U1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Maroon;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.LightYellow;
            this.label45.Location = new System.Drawing.Point(678, 115);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(19, 16);
            this.label45.TabIndex = 169;
            this.label45.Text = "Q";
            this.label45.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Silver;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(57, 72);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 13);
            this.label29.TabIndex = 110;
            this.label29.Text = "KV";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Maroon;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.LightYellow;
            this.label47.Location = new System.Drawing.Point(539, 232);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(58, 16);
            this.label47.TabIndex = 168;
            this.label47.Text = "P Peak";
            this.label47.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Maroon;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.LightYellow;
            this.label49.Location = new System.Drawing.Point(553, 115);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(18, 16);
            this.label49.TabIndex = 167;
            this.label49.Text = "P";
            this.label49.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_I1
            // 
            this.lb_I1.AutoSize = true;
            this.lb_I1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_I1.ForeColor = System.Drawing.Color.Black;
            this.lb_I1.Location = new System.Drawing.Point(168, 46);
            this.lb_I1.Name = "lb_I1";
            this.lb_I1.Size = new System.Drawing.Size(18, 13);
            this.lb_I1.TabIndex = 127;
            this.lb_I1.Text = "I1";
            this.lb_I1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Maroon;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.LightYellow;
            this.label38.Location = new System.Drawing.Point(424, 232);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(43, 16);
            this.label38.TabIndex = 166;
            this.label38.Text = "cosP";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Silver;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(178, 72);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(23, 13);
            this.label40.TabIndex = 128;
            this.label40.Text = "KA";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Maroon;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.LightYellow;
            this.label39.Location = new System.Drawing.Point(434, 115);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(18, 16);
            this.label39.TabIndex = 165;
            this.label39.Text = "S";
            this.label39.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Maroon;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.LightYellow;
            this.label41.Location = new System.Drawing.Point(289, 232);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(51, 16);
            this.label41.TabIndex = 164;
            this.label41.Text = "cosP2";
            this.label41.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_cosP1
            // 
            this.lb_cosP1.AutoSize = true;
            this.lb_cosP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cosP1.ForeColor = System.Drawing.Color.Black;
            this.lb_cosP1.Location = new System.Drawing.Point(289, 57);
            this.lb_cosP1.Name = "lb_cosP1";
            this.lb_cosP1.Size = new System.Drawing.Size(42, 13);
            this.lb_cosP1.TabIndex = 130;
            this.lb_cosP1.Text = "cosP1";
            this.lb_cosP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Maroon;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.LightYellow;
            this.label42.Location = new System.Drawing.Point(289, 115);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(51, 16);
            this.label42.TabIndex = 163;
            this.label42.Text = "cosP1";
            this.label42.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Maroon;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.LightYellow;
            this.label35.Location = new System.Drawing.Point(182, 232);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(20, 16);
            this.label35.TabIndex = 162;
            this.label35.Text = "I2";
            this.label35.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_freq
            // 
            this.lb_freq.AutoSize = true;
            this.lb_freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_freq.ForeColor = System.Drawing.Color.Black;
            this.lb_freq.Location = new System.Drawing.Point(417, 46);
            this.lb_freq.Name = "lb_freq";
            this.lb_freq.Size = new System.Drawing.Size(32, 13);
            this.lb_freq.TabIndex = 133;
            this.lb_freq.Text = "Freq";
            this.lb_freq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Maroon;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.LightYellow;
            this.label37.Location = new System.Drawing.Point(181, 115);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(20, 16);
            this.label37.TabIndex = 161;
            this.label37.Text = "I1";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Silver;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(430, 72);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(22, 13);
            this.label32.TabIndex = 134;
            this.label32.Text = "Hz";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Maroon;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.LightYellow;
            this.label33.Location = new System.Drawing.Point(57, 232);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(27, 16);
            this.label33.TabIndex = 160;
            this.label33.Text = "U2";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_P
            // 
            this.lb_P.AutoSize = true;
            this.lb_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_P.ForeColor = System.Drawing.Color.Black;
            this.lb_P.Location = new System.Drawing.Point(547, 46);
            this.lb_P.Name = "lb_P";
            this.lb_P.Size = new System.Drawing.Size(15, 13);
            this.lb_P.TabIndex = 136;
            this.lb_P.Text = "P";
            this.lb_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Maroon;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.LightYellow;
            this.label30.Location = new System.Drawing.Point(56, 115);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 16);
            this.label30.TabIndex = 159;
            this.label30.Text = "U1";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Silver;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(551, 72);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 13);
            this.label34.TabIndex = 137;
            this.label34.Text = "KW";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Silver;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(672, 191);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 158;
            this.label24.Text = "KVAR";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Q_peak
            // 
            this.lb_Q_peak.AutoSize = true;
            this.lb_Q_peak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Q_peak.ForeColor = System.Drawing.Color.Black;
            this.lb_Q_peak.Location = new System.Drawing.Point(660, 165);
            this.lb_Q_peak.Name = "lb_Q_peak";
            this.lb_Q_peak.Size = new System.Drawing.Size(49, 13);
            this.lb_Q_peak.TabIndex = 157;
            this.lb_Q_peak.Text = "Q Peak";
            this.lb_Q_peak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_U2
            // 
            this.lb_U2.AutoSize = true;
            this.lb_U2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_U2.ForeColor = System.Drawing.Color.Black;
            this.lb_U2.Location = new System.Drawing.Point(48, 165);
            this.lb_U2.Name = "lb_U2";
            this.lb_U2.Size = new System.Drawing.Size(23, 13);
            this.lb_U2.TabIndex = 139;
            this.lb_U2.Text = "U2";
            this.lb_U2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cir_Q_peak
            // 
            this.cir_Q_peak.animated = false;
            this.cir_Q_peak.animationIterval = 5;
            this.cir_Q_peak.animationSpeed = 300;
            this.cir_Q_peak.BackColor = System.Drawing.Color.Silver;
            this.cir_Q_peak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_Q_peak.BackgroundImage")));
            this.cir_Q_peak.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_Q_peak.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_Q_peak.LabelVisible = false;
            this.cir_Q_peak.LineProgressThickness = 8;
            this.cir_Q_peak.LineThickness = 5;
            this.cir_Q_peak.Location = new System.Drawing.Point(633, 134);
            this.cir_Q_peak.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_Q_peak.MaxValue = 100;
            this.cir_Q_peak.Name = "cir_Q_peak";
            this.cir_Q_peak.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_Q_peak.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cir_Q_peak.Size = new System.Drawing.Size(101, 101);
            this.cir_Q_peak.TabIndex = 156;
            this.cir_Q_peak.Value = 1;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Silver;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(57, 191);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(23, 13);
            this.label46.TabIndex = 140;
            this.label46.Text = "KV";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Silver;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(672, 72);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(40, 13);
            this.label31.TabIndex = 155;
            this.label31.Text = "KVAR";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Q
            // 
            this.lb_Q.AutoSize = true;
            this.lb_Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Q.ForeColor = System.Drawing.Color.Black;
            this.lb_Q.Location = new System.Drawing.Point(660, 46);
            this.lb_Q.Name = "lb_Q";
            this.lb_Q.Size = new System.Drawing.Size(16, 13);
            this.lb_Q.TabIndex = 154;
            this.lb_Q.Text = "Q";
            this.lb_Q.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_I2
            // 
            this.lb_I2.AutoSize = true;
            this.lb_I2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_I2.ForeColor = System.Drawing.Color.Black;
            this.lb_I2.Location = new System.Drawing.Point(168, 165);
            this.lb_I2.Name = "lb_I2";
            this.lb_I2.Size = new System.Drawing.Size(18, 13);
            this.lb_I2.TabIndex = 142;
            this.lb_I2.Text = "I2";
            this.lb_I2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cir_Q
            // 
            this.cir_Q.animated = false;
            this.cir_Q.animationIterval = 5;
            this.cir_Q.animationSpeed = 300;
            this.cir_Q.BackColor = System.Drawing.Color.Silver;
            this.cir_Q.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_Q.BackgroundImage")));
            this.cir_Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_Q.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_Q.LabelVisible = false;
            this.cir_Q.LineProgressThickness = 8;
            this.cir_Q.LineThickness = 5;
            this.cir_Q.Location = new System.Drawing.Point(633, 15);
            this.cir_Q.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_Q.MaxValue = 100;
            this.cir_Q.Name = "cir_Q";
            this.cir_Q.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_Q.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cir_Q.Size = new System.Drawing.Size(101, 101);
            this.cir_Q.TabIndex = 153;
            this.cir_Q.Value = 1;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Silver;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(178, 191);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(23, 13);
            this.label44.TabIndex = 143;
            this.label44.Text = "KA";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Silver;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(551, 191);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 13);
            this.label36.TabIndex = 152;
            this.label36.Text = "KV";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_P_peak
            // 
            this.lb_P_peak.AutoSize = true;
            this.lb_P_peak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_P_peak.ForeColor = System.Drawing.Color.Black;
            this.lb_P_peak.Location = new System.Drawing.Point(539, 165);
            this.lb_P_peak.Name = "lb_P_peak";
            this.lb_P_peak.Size = new System.Drawing.Size(48, 13);
            this.lb_P_peak.TabIndex = 151;
            this.lb_P_peak.Text = "P Peak";
            this.lb_P_peak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_cosP2
            // 
            this.lb_cosP2.AutoSize = true;
            this.lb_cosP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cosP2.ForeColor = System.Drawing.Color.Black;
            this.lb_cosP2.Location = new System.Drawing.Point(289, 176);
            this.lb_cosP2.Name = "lb_cosP2";
            this.lb_cosP2.Size = new System.Drawing.Size(42, 13);
            this.lb_cosP2.TabIndex = 145;
            this.lb_cosP2.Text = "cosP2";
            this.lb_cosP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cir_P_peak
            // 
            this.cir_P_peak.animated = false;
            this.cir_P_peak.animationIterval = 5;
            this.cir_P_peak.animationSpeed = 300;
            this.cir_P_peak.BackColor = System.Drawing.Color.Silver;
            this.cir_P_peak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_P_peak.BackgroundImage")));
            this.cir_P_peak.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_P_peak.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_P_peak.LabelVisible = false;
            this.cir_P_peak.LineProgressThickness = 8;
            this.cir_P_peak.LineThickness = 5;
            this.cir_P_peak.Location = new System.Drawing.Point(512, 134);
            this.cir_P_peak.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_P_peak.MaxValue = 100;
            this.cir_P_peak.Name = "cir_P_peak";
            this.cir_P_peak.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_P_peak.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cir_P_peak.Size = new System.Drawing.Size(101, 101);
            this.cir_P_peak.TabIndex = 150;
            this.cir_P_peak.Value = 50;
            // 
            // lb_cosP
            // 
            this.lb_cosP.AutoSize = true;
            this.lb_cosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cosP.ForeColor = System.Drawing.Color.Black;
            this.lb_cosP.Location = new System.Drawing.Point(417, 176);
            this.lb_cosP.Name = "lb_cosP";
            this.lb_cosP.Size = new System.Drawing.Size(35, 13);
            this.lb_cosP.TabIndex = 148;
            this.lb_cosP.Text = "cosP";
            this.lb_cosP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cir_I2
            // 
            this.cir_I2.animated = false;
            this.cir_I2.animationIterval = 5;
            this.cir_I2.animationSpeed = 300;
            this.cir_I2.BackColor = System.Drawing.Color.Silver;
            this.cir_I2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_I2.BackgroundImage")));
            this.cir_I2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_I2.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_I2.LabelVisible = false;
            this.cir_I2.LineProgressThickness = 8;
            this.cir_I2.LineThickness = 5;
            this.cir_I2.Location = new System.Drawing.Point(139, 134);
            this.cir_I2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_I2.MaxValue = 30;
            this.cir_I2.Name = "cir_I2";
            this.cir_I2.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_I2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cir_I2.Size = new System.Drawing.Size(101, 101);
            this.cir_I2.TabIndex = 141;
            this.cir_I2.Value = 1;
            // 
            // cir_U2
            // 
            this.cir_U2.animated = false;
            this.cir_U2.animationIterval = 5;
            this.cir_U2.animationSpeed = 300;
            this.cir_U2.BackColor = System.Drawing.Color.Silver;
            this.cir_U2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_U2.BackgroundImage")));
            this.cir_U2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_U2.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_U2.LabelVisible = false;
            this.cir_U2.LineProgressThickness = 8;
            this.cir_U2.LineThickness = 5;
            this.cir_U2.Location = new System.Drawing.Point(18, 134);
            this.cir_U2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_U2.MaxValue = 150;
            this.cir_U2.Name = "cir_U2";
            this.cir_U2.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_U2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cir_U2.Size = new System.Drawing.Size(101, 101);
            this.cir_U2.TabIndex = 138;
            this.cir_U2.Value = 50;
            // 
            // cir_U1
            // 
            this.cir_U1.animated = false;
            this.cir_U1.animationIterval = 5;
            this.cir_U1.animationSpeed = 300;
            this.cir_U1.BackColor = System.Drawing.Color.Silver;
            this.cir_U1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_U1.BackgroundImage")));
            this.cir_U1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_U1.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_U1.LabelVisible = false;
            this.cir_U1.LineProgressThickness = 8;
            this.cir_U1.LineThickness = 5;
            this.cir_U1.Location = new System.Drawing.Point(18, 15);
            this.cir_U1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_U1.MaxValue = 150;
            this.cir_U1.Name = "cir_U1";
            this.cir_U1.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_U1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cir_U1.Size = new System.Drawing.Size(101, 101);
            this.cir_U1.TabIndex = 108;
            this.cir_U1.Value = 50;
            // 
            // cir_I1
            // 
            this.cir_I1.animated = false;
            this.cir_I1.animationIterval = 5;
            this.cir_I1.animationSpeed = 300;
            this.cir_I1.BackColor = System.Drawing.Color.Silver;
            this.cir_I1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_I1.BackgroundImage")));
            this.cir_I1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_I1.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_I1.LabelVisible = false;
            this.cir_I1.LineProgressThickness = 8;
            this.cir_I1.LineThickness = 5;
            this.cir_I1.Location = new System.Drawing.Point(139, 15);
            this.cir_I1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_I1.MaxValue = 30;
            this.cir_I1.Name = "cir_I1";
            this.cir_I1.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_I1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cir_I1.Size = new System.Drawing.Size(101, 101);
            this.cir_I1.TabIndex = 126;
            this.cir_I1.Value = 1;
            // 
            // cir_cosP1
            // 
            this.cir_cosP1.animated = false;
            this.cir_cosP1.animationIterval = 5;
            this.cir_cosP1.animationSpeed = 300;
            this.cir_cosP1.BackColor = System.Drawing.Color.Silver;
            this.cir_cosP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_cosP1.BackgroundImage")));
            this.cir_cosP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_cosP1.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_cosP1.LabelVisible = false;
            this.cir_cosP1.LineProgressThickness = 8;
            this.cir_cosP1.LineThickness = 5;
            this.cir_cosP1.Location = new System.Drawing.Point(260, 15);
            this.cir_cosP1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_cosP1.MaxValue = 105;
            this.cir_cosP1.Name = "cir_cosP1";
            this.cir_cosP1.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_cosP1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cir_cosP1.Size = new System.Drawing.Size(101, 101);
            this.cir_cosP1.TabIndex = 129;
            this.cir_cosP1.Value = 0;
            // 
            // cir_cosP2
            // 
            this.cir_cosP2.animated = false;
            this.cir_cosP2.animationIterval = 5;
            this.cir_cosP2.animationSpeed = 300;
            this.cir_cosP2.BackColor = System.Drawing.Color.Silver;
            this.cir_cosP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_cosP2.BackgroundImage")));
            this.cir_cosP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_cosP2.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_cosP2.LabelVisible = false;
            this.cir_cosP2.LineProgressThickness = 8;
            this.cir_cosP2.LineThickness = 5;
            this.cir_cosP2.Location = new System.Drawing.Point(260, 134);
            this.cir_cosP2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_cosP2.MaxValue = 105;
            this.cir_cosP2.Name = "cir_cosP2";
            this.cir_cosP2.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_cosP2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cir_cosP2.Size = new System.Drawing.Size(101, 101);
            this.cir_cosP2.TabIndex = 144;
            this.cir_cosP2.Value = 0;
            // 
            // cir_freq
            // 
            this.cir_freq.animated = false;
            this.cir_freq.animationIterval = 5;
            this.cir_freq.animationSpeed = 300;
            this.cir_freq.BackColor = System.Drawing.Color.Silver;
            this.cir_freq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_freq.BackgroundImage")));
            this.cir_freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_freq.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_freq.LabelVisible = false;
            this.cir_freq.LineProgressThickness = 8;
            this.cir_freq.LineThickness = 5;
            this.cir_freq.Location = new System.Drawing.Point(391, 15);
            this.cir_freq.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_freq.MaxValue = 100;
            this.cir_freq.Name = "cir_freq";
            this.cir_freq.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_freq.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cir_freq.Size = new System.Drawing.Size(101, 101);
            this.cir_freq.TabIndex = 132;
            this.cir_freq.Value = 50;
            // 
            // cir_cosP
            // 
            this.cir_cosP.animated = false;
            this.cir_cosP.animationIterval = 5;
            this.cir_cosP.animationSpeed = 300;
            this.cir_cosP.BackColor = System.Drawing.Color.Silver;
            this.cir_cosP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_cosP.BackgroundImage")));
            this.cir_cosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_cosP.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_cosP.LabelVisible = false;
            this.cir_cosP.LineProgressThickness = 8;
            this.cir_cosP.LineThickness = 5;
            this.cir_cosP.Location = new System.Drawing.Point(391, 134);
            this.cir_cosP.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_cosP.MaxValue = 105;
            this.cir_cosP.Name = "cir_cosP";
            this.cir_cosP.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_cosP.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cir_cosP.Size = new System.Drawing.Size(101, 101);
            this.cir_cosP.TabIndex = 147;
            this.cir_cosP.Value = 0;
            // 
            // cir_P
            // 
            this.cir_P.animated = false;
            this.cir_P.animationIterval = 5;
            this.cir_P.animationSpeed = 300;
            this.cir_P.BackColor = System.Drawing.Color.Silver;
            this.cir_P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cir_P.BackgroundImage")));
            this.cir_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cir_P.ForeColor = System.Drawing.Color.SeaGreen;
            this.cir_P.LabelVisible = false;
            this.cir_P.LineProgressThickness = 8;
            this.cir_P.LineThickness = 5;
            this.cir_P.Location = new System.Drawing.Point(512, 15);
            this.cir_P.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cir_P.MaxValue = 100;
            this.cir_P.Name = "cir_P";
            this.cir_P.ProgressBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir_P.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cir_P.Size = new System.Drawing.Size(101, 101);
            this.cir_P.TabIndex = 135;
            this.cir_P.Value = 50;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(876, 295);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(262, 24);
            this.label26.TabIndex = 107;
            this.label26.Text = "THỐNG KÊ GIÁ TRỊ ĐỈNH\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label51);
            this.panel2.Controls.Add(this.txb_cosP2);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.txb_S);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txb_P);
            this.panel2.Controls.Add(this.txb_U2);
            this.panel2.Controls.Add(this.txb_Q);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txb_cosP);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txb_Id);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txb_U1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txb_cosP1);
            this.panel2.Controls.Add(this.txb_freq);
            this.panel2.Controls.Add(this.txb_I2);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txb_I1);
            this.panel2.Controls.Add(this.txb_P_peak);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txb_Q_peak);
            this.panel2.Location = new System.Drawing.Point(880, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 280);
            this.panel2.TabIndex = 107;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(141, 215);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(0, 13);
            this.label51.TabIndex = 107;
            // 
            // txb_cosP2
            // 
            this.txb_cosP2.Location = new System.Drawing.Point(398, 215);
            this.txb_cosP2.Name = "txb_cosP2";
            this.txb_cosP2.Size = new System.Drawing.Size(60, 20);
            this.txb_cosP2.TabIndex = 97;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(152, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(190, 24);
            this.label25.TabIndex = 106;
            this.label25.Text = "THÔNG SỐ TỔ MÁY";
            // 
            // txb_S
            // 
            this.txb_S.Location = new System.Drawing.Point(27, 145);
            this.txb_S.Name = "txb_S";
            this.txb_S.Size = new System.Drawing.Size(60, 20);
            this.txb_S.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(401, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "U2 [kvV]";
            // 
            // txb_P
            // 
            this.txb_P.Location = new System.Drawing.Point(121, 145);
            this.txb_P.Name = "txb_P";
            this.txb_P.Size = new System.Drawing.Size(60, 20);
            this.txb_P.TabIndex = 76;
            // 
            // txb_U2
            // 
            this.txb_U2.Location = new System.Drawing.Point(398, 77);
            this.txb_U2.Name = "txb_U2";
            this.txb_U2.Size = new System.Drawing.Size(60, 20);
            this.txb_U2.TabIndex = 104;
            // 
            // txb_Q
            // 
            this.txb_Q.Location = new System.Drawing.Point(213, 145);
            this.txb_Q.Name = "txb_Q";
            this.txb_Q.Size = new System.Drawing.Size(60, 20);
            this.txb_Q.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(408, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 103;
            this.label7.Text = "cosP2";
            // 
            // txb_cosP
            // 
            this.txb_cosP.Location = new System.Drawing.Point(27, 215);
            this.txb_cosP.Name = "txb_cosP";
            this.txb_cosP.Size = new System.Drawing.Size(60, 20);
            this.txb_cosP.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(314, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "cosP1";
            // 
            // txb_Id
            // 
            this.txb_Id.BackColor = System.Drawing.SystemColors.Window;
            this.txb_Id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txb_Id.Location = new System.Drawing.Point(28, 77);
            this.txb_Id.Name = "txb_Id";
            this.txb_Id.Size = new System.Drawing.Size(60, 20);
            this.txb_Id.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(402, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 101;
            this.label9.Text = "I2 [kA]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Device ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(310, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 100;
            this.label18.Text = "I1 [kA]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(30, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 81;
            this.label10.Text = "S [MVA]";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(310, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 16);
            this.label19.TabIndex = 99;
            this.label19.Text = "U1 [kV]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(125, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 82;
            this.label11.Text = "P [MW]";
            // 
            // txb_U1
            // 
            this.txb_U1.Location = new System.Drawing.Point(305, 77);
            this.txb_U1.Name = "txb_U1";
            this.txb_U1.Size = new System.Drawing.Size(60, 20);
            this.txb_U1.TabIndex = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(215, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 83;
            this.label12.Text = "Q [MVAr]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(39, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 16);
            this.label14.TabIndex = 84;
            this.label14.Text = "CosP";
            // 
            // txb_cosP1
            // 
            this.txb_cosP1.Location = new System.Drawing.Point(305, 215);
            this.txb_cosP1.Name = "txb_cosP1";
            this.txb_cosP1.Size = new System.Drawing.Size(60, 20);
            this.txb_cosP1.TabIndex = 96;
            // 
            // txb_freq
            // 
            this.txb_freq.Location = new System.Drawing.Point(121, 77);
            this.txb_freq.Name = "txb_freq";
            this.txb_freq.Size = new System.Drawing.Size(60, 20);
            this.txb_freq.TabIndex = 85;
            // 
            // txb_I2
            // 
            this.txb_I2.Location = new System.Drawing.Point(398, 145);
            this.txb_I2.Name = "txb_I2";
            this.txb_I2.Size = new System.Drawing.Size(60, 20);
            this.txb_I2.TabIndex = 95;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(119, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 86;
            this.label16.Text = "Freq [Hz]";
            // 
            // txb_I1
            // 
            this.txb_I1.Location = new System.Drawing.Point(305, 145);
            this.txb_I1.Name = "txb_I1";
            this.txb_I1.Size = new System.Drawing.Size(60, 20);
            this.txb_I1.TabIndex = 94;
            // 
            // txb_P_peak
            // 
            this.txb_P_peak.Location = new System.Drawing.Point(121, 215);
            this.txb_P_peak.Name = "txb_P_peak";
            this.txb_P_peak.Size = new System.Drawing.Size(60, 20);
            this.txb_P_peak.TabIndex = 87;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(125, 196);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 16);
            this.label17.TabIndex = 88;
            this.label17.Text = "P_p[MW]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(210, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 90;
            this.label5.Text = "Q_p [MVar]";
            // 
            // txb_Q_peak
            // 
            this.txb_Q_peak.Location = new System.Drawing.Point(213, 215);
            this.txb_Q_peak.Name = "txb_Q_peak";
            this.txb_Q_peak.Size = new System.Drawing.Size(60, 20);
            this.txb_Q_peak.TabIndex = 89;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Date,
            this.Device_id,
            this.cong_suat_P,
            this.cong_suat_Q,
            this.cos_phi,
            this.tan_so,
            this.P_dinh,
            this.Q_dinh});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(747, 326);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(623, 261);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 90;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 110;
            // 
            // Device_id
            // 
            this.Device_id.Text = "ID Number";
            this.Device_id.Width = 68;
            // 
            // cong_suat_P
            // 
            this.cong_suat_P.Text = "P";
            this.cong_suat_P.Width = 63;
            // 
            // cong_suat_Q
            // 
            this.cong_suat_Q.Text = "Q";
            this.cong_suat_Q.Width = 49;
            // 
            // cos_phi
            // 
            this.cos_phi.Text = "cosP";
            this.cos_phi.Width = 54;
            // 
            // tan_so
            // 
            this.tan_so.Text = "f";
            // 
            // P_dinh
            // 
            this.P_dinh.Text = "P peak";
            // 
            // Q_dinh
            // 
            this.Q_dinh.Text = "Q peak";
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BackColor = System.Drawing.Color.AliceBlue;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "getS";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.IsXValueIndexed = true;
            series4.Legend = "getS";
            series4.Name = "S";
            series4.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Blue;
            series5.Legend = "getS";
            series5.Name = "P";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Black;
            series6.Legend = "getS";
            series6.Name = "Q";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(890, 280);
            this.chart1.TabIndex = 74;
            this.chart1.Text = "chart1";
            // 
            // txt_1dong
            // 
            this.txt_1dong.Location = new System.Drawing.Point(381, 134);
            this.txt_1dong.Name = "txt_1dong";
            this.txt_1dong.Size = new System.Drawing.Size(511, 20);
            this.txt_1dong.TabIndex = 93;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(381, 160);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(511, 50);
            this.txtkq.TabIndex = 92;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "statuslabel";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIÁM SÁT THÔNG SỐ TỔ MÁY PHÁT ĐIỆN";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_rs485.ResumeLayout(false);
            this.panel_rs485.PerformLayout();
            this.panel_wifi.ResumeLayout(false);
            this.panel_wifi.PerformLayout();
            this.pn_chonmode.ResumeLayout(false);
            this.pn_chonmode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Port;
        private System.Windows.Forms.TextBox txb_BrokerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_wifi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.ComboBox cbBits;
        private System.Windows.Forms.ComboBox cbBit;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label txt_date;
        private System.Windows.Forms.Label txt_time;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Device_id;
        private System.Windows.Forms.ColumnHeader cong_suat_P;
        private System.Windows.Forms.ColumnHeader cong_suat_Q;
        private System.Windows.Forms.ColumnHeader cos_phi;
        private System.Windows.Forms.TextBox txb_cosP;
        private System.Windows.Forms.TextBox txb_Q;
        private System.Windows.Forms.TextBox txb_P;
        private System.Windows.Forms.TextBox txb_S;
        private System.Windows.Forms.TextBox txb_Id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_freq;
        private System.Windows.Forms.ColumnHeader tan_so;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txb_P_peak;
        private Bunifu.Framework.UI.BunifuCheckbox Status_mqtt;
        private System.Windows.Forms.ColumnHeader P_dinh;
        private System.Windows.Forms.ColumnHeader Q_dinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Q_peak;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.TextBox txt_1dong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_U2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txb_U1;
        private System.Windows.Forms.TextBox txb_cosP2;
        private System.Windows.Forms.TextBox txb_cosP1;
        private System.Windows.Forms.TextBox txb_I2;
        private System.Windows.Forms.TextBox txb_I1;
        private System.Windows.Forms.Panel panel_rs485;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lb_tieude;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_U1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lb_U1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lb_P_peak;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_P_peak;
        private System.Windows.Forms.Label lb_cosP;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_cosP;
        private System.Windows.Forms.Label lb_cosP2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_cosP2;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label lb_I2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_I2;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label lb_U2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_U2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lb_P;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_P;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lb_freq;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_freq;
        private System.Windows.Forms.Label lb_cosP1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_cosP1;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lb_I1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_I1;
        private System.Windows.Forms.Label label48;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_rsmode;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_wifimode;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lb_Q_peak;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_Q_peak;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lb_Q;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cir_Q;
        public System.Windows.Forms.Label label43;
        public System.Windows.Forms.Label label45;
        public System.Windows.Forms.Label label47;
        public System.Windows.Forms.Label label49;
        public System.Windows.Forms.Label label38;
        public System.Windows.Forms.Label label39;
        public System.Windows.Forms.Label label41;
        public System.Windows.Forms.Label label42;
        public System.Windows.Forms.Label label35;
        public System.Windows.Forms.Label label37;
        public System.Windows.Forms.Label label33;
        public System.Windows.Forms.Label label30;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Panel pn_chonmode;
        private MetroFramework.Controls.MetroButton btn_Export;
        private MetroFramework.Controls.MetroButton btn_closeport;
        private MetroFramework.Controls.MetroButton btn_openport;
        private MetroFramework.Controls.MetroButton btn_DisconnectMQTT;
        private MetroFramework.Controls.MetroButton btn_ConnectMQTT;
        private MetroFramework.Controls.MetroComboBox cb_laymau;
    }
}