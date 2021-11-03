using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList72
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();      //creating object of linklist class
            list.Insert(56);
            list.Insert(30);
            list.Insert(70);
            list.InsertAfter(list.head.next, 40);
            list.Display();
            Console.ReadLine();

        }
    }
}   

