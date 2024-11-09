﻿using System.Security.Cryptography.X509Certificates;

namespace practicing_software_development
{
    internal class Program
    {

        //IDK HOW TO MAKE THE CONTACT ARRAY
        public static Contact[] phoneBook = new Contact[0];

        static void Main(string[] args)
        {
            Input();
        }

        // add contact 
        static void AddContact()
        {
            Console.WriteLine("Enter contact name: ");
            string contactName = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Contact contact = new Contact(contactName, phoneNumber);
            //phoneBook[phoneBook.length - 1].PrintContactInfo();

            Console.WriteLine("New Contact Added: " + contact.name + " " + contact.formattedNumber + "\n");

            Input();
        }

        // delete contact 
        static void DeleteContact()
        {
            //Take name input
            //Search for name in array
            //Find index of said contact
            //Remove from array
        }

        // search for contact 
        static void SearchContact()
        {
            //Take name input
            //Return list of contacts matching name input (maybe even search for contacts STARTING with the letters searched.)
            //Ex. Search Jo and return contacts named John, Johny, Johnny, Joe
        }

        // edit contact 
        static void EditContact()
        {
            //Take name input
            //Search for name in array
            //Select specific one by phone number
            //Find index of said contact
            //Edit the array
        }

        // view entire contact list 
        static void ViewAllContacts()
        {
            //Return full array of Name: Number
        }

        static void Input()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("The options are: \n- Add a contact\n- Remove a contact\n- Edit a contact\n- Search for a contact\n- View all contacts");
            switch (Console.ReadLine())
            {
                case ("Add a contact"):
                    AddContact();
                    break;
                case ("Remove a contact"):
                    DeleteContact();
                    break;
                case ("Edit a contact"):
                    EditContact();
                    break;
                case ("View all contacts"):
                    ViewAllContacts();
                    break;
                case ("Search for a contact"):
                    SearchContact();
                    break;
            }
        }
    }
}
