using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC_API.Models
{
    public class DataBase
    {
        public void Connect()
        {
            var client = new MongoClient("mongodb://admin:Thespartans1_@test-shard-00-00-ghbkj.mongodb.net:27017,test-shard-00-01-ghbkj.mongodb.net:27017,test-shard-00-02-ghbkj.mongodb.net:27017/test?ssl=true&replicaSet=Test-shard-0&authSource=admin");
            var database = client.GetDatabase("test");
        }
    }
}