using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace SparkPlug.WebForm.API.MongoDb
{
    public class MongoConnect
    {
        private MongoClient client;
        public MongoConnect()
        {
            client = new MongoClient();
        }

        // Creates a database

        public IMongoDatabase GetDB(string databaseObject)
        {
            var db = client.GetDatabase(databaseObject);
            return db;
        }
    }
}
