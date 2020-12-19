import { gql } from "apollo-boost";

export const LightOnQuery = gql`
  {
    lightOnQuery {
      _id
      micro
      accel {
        x
        y
        z
      }
      type
      color {
        red
        blue
        green
      }
      time
    }
  }
`;
