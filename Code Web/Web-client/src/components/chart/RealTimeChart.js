import React, { useEffect, useState } from "react";
import Plotly from "plotly.js";
import { SUBSCRIPTION } from "../../schema/subscription";
import { useMutation, useSubscription, useQuery } from "@apollo/react-hooks";
import styled from "styled-components";
import { Table } from "antd";

const columns1 = [
  {
    title: "csS [MVA]",
    dataIndex: "csS",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "csP [MW]",
    dataIndex: "csP",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "csQ [MVar]",
    dataIndex: "csQ",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "cosP",
    dataIndex: "cosP",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "freq [Hz]",
    dataIndex: "freq",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "P_peak [MW]",
    dataIndex: "P_peak",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "Q_peak [MVar]",
    dataIndex: "Q_peak",
    render: (text) => <a>{text}</a>,
  },
];

const columns2 = [
  {
    title: "Id",
    dataIndex: "Id",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "U1 [KV]",
    dataIndex: "U1",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "U2 [KV]",
    dataIndex: "U2",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "I1 [KA]",
    dataIndex: "I1",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "I2 [KA]",
    dataIndex: "I2",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "cosP1",
    dataIndex: "cosP1",
    render: (text) => <a>{text}</a>,
  },
  {
    title: "cosP2",
    dataIndex: "cosP2",
    render: (text) => <a>{text}</a>,
  },
];

const RealTimeChart = () => {
  const [cnt, setCnt] = useState(0);
  const [value, setValue] = useState(0);
  const [csS, setCsS] = useState(0);
  const [csP, setCsP] = useState(0);
  const [csQ, setCsQ] = useState(0);
  const [cosP, setCosP] = useState(0);
  const [dataInput1, setDataInput1] = useState([]);
  const [dataInput2, setDataInput2] = useState([]);
  const { data2, loading2 } = useSubscription(SUBSCRIPTION, {
    onSubscriptionData: (data1) => {
      let jsonString = data1.subscriptionData.data.postAdded;
      console.log(jsonString);

      // let content = jsonString.replace(/'/g, '"');
      // let a = JSON.parse(content);
      // console.log(a.value);
      // setValue(a.value)
      setCnt((preCnt) => preCnt + 1);
      console.log("cnt", cnt);
      if (cnt > 100) {
        Plotly.relayout("csS", {
          xaxis: { range: [cnt - 100, cnt] },
        });
        Plotly.relayout("csP", {
          xaxis: { range: [cnt - 100, cnt] },
        });
        Plotly.relayout("csQ", {
          xaxis: { range: [cnt - 100, cnt] },
        });
        Plotly.relayout("cosP", {
          xaxis: { range: [cnt - 100, cnt] },
        });
      }
      if (jsonString.Id) {
        var arrayData2 = [];
        arrayData2.push(jsonString);
        setDataInput2([...arrayData2]);
      }
      if (jsonString.csS) {
        var arrayData1 = [];
        arrayData1.push(jsonString);
        setDataInput1([...arrayData1]);
        setCsS(jsonString.csS);
        Plotly.extendTraces("csS", { y: [[Number(jsonString.csS)]] }, [0]);
        setCsP(jsonString.csP);
        Plotly.extendTraces("csP", { y: [[Number(jsonString.csP)]] }, [0]);
        setCsQ(jsonString.csQ);
        Plotly.extendTraces("csQ", { y: [[Number(jsonString.csQ)]] }, [0]);
        setCosP(jsonString.cosP);
        Plotly.extendTraces("cosP", { y: [[Number(jsonString.cosP)]] }, [0]);
      }
    },
  });
  useEffect(() => {
    Plotly.plot("csS", [
      {
        y: [value],
        type: "line",
        color:'red'
      },
    ]);
    Plotly.plot("csP", [
      {
        y: [value],
        type: "line",
        marker: {
          color: 'green'
        }
      },
    ]);
    Plotly.plot("csQ", [
      {
        y: [100],
        type: "line",
        marker: {
          color: 'orange'
        }
      },
    ]);
    Plotly.plot("cosP", [
      {
        y: [value],
        type: "line",
        marker: {
          color: 'rgb(219, 64, 82)'
        }
      },
    ]);
  }, []);
  return (
    <Cover>
      <Table style={{marginBottom:'20px'}} pagination={false} bordered={true} columns={columns2} dataSource={dataInput2} />
      <Table pagination={false} bordered={true} columns={columns1} dataSource={dataInput1} />
      <DisplayRow>
        <DisplayArea>
          <div id="csP"></div>
          <DisplayNumber>csP: {csP}</DisplayNumber>
        </DisplayArea>
        <DisplayArea>
          <div id="csS"></div>
          <DisplayNumber>csS: {csS}</DisplayNumber>
        </DisplayArea>
      </DisplayRow>
      <div style={{marginLeft: 260, marginBottom: 60}} >
        <Title>GIÁM SÁT THÔNG SỐ TỔ MÁY PHÁT ĐIỆN</Title>
      </div>
      <DisplayRow>
        <DisplayArea>
          <div id="csQ"></div>
          <DisplayNumber>csQ: {csQ}</DisplayNumber>
        </DisplayArea>
        <DisplayArea>
          <div id="cosP"></div>
          <DisplayNumber>cosP: {cosP}</DisplayNumber>
        </DisplayArea>
      </DisplayRow>
    </Cover>
  );
};

const DisplayNumber = styled.div`
  position: absolute;
  top: 50px;
  /* background-color: red; */
  border: solid 1px gray;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 10px;
  font-weight: bold;
  font-size: 18px;
  width: 150px;
  height: 30px;
  padding: 5px;
`;

const DisplayRow = styled.div`
  display: flex;
  flex-direction: row;
`;

const DisplayArea = styled.div`
  position: relative;
  display: flex;
  flex-direction: column;
  align-items: center;
  width: 50%;
`;

const Title = styled.div`
font-size:40px;
opacity:30%;
font-weight:bold;
position:absolute;
z-index:1;
`

const Cover = styled.div`
position: relative;
`

export default RealTimeChart;
