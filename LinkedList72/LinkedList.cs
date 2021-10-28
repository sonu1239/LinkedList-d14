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
        internal void Insert(int data)             //Inserting  new integer data into linklist
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
            Console.WriteLine("\n {0} data is insterted into linked list", newNode.data);
        }
        internal void insertAfter(Node prevNode, int data)     //inserting new integer data to linklist
        {
            Console.WriteLine("\n After Inserting element,");
            prevNode = this.head;
            if (prevNode == null)
            {
                Console.WriteLine("\n previous given node is null");
                return;
            }
            Node newNode1 = new Node(data);
            newNode1.next = prevNode.next;
            prevNode.next = newNode1;

        }
        internal void Display()                    //display the linklist data
        {
            Console.WriteLine("Display linklist element is: ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "");
                    temp = temp.next;
                }

            }


        }

    }
}
