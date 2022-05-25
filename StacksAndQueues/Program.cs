using System;
namespace StacksAndQueues
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to Stacks and Queues program");
            int choice;
            do
            {
                Console.WriteLine("\n1. Create Stack of 56->30->70");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Stack s1 = new Stack();
                        s1.Push(70);
                        s1.Push(30);
                        s1.Push(56);
                        s1.display();
                        break;
                    default:
                        Console.WriteLine("Please choose correct option from the list");
                        break;
                }
            } while (choice != 0);
        }
    }
}