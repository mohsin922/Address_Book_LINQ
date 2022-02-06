using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookSystemLinQ
{
    public class AddressBookTable
    {
        //DataTable 
        DataTable dataTable = new DataTable();
        public  AddressBookTable()
        {

            dataTable.Columns.Add("FirstName", typeof(string));   //add columns
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));

            // UC3:- Insert new Contacts to Address Book
            dataTable.Rows.Add("Mohsin", "Zahoor", "Kunzer", "Srinagar", "Jammu and Kashmir", "193404", "9841235964", "mohsin@gmail.com");
            dataTable.Rows.Add("Zuhaib", "Haroon", "Mandarbagh", "Srinagar", "Jammu and Kashmir", "193401", "9543876149", "zuhaib@gmail.com");
            dataTable.Rows.Add("Raj", "Verma", "Saibaba", "Coimbatore", "Tamil Nadu", "345688", "8974125698", "Raj@gmail.com");
            
        }
        public void DisplayContacts()
        {
            foreach (DataRow dataRow in dataTable.AsEnumerable())
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dataRow.Field<string>("FirstName")); 
                Console.WriteLine("LastName:- " + dataRow.Field<string>("LastName"));
                Console.WriteLine("Address:- " + dataRow.Field<string>("Address"));
                Console.WriteLine("City:- " + dataRow.Field<string>("city"));
                Console.WriteLine("State:- " + dataRow.Field<string>("State"));
                Console.WriteLine("Zip:- " + dataRow.Field<string>("Zip"));
                Console.WriteLine("PhoneNumber:- " + dataRow.Field<string>("PhoneNumber"));
                Console.WriteLine("Email:- " + dataRow.Field<string>("Email"));
            }
        }
    }
}
