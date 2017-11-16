using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using DDDLayer.Support;
using DDDLayer.Domain;

namespace DDDLayer.Infrastructure.Services
{
    public class Mongo : IDatabase
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        private string databaseName = ConfigurationManager.AppSettings["Mongo_database"];
        public string collectionName { get; set; }

        public Mongo(string collectionName)
        {
            this.collectionName = collectionName;
        }

        private IMongoCollection<T> getCollection<T>()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase(databaseName);
            _database.GetCollection<T>(collectionName);
            return _database.GetCollection<T>(collectionName);
        }

        public T Get<T>(int id)
        {
            IMongoCollection<T> collection = getCollection<T>();
            if(collection.IsDefined())
            {
                var filter = new BsonDocument(new BsonElement("id",id));
                var obj = collection.Find<T>(filter);
                if(obj.IsDefined() && obj.Any())
                {
                    return obj.First();
                }
            }
            return default(T);
        }

        public T GetByFilter<T>(Dictionary<string,object> filters)
        {
            IMongoCollection<T> collection = getCollection<T>();
            if (collection.IsDefined())
            {
                var filter = new BsonDocument(filters);
                var obj = collection.Find<T>(filter);
                if (obj.IsDefined() && obj.Any())
                {
                    return obj.First();
                }
            }
            return default(T);
        }

        public List<T> GetList<T>(List<int> ids)
        {
            IMongoCollection<T> collection = getCollection<T>();
            if (collection.IsDefined())
            {
                var filter = Builders<T>.Filter.In("Id", ids);
                var obj = collection.Find<T>(filter);
                if (obj.IsDefined() && obj.Any())
                {
                    return obj.ToList();
                }
            }
            return new List<T>();
        }
    }
}
