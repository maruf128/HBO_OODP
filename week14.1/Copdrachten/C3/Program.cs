using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create a stack of integers
        Stack<int> myStack = new Stack<int>();

        //int to switch on
        int choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add integer to stack");
            Console.WriteLine("2. Remove integer from stack");
            Console.WriteLine("3. View top integer on stack");
            Console.WriteLine("4. View all integers on stack");
            Console.WriteLine("5. Exit program");
            Console.Write("Enter the number of your choice: ");
            choice = int.Parse(Console.ReadLine());

            //Create a switch statement to handle the functions from the menu
            switch (choice)
            {
                case 1:
                    // eerst vraag een int om toe te voegen
                    Console.WriteLine("give an integer");
                    int getal = int.Parse(Console.ReadLine());
                    myStack.Push(getal);
                    break;
                case 2:
                    // verwijder een int
                    myStack.Pop();
                    break;
                case 3:
                    // lees de bovenste int van de stack
                    int hoogste = myStack.Peek();
                    Console.WriteLine($"Top integer on stack: {hoogste}");
                    break;
                case 4:
                    // kijk door iedere int en lees het
                    Console.WriteLine("All integers on stack:");
                    foreach (int item in myStack)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 5:
                    // quit de program
                    Environment.Exit(0);
                    break;
                default:
                    // code block
                    break;
            }
        } while (choice != 5);
    }
}

