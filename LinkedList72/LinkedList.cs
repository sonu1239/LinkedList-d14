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
        //delete an element at the given position
        public void deletePosition(int position)    //delete at given position
        {
            if (position < 1)
            {
                Console.WriteLine("\n position should be >=1");
            }
            else if (position == 1 && head != null)
            {
                Node nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;        //prevNode of next is new node
            }
            else
            {
                Node temp = head; // head assigned to temp
                for (int i = 1; i < position - 1; i++) 
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null && temp.next != null)
                {
                    Node nodeToDelete = temp.next;
                    temp.next = temp.next.next;
                    nodeToDelete = null;
                }
                else
                {
                    Console.WriteLine("node is already null");
                }
            }
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
