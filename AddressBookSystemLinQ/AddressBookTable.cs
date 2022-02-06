using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                Console.WriteLine("FirstName:- " + dataRow.Field<string>("firstName")); 
                Console.WriteLine("LastName:- " + dataRow.Field<string>("lastName"));
                Console.WriteLine("Address:- " + dataRow.Field<string>("address"));
                Console.WriteLine("City:- " + dataRow.Field<string>("city"));
                Console.WriteLine("State:- " + dataRow.Field<string>("state"));
                Console.WriteLine("Zip:- " + dataRow.Field<string>("zip"));
                Console.WriteLine("PhoneNumber:- " + dataRow.Field<string>("phoneNumber"));
                Console.WriteLine("Email:- " + dataRow.Field<string>("eMail"));
            }
        }

        /*UC4:- Ability to edit existing contact person using their name
         */
        public void EditExistingContact(string firstName, string lastName, string column, string newValue)
        {                                                                   // FirstOrDefault comes from System.Linq Namespace
            DataRow contact = dataTable.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
            contact[column] = newValue;
            Console.WriteLine("Record successfully Edited");
            DisplayContacts();
        }

        // UC5:- Delete a person using person's name.
        public void DeleteContact(string firstName, string lastName)
        {
            try
            {
                DataRow contact = dataTable.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
                dataTable.Rows.Remove(contact);
                Console.WriteLine("Record Successfully Deleted");
                DisplayContacts();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //UC6:- Ability to Retrieve Person belonging to a City or State from the Address Book
        public void RetrieveByCityOrState(string city, string state)
        {
            var retrieveData = from records in dataTable.AsEnumerable()
                               where records.Field<string>("City") == city || records.Field<string>("State") == state
                               select records;
            //Printing data
            Console.WriteLine("\nRetrieve contact details by city or state name");
            foreach (DataRow dataRow in retrieveData.AsEnumerable())
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dataRow.Field<string>("firstName"));
                Console.WriteLine("LastName:- " + dataRow.Field<string>("lastName"));
                Console.WriteLine("Address:- " + dataRow.Field<string>("address"));
                Console.WriteLine("City:- " + dataRow.Field<string>("city"));
                Console.WriteLine("State:- " + dataRow.Field<string>("state"));
                Console.WriteLine("Zip:- " + dataRow.Field<string>("zip"));
                Console.WriteLine("PhoneNumber:- " + dataRow.Field<string>("phoneNumber"));
                Console.WriteLine("Email:- " + dataRow.Field<string>("eMail"));
            }
        }
    }
}
