using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace practicing_software_development
{
    internal struct Contact
    {
        //Variables for contact
        public string name;
        public string number;
        public string formattedNumber;
        private string contactInfo;

        public Contact(string name, string number)
        {
            this.name = name;
            this.number = number;
            this.formattedNumber = FormatPhoneNumber(this.number);
            this.contactInfo = (this.name + ": " + this.formattedNumber);
        }

        public void PrintContactInfo()
        {
            Console.WriteLine(this.contactInfo);
        }

        //Formats the number into proper U.S. phone number formatting.
        public static string FormatPhoneNumber(string number)
        {
            if (number.Length < 10 || number.Length > 10) 
            {
                Console.WriteLine("Improper phone number length for formatting..");
            }
            Regex regex = new Regex(@"[^\d]");
            number = regex.Replace(number, "");
            number = Regex.Replace(number, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3");
            return number;
        }

        public Contact EditContact(string newName = null, string newNumber = null)
        {
            string updatedName = this.name;  
            string updatedNumber = this.number;  

            if (newName != null)
            {
               updatedName = newName;
            }

            if (newNumber != null)
            {
              updatedNumber = newNumber;
            }

             return new Contact(updatedName, updatedNumber);
        }


    }
}
