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
            Console.WriteLine(  "Wellcome to LinkedList ");
            LinkedList list = new LinkedList();      //creating object of linklist class
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.ReadLine();
        }
    }
}
