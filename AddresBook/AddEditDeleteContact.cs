using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddresBook
{
    public class AddEditDeleteContact
    {
        public void AddContactDetails()
        {
            // writing the logic to add contact in address

            Console.WriteLine("enter the firstname");
            string firstname = Console.ReadLine();

            Console.WriteLine("enter the lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("enter the email");
            string email = Console.ReadLine();
            Console.WriteLine("enter the phone");
            string phone = Console.ReadLine();
            Console.WriteLine("enter the address");
            string address = Console.ReadLine();
            Console.WriteLine("enter the city ");
            string city = Console.ReadLine();
            Console.WriteLine("enter the state");
            string state = Console.ReadLine();
            Console.WriteLine("enter the zip");
            string zip = Console.ReadLine();
            ContactList.Add(new Contactdetails(firstname, lastname, email, phone, address, city, state, zip));

        }

        public void EditContactDetails()

        { // logic for the editing the user data 
            
        }

        public void DeleteContactDetails()
        {
            // logic for deleting the a contact detail of user 
            
        } 

        static ArrayList ContactList = new ArrayList();

    }

}

     

 

