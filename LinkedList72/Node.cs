using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList72
{
    class Node
    {
        public int data;        //declared the integer type data variable
        public Node next;
        public Node(int data)  //constructor
        {
            this.data = data;
            next = null;
        }
    }
}
