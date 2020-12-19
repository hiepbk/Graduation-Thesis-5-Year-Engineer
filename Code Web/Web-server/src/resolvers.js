const { LightOn, OpenFridge } = require("./models");
const mongoose = require("mongoose");
const XLSX = require("xlsx");
var json2xls = require("json2xls");
const fs = require("fs");
const { MQTTPubSub } = require("graphql-mqtt-subscriptions");
const moment = require("moment");
const mqtt = require("mqtt");
const { connect } = require("mqtt");
// var client = mqtt.connect("mqtt://192.168.43.176", { clientId: "hung1" });
const client = connect("mqtt://tailor.cloudmqtt.com", {
  reconnectPeriod: 1000,
  username: "iqkxxvjj",
  password: "ej37-wtIp03q",
  port: "16370",
});

let createLightOn = async (data) => {
  try {
    var d = new Date();
    var n = d.toISOString();
    let response = await LightOn.create({ ...data, time: n });
    console.log(response);
    return response;
  } catch (error) {
    return error.message;
  }
};

const pubsub = new MQTTPubSub({
  client,
});

// var topic_s = "event";
var topic_s = "ESP_PUB";
client.subscribe(topic_s, { qos: 1 });
client.on("message", function (topic, message, packet) {
  //console.log("" + message);
  // let contentString = "" + message;
  // let contentJson = contentString.replace(/'/g, '"');
  // let contentObject = JSON.parse(contentJson);
  // if (contentObject.micro != 0) {
  // createLightOn({ ...contentObject });
  // }
  // console.log({ ...contentObject });

  let contentString = "abc" + message;
  // console.log(contentString)
  // pubsub.publish(POST_ADDED, contentString);
});

// const POST_ADDED = "event";
const POST_ADDED = "ESP_PUB";

const resolvers = {
  Subscription: {
    postAdded: {
      resolve: (payload) => {
        // return payload;

        return payload;
      },
      subscribe: () => pubsub.asyncIterator([POST_ADDED]),
    },
  },
  Query: {
    lightOnQuery: async () => await LightOn.find(),
  },
  Mutation: {
    addLightOn: async (parent, args) => {
      try {
        var d = new Date();
        var n = d.toISOString();
        let response = await LightOn.create({ ...args, time: n });
        return response;
      } catch (error) {
        return error.message;
      }
    },
    addOpenFridge: async (parent, args) => {
      try {
        let response = await OpenFridge.create(args);
        return response;
      } catch (error) {
        return error.message;
      }
    },
    addPost(root, args, context) {
      // pubsub.publish(POST_ADDED, { postAdded: args });
      console.log(args.message);
      pubsub.publish(POST_ADDED, args.message);
      // return postController.addPost(args);
      return true;
    },

    convertToExel: (parent, args) => {
      let timeNow = moment().format("YYYY-MM-DD");
      LightOn.find({}).then((a) => {
        var data_v = a.map((p) => p.toJSON());
        var data = [];
        for (var x of data_v) {
          delete x.__v;
          data.push(x);
        }
        var fileData = [];
        var fileLabel = [];
        var q = 0;
        for (var x of data) {
          q++;
          fileData.push({
            stt: q,
            micro: x.micro,
            red: x.color.red,
            blue: x.color.blue,
            green: x.color.green,
            x: x.accel.x,
            y: x.accel.y,
            z: x.accel.z,
          });
          fileLabel.push({
            type: x.type,
          });
        }
        var xls = json2xls(fileData);
        var xlsLabel = json2xls(fileLabel);
        fs.writeFileSync(`src/data.${timeNow}.xlsx`, xls, "binary");
        fs.writeFileSync(`src/label.${timeNow}.xlsx`, xlsLabel, "binary");
      });
      return LightOn.find({});
    },
  },
};

module.exports = { resolvers };
