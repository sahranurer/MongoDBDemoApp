using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MongoCRUD db = new MongoCRUD("AddressBook");
            db.InsertRecord("Users", new PersonModel { FirstName="Mary",LastName="Jonas"});


            Console.ReadLine();
        }
    }
}
