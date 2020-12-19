import React from "react";
import { Select } from "antd";

const { Option } = Select;

const Dashboard = () => {
  return (
    <div>
      <Select defaultValue="lucy" style={{ width: 120 }} bordered={false}>
        <Option value="jack">Jack</Option>
        <Option value="lucy">Lucy</Option>
        <Option value="Yiminghe">yiminghe</Option>
      </Select>
      <Select
        defaultValue="lucy"
        style={{ width: 120 }}
        disabled
        bordered={false}
      >
        <Option value="lucy">Lucy</Option>
      </Select>
    </div>
  );
};

export default Dashboard;
