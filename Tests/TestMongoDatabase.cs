using System;
using MongoDB.Driver;

namespace Tests
{
    public static class TestMongoDatabase
    {
        public static IMongoDatabase Create()
        {
            var mongoConnectionString = "mongodb://username:userpassword@cluster0-shard-00-00.oki1a.mongodb.net:27017,cluster0-shard-00-01.oki1a.mongodb.net:27017,cluster0-shard-00-02.oki1a.mongodb.net:27017/myFirstDatabase?ssl=true&replicaSet=atlas-hnz6j8-shard-0&authSource=admin&retryWrites=true&w=majority";
            var mongoClient = new MongoClient(mongoConnectionString);
            return mongoClient.GetDatabase("game-tests");
        }
    }
}