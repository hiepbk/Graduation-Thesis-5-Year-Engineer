import React from "react";

import { Table, Tag, Space } from "antd";
import "antd/dist/antd.css";

const { Column, ColumnGroup } = Table;

const DACN = ({data}) => {

  return (
    <div>
      <Table dataSource={data.lightOnQuery || { accel: { x: 1, y: 1, z: 1 } }}>
        <Column title="ID" dataIndex="_id" key="_id" />
        <ColumnGroup title="Accelometer">
          <Column
            title="x"
            dataIndex="accel"
            key="x"
            render={(text) => <>{text.x}</>}
          />
          <Column
            title="y"
            dataIndex="accel"
            key="y"
            render={(text) => <>{text.y}</>}
          />
          <Column
            title="z"
            dataIndex="accel"
            key="z"
            render={(text) => <>{text.z}</>}
          />
        </ColumnGroup>
        <Column title="Color" dataIndex="color" key="color" />
        <Column title="MagneMagnetometer" dataIndex="magne" key="magne" />
        <Column title="Microphone" dataIndex="micro" key="micro" />
        <Column title="Time" dataIndex="time" key="time" />
        <Column
          title="Action"
          key="action"
          render={(text, record) => (
            <Space size="middle">
              <a>Delete</a>
            </Space>
          )}
        />
      </Table>
    </div>
  );
};

export default DACN;
