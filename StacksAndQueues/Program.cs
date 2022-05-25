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
                Console.WriteLine("2. Peek and Pop till the stack is empty");
                Console.WriteLine("3. Create Queue of 56->30->70");
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
                    case 2:
                        Stack s2 = new Stack();
                        s2.Push(70);
                        s2.Push(30);
                        s2.Push(56);
                        s2.display();

                        //Peek and Pop 1st
                        s2.Peek();
                        s2.Pop();
                        Console.Write("After pop operation ");
                        s2.display();

                        //Peek and Pop 2nd
                        s2.Peek();
                        s2.Pop();
                        Console.Write("After pop operation ");
                        s2.display();

                        //Peek and Pop 3rd
                        s2.Peek();
                        s2.Pop();
                        Console.Write("After pop operation ");
                        s2.display();
                        break;
                    case 3:
                        Queue q1 = new Queue();
                        q1.Enqueue(56);
                        q1.Enqueue(30);
                        q1.Enqueue(70);
                        q1.Display();
                        break;
                    default:
                        Console.WriteLine("Please choose correct option from the list");
                        break;
                }
            } while (choice != 0);
        }
    }
}