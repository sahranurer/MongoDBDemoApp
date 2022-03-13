using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MongoCRUD db = new MongoCRUD("AddressBook");
            //Insert
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

            //Read
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

            //Update-Delete-GetById
            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("5483e106-4406-4654-b1f4-dc0c8967f99b"));
            //oneRec.DateOfBirth = new DateTime(1999, 03, 16, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord<PersonModel>("Users", oneRec.Id, oneRec);
            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);


            //Yalnızca ihtiyacım olan kısmı bir model oluşturarak çekebilirim.
            //var recs = db.LoadRecords<NameModel>("Users");
            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.FirstName} {rec.LastName}");
            //    Console.WriteLine();
            //}


            Console.ReadLine();
        }
    }
}
