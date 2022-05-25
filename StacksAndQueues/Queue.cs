using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Queue
    {
        internal Node head = null;

        //For inserting the node at the end of the queue
        internal void Enqueue(int data)
        {
            Node newNode = new Node(data);

            //If queue is empty insert nowNode at first position
            if (head == null)
            {
                head = newNode;
            }
            //else insert at the end of our queue/linkedlist
            else
            {
                Node tempHead = head;
                while (tempHead.next != null)
                {
                    tempHead = tempHead.next;
                }
                tempHead.next = newNode;
            }
            Console.WriteLine(newNode.data + " is enqueued/inserted into the queue");
        }

        //For displaying nodes present in the queue
        internal void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                Console.Write("Queue is : front/head");
                Node tempHead = head;
                while (tempHead != null)
                {
                    Console.Write(" -> " + tempHead.data);
                    tempHead = tempHead.next;
                }
                Console.WriteLine(" <- rear/tail\n");
            }
        }
    }
}
