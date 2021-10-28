using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList72
{
    class LinkedList
    {
        internal Node head;                         //defined head position
        internal void AddLast(int data)             //Appening in last
        {
            Node newNode = new Node(data);         //defining and creating object of node class ,pushing data to node class

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;                     //creating temp variable
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        internal void Display()                    //display the linklist data
        {
            Console.WriteLine("\ndisplay linklist element is: ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }

        }

    }
}
