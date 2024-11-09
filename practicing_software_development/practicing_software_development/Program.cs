using System.Security.Cryptography.X509Certificates;

namespace practicing_software_development
{
    internal class Program
    {


        public Contact[] phoneBook = [];
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("The options are: \n- Add a contact\n- Remove a contact\n- Edit a contact\n- Search for a contact\n- View all contacts");
            switch (Console.ReadLine()) {
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

        // add contact 
        static void AddContact()
        {
            Console.WriteLine("Enter contact name: ");
            string contactName = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Contact contact = new Contact(contactName, phoneNumber);
            contact.PrintContactInfo();
            
        }

        // delete contact 
        static void DeleteContact()
        {

        }

        // search for contact 
        static void SearchContact()
        {

        }

        // edit contact 
        static void EditContact()
        {

        }

        // view entire contact list 
        static void ViewAllContacts()
        {

        }
    }
}
