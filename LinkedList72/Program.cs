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
            Console.WriteLine("Wellcome to LinkedList ");
            LinkedList list = new LinkedList();      //creating object of linklist class
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);
            list.Display();
            Console.ReadLine();

        }
    }
}   

