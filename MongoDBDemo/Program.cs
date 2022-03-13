using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Sarah",
            //    LastName = "Smith",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "101 Oak Street",
            //        City = "Scranton",
            //        State = "PA",
            //        ZipCode = "18512"
            //    }
            //};



            //db.InsertRecord("Users", person);


            //var recs = db.LoadRecords<PersonModel>("Users");
            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.FirstName} : {rec.LastName} : ");
            //    if (rec.PrimaryAddress is not null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.City);
            //    }
            //    Console.WriteLine();
            //}

            var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("5483e106-4406-4654-b1f4-dc0c8967f99b"));


            Console.ReadLine();
        }
    }
}
