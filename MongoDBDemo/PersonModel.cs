using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBDemo
{
    public  class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; } //GUID (Global Unique Identifier), global olarak benzersiz olarak üretilen 128 bit uzunluğunda bir veridir.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }
        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }
    }
}
