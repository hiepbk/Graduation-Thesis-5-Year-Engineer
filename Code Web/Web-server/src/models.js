const mongoose = require("mongoose");
const { Schema } = mongoose;

const lightOnSchema = new Schema({
  micro: String,
  color: Object,
  accel: Object,
  type: Number,
  time: String
});

const LightOn = mongoose.model("lightOn", lightOnSchema);

const openFridgeSchema = new Schema({
  micro: String,
  color: String,
  magne: String,
  accel: Object,
  type: Number,
  time: String
});

const OpenFridge = mongoose.model("openFridge", openFridgeSchema);

module.exports = { OpenFridge, LightOn };
