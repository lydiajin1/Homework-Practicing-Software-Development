using System.Security.Cryptography.X509Certificates;

/**
 * Division of roles: 
 * Yuri: made the struct, the input, and collaborated on add contact
 * Lydia: Worked on the add contact, delete contact, and view all contact parts
 * Colin: worked on search contact
 * Blessing: 
 * 
 */

namespace practicing_software_development
{
    internal class Program
    {

        public static List<Contact> phoneBook = new List<Contact>();

        static void Main(string[] args)
        {
            Input();
        }

        // add contact 
        static void AddContact()
        {
            // takes in contact name and phone number 
            Console.WriteLine("Enter contact name: ");
            string contactName = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            // creates the new contact and addds it to the phone book 
            Contact contact = new Contact(contactName, phoneNumber);
            phoneBook.Add(contact);

            Console.WriteLine("New Contact Added: " + contact.name + " " + contact.formattedNumber + "\n");

            Input();
        }

        // delete contact 
        static void DeleteContact()
        {
            //Take the name of contact to delete 
            Console.WriteLine("Enter contact name to delete: ");
            string nameToDelete = Console.ReadLine();

            // look for contact name in the array and its index 
            for (int i = 0; i < phoneBook.Count; i++)
            {
                if (phoneBook[i].name == nameToDelete)
                {
                    phoneBook.RemoveAt(i);
                }
            }

            Input();
        }

        // search for contact - someone work on this
        static void SearchContact()
        {
           
            //Ex. Search Jo and return contacts named John, Johny, Johnny, Joe




            //Take name input
            Console.WriteLine("Enter name that you would like to search for: ");
            string nameToSearchFor= Console.ReadLine();


            //Return list of contacts matching name input (maybe even search for contacts STARTING with the letters searched.)
            for (int i = 0; i < phoneBook.Count; i++) { 
            
                    if(phoneBook[i].name == nameToSearchFor)
                {
                    Console.WriteLine(phoneBook[i].name +   phoneBook[i].formattedNumber);
                }
            }



            Input();
        }

        // edit contact - another person work on this
        static void EditContact()
        {
            //Take name input
            //Search for name in list
            //Select specific one by phone number
            //Find index of said contact
            //Edit the list




            Input() ;
        }

        // view entire contact list 
        static void ViewAllContacts()
        {
            //Return full array of Name: Number
            foreach (Contact contact in phoneBook)
            {
                Console.WriteLine(contact.name + ": " + contact.formattedNumber);
            }
            
            Input();
        }

        static void Input()
        {

            //Allows for user inputs on what they want to do.
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("The options are: \n- Add a contact\n- Remove a contact\n- Edit a contact\n- Search for a contact\n- View all contacts");
            //Check all inputs, not case sensitive.
            switch (Console.ReadLine().ToLower())
            {
                case ("add a contact"):
                    AddContact();
                    break;
                case ("remove a contact"):
                    DeleteContact();
                    break;
                case ("edit a contact"):
                    EditContact();
                    break;
                case ("view all contacts"):
                    ViewAllContacts();
                    break;
                case ("search for a contact"):
                    SearchContact();
                    break;
            }
        }
    }
}
