using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Stack
    {
        internal Node top;

        //For initializing top to null
        public Stack()
        {
            top = null;
        }

        //For pushing/(adding node at first position) the node onto the stack
        internal void Push(int data)
        {
            Node newNode = new Node(data);

            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine(newNode.data + " is pushed/inserted onto the stack");
        }

        //For displaying theh stack
        internal void display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("The Stack is :\n");
            Console.Write(" top ->");
            Node tempNode = top;

            while (tempNode != null)
            {
                Console.WriteLine("\t| " + tempNode.data + " |");
                tempNode = tempNode.next;
            }
            Console.WriteLine();
        }
    }
}
