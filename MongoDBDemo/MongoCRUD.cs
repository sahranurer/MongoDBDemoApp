using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBDemo
{
    public class MongoCRUD
    {
      private  IMongoDatabase db;
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database); 
            //gelen database db eşitledim.Eğer gelen database yok ise
            //yeni bir database oluşturulur.
        }

        public void InsertRecord<T>(string table,T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }


    }
}
