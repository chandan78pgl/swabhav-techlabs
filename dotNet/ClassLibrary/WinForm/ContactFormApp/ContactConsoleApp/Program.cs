using ContactCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactManager contactManager = new ContactManager();
            startContactManager(contactManager);
        }

        private static void startContactManager(ContactManager contactManager)
        {
            bool isExit = false;

            Console.WriteLine("Contact Manager Started...!!!");

            while (!isExit)
            {
                Console.WriteLine("Select any option Below:"
                    + "\n 1. Add new Contact."
                    + "\n 2. Display Contact."
                    + "\n 3. Quit."
                    + "\nEnter Choice: ");

                int choice = 0;
                const int ADD = 1, DISPLAY = 2, QUIT = 3;

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case ADD:
                        Console.WriteLine("Enter Name: ");
                        string contactName = Console.ReadLine();

                        Console.WriteLine("Enter Number: ");
                        string contactNumber = Console.ReadLine();

                        contactManager.AddContact(contactName, contactNumber);

                        break;
                    case DISPLAY:
                        Console.WriteLine("Displaying Contacts....\n------------------------------------------------");
                        foreach (Contact contact in contactManager.Contacts)
                        {
                            Console.WriteLine(contact);
                        }
                        Console.WriteLine("---------------------------------------------------");
                        break;
                    case QUIT:
                        Console.WriteLine("This Program is now Closed.");
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Select any option.");
                        break;
                }
            }
        }
    }
}
