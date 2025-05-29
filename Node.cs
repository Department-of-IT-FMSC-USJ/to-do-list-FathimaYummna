using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_
{
    class Node
    {
        private Task data;
        private Node next;
        
        

        internal Node Next { get => next; set => next = value; }
        internal Task Data { get => data; set => data = value; }

        public Node (Task task)
        {
            data = task;
            next = null;
        }
    }
 
}
