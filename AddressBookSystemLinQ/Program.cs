using System;

namespace AddressBookSystemLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  Address Book Using LINQ! ");

            // UC 1 Create a new table
            AddressBookTable addressBookTable = new AddressBookTable();

            ////UC3
            //addressBookTable.DisplayContacts();

            //// UC4
            //addressBookTable.EditExistingContact("Mohsin", "Zahoor", "PhoneNumber", "7006703679");

            // UC5
            //addressBookTable.DeleteContact("Raj", "Verma");

            // UC6
            //addressBookTable.RetrieveByCityOrState("Srinagar", "Jammu and Kashmir");

            // UC7
            //addressBookTable.CountByCityOrState("Srinagar", "Jammu and Kashmir");

            // UC8
            addressBookTable.SortedContactsByNameForAgivenCity("Srinagar");
        }
    }
}
