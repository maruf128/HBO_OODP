using System;

class Program
{
    static void Main()
    {
        // Create an instance of the contacten class to store contact information
        contacten dict = new contacten();

        // Prompt the user for input and perform the requested operation
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Enter a command (add, view, remove, list, quit):");
            string command = Console.ReadLine();

            if (command == "add")
            {
                // Prompt for contact details
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the phone number:");
                string number = Console.ReadLine();

                dict.Add(name, number);
                Console.WriteLine("Contact added successfully.");
            }
            else if (command == "view")
            {
                // Prompt for the contact name
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();

                string result = dict.View(name);
                Console.WriteLine(result);
            }
            else if (command == "remove")
            {
                // Prompt for the contact name
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();

                dict.Remove(name);
                Console.WriteLine("Contact removed successfully.");
            }
            else if (command == "list")
            {
                dict.List();
            }
            else if (command == "quit")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}
