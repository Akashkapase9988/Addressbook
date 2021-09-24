using System;
using System.Collections.Generic;
namespace Addressbooksystem
{
    class AddressPrompt
    {
        AddressBook book;

        public AddressPrompt()
        {
            book = new AddressBook();
        }

        static void Main(string[] args)
        {
            string selection = "";
            AddressPrompt prompt = new AddressPrompt();

            prompt.displayMenu();
            while (!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Selection: ");
                selection = Console.ReadLine();
                prompt.performAction(selection);
            }
        }

        void displayMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("A - Add an Address");
            Console.WriteLine("D - Delete an Address");
            Console.WriteLine("E - Edit an Address");
            Console.WriteLine("L - List All Addresses");
            Console.WriteLine("Q - Quit");
        }

        void performAction(string selection)
        {
            string name = "";
            string address = "";
            string phonenumber = "";
            string city = "";
            string state = "";
            string zip = "";
            string email = "";

            switch (selection.ToUpper())
            {
                case "A":
                    Console.WriteLine("Enter Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter phonenumber: ");
                    phonenumber = Console.ReadLine();
                    Console.WriteLine("Enter city: ");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter state: ");
                    state = Console.ReadLine();
                    Console.WriteLine("Enter zip: ");
                    zip = Console.ReadLine();
                    Console.WriteLine("Enter email: ");
                    email = Console.ReadLine();
                   
                    if (book.add(name, address, phonenumber,city,state,zip,email))
                    {
                        Console.WriteLine("Address successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An address is already on file for {0}.", name);
                    }
                    break;
                case "D":
                    Console.WriteLine("Enter Name to Delete: ");
                    name = Console.ReadLine();
                    if (book.remove(name))
                    {
                        Console.WriteLine("Address successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Address for {0} could not be found.", name);
                    }
                    break;
                case "L":
                    if (book.isEmpty())
                    {
                        Console.WriteLine("There are no entries.");
                    }
                    else
                    {
                        Console.WriteLine("Addresses:");
                        book.list((a) => Console.WriteLine("{0} - {1} -{2} - {3} - {4} - {5} - {6}", a.name, a.address,a.phonenumber,a.city,a.state,a.zip,a.email));
                    }
                    break;
                case "E":
                    Console.WriteLine("Enter Name to Edit: ");
                    name = Console.ReadLine();
                    Address addr = book.find(name);
                    if (addr == null)
                    {
                        Console.WriteLine("Address for {0} count not be found.", name);
                    }
                    else
                    {
                        Console.WriteLine("Enter new Address: ");
                        addr.address = Console.ReadLine();
                        Console.WriteLine("Address updated for {0}", name);
                    }
                    break;
            }
        }
    }
}