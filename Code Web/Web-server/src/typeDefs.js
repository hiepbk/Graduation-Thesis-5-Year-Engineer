const { gql } = require("apollo-server-express");

// {"Id":"1","U1":"38.233","U2":"38.237","I1":"0.438","I2":"0.438","cosP1":"0.990","cosP2":"0.988"}
// {"csS":"33.514","csP":"33.144","csQ":"0.370","cosP":"0.989","freq":"49.000","P_peak":"33.706","Q_peak":"0.931"}

const typeDefs = gql`

type PostAddedObject {
    Id: String
    U1: String
    U2: String
    I1: String
    I2: String
    cosP1: String
    cosP2: String
    csS: String
    csP: String
    csQ: String
    cosP: String
    freq: String
    P_peak: String
    Q_peak: String
  }

  type Subscription {
    # postAdded: String
    postAdded: PostAddedObject
  }

  

  type Accel {
    x: String
    y: String
    z: String
  }

  type Color {
    red: String
    green: String
    blue: String
  }

  input AccelInput {
    x: String
    y: String
    z: String
  }

  input ColorInput {
    red: String
    green: String
    blue: String
  }

  type LightOn {
    _id: ID!
    micro: String
    accel: Accel
    type: Int
    color: Color
    time: String
  }

  type OpenFridge {
    _id: ID!
    micro: String
    accel: Accel
    magne: String
    type: Int
    color: String
    time: String
  }

  type Query {
    lightOnQuery: [LightOn]
  }

  type Mutation {
    addLightOn(
      micro: String
      accel: AccelInput
      type: Int
      color: ColorInput
    ): LightOn
    addOpenFridge(
      micro: String
      accel: AccelInput
      magne: String
      type: Int
      color: String
    ): OpenFridge
    convertToExel: [LightOn]
    addPost(message: String!): Boolean
  }
`;

module.exports = { typeDefs };
