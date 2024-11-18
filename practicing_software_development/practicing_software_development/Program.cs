using System.Security.Cryptography.X509Certificates;

/**
 * Division of roles: 
 * Yuri: made the struct, the input, and collaborated on add contact. Added fixes to functions such as making case insensitive. Created base of edit contact for Blessing, as it is the most complex function of the bunch..
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
        //Note we should have probably used a dictionary but too late now haha

        static void Main(string[] args)
        {
            //Asks what user would like to do when the program loads.
                // Input is also at the end of every function in order to continue the program input
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
            string nameToSearchFor= Console.ReadLine().ToLower();


            //Return list of contacts matching name input (maybe even search for contacts STARTING with the letters searched.)
            for (int i = 0; i < phoneBook.Count; i++) { 
            
                    if(phoneBook[i].name.ToLower() == nameToSearchFor)
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

            Console.WriteLine("Enter name that you would like to edit: ");
            string nameToSearchFor = Console.ReadLine().ToLower();
            List<Contact> searchResults = new List<Contact>();

            //Return list of contacts matching name input (maybe even search for contacts STARTING with the letters searched.)
            for (int i = 0; i < phoneBook.Count; i++)
            {

                if (phoneBook[i].name.ToLower() == nameToSearchFor)
                {
                    searchResults.Add(phoneBook[i]);
                }
            }

            if (phoneBook.Count == 0)
            {
                Console.WriteLine("No contact found.");
            }
            else if (phoneBook.Count == 1) 
            {
                Console.WriteLine($"Editing {searchResults[0].name}" - {searchResults[0].formattedNumber}");
                //For Blessing -> edit the name and number of this contact in the phonebook list
                Console.Write("Enter new name: ");
                searchResults[0].name = Console.ReadLine();
                Console.Write("Enter new phone number: ");
                searchResults[0].formattedNumber = Console.ReadLine();
                Console.WriteLine("Contact updated successfully!");
            }
            else
            {
                Console.WriteLine("Multiple contacts found:");
                for (int i = 0; i < searchResults.Count; i++)
                {
                    Console.WriteLine($"{i +1}: {searchResults[i].name + searchResults[i]name} -{searchResults[i].formattedNumber}");
                }
                //For blessing -> List the searchResults list and make a way to select which one to edit, and then edit it.
                //(in case for example there are multiple contacts with the same name)
                // I think you can do this by either assigning each duplicate a number, or selecting again by phone number.
                 Console.Write("Select the contact number you wish to edit: ");
                 int selectedIndex;
                 while (!int.TryParse(Console.ReadLine(), out selectedIndex) || selectedIndex < 1 || selectedIndex > searchResults.Count)
                 {
                    Console.Write("Invalid selection. Please enter a valid contact number: ");
                 }

                 Contact selectedContact = searchResults[selectedIndex - 1];
                 Console.WriteLine($"Editing {selectedContact.name} - {selectedContact.formattedNumber}");
                 Console.Write("Enter new name: ");
                 selectedContact.name = Console.ReadLine();
                 Console.Write("Enter new phone number: ");
                 selectedContact.formattedNumber = Console.ReadLine();
                 Console.WriteLine("Contact updated successfully!");
                }
               }



            Input();
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
            Console.WriteLine("\nWhat would you like to do?");
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
