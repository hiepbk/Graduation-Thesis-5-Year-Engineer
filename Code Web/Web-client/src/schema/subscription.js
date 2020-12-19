import { gql } from "apollo-boost";

export const SUBSCRIPTION = gql`
  subscription message {
    postAdded {
      Id
      U1
      U2
      I1
      I2
      cosP1
      cosP2
      csS
      csP
      csQ
      cosP
      freq
      P_peak
      Q_peak
    }
  }
`;
