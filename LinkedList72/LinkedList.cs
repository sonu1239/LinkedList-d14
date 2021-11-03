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

        internal void SortedAscending()                    // here Ascending order display the all element in given linklist
        {
            Node NewNode1 = this.head;                      //assigned head to newNode 

            if (this.head == null || this.head.data >= NewNode1.data) //compare condition is head is null and head data and is largest newNode data
            {
                NewNode1.next = this.head;                   //head is assigned to the newNode next
                this.head = NewNode1;                        //newNode assigned to the head
            }
            else
            {
                Node temp = this.head;                      //here Node type of temp variable create and assigned to the head

                /* Locate the node before the point of insertion */
                while (temp.next != null && temp.next.data < NewNode1.data) //comparing condition
                {
                    temp = temp.next;                        //increment temp variable
                }
                NewNode1.next = temp.next;                    //assigned to the temp next to the newNode next
                temp.next = NewNode1;                         //newnode assigned to the temp next
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
