// "C:\Program Files\mosquitto\mosquitto" -v
// C:\Program Files\mosquitto>mosquitto_sub.exe -t channel1
// C:\Program Files\mosquitto>mosquitto_pub.exe -t channel1 -m "TAPIT"
const express = require("express");
const http = require("http");
const { ApolloServer, gql } = require("apollo-server-express");
const { typeDefs } = require("./src/typeDefs");
const { resolvers } = require("./src/resolvers");
var bodyParser = require("body-parser");
require("./src/config");

const server = new ApolloServer({ typeDefs, resolvers });
const app = express();

server.applyMiddleware({ app });

// server.listen({ port: 4000 }, () =>  
//   console.log("🚀 Server ready at http://localhost:4000/graphql  ")
// ); 
const PORT = 4000;

const httpServer = http.createServer(app);
server.installSubscriptionHandlers(httpServer);

// ⚠️ Pay attention to the fact that we are calling `listen` on the http server variable, and not on `app`.
httpServer.listen(PORT, () => {
  console.log(
    `🚀 Server ready at http://localhost:${PORT}${server.graphqlPath}`
  );
  console.log(
    `🚀 Subscriptions ready at ws://localhost:${PORT}${server.subscriptionsPath}`
  ); 
}); 

// server.listen({ port: 5000 }).then(({ url }) => {
// 	console.log(`🚀 Server ready at ${url}`)
// });
