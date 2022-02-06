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

            addressBookTable.DisplayContacts();
        }
    }
}
