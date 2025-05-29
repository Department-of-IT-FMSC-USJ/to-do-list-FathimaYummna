using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_
{
    class Stack
    {
        private Node first;

        public Stack()
        {
            first = null;
        }

        public void Push(Task task)
        {
            Node newNode = new Node(task);
            newNode.Next = first;
            first = newNode;
        }

        public Node Pop()
        {
            if (first == null) return null;

            Node temp = first;
            first = first.Next;
            temp.Next = null;
            return temp;
        }

        public Node peek()
        {
            return first;
        }

        public void Show()
        {
            Node current = first;
            while (current != null)
            {
                Console.WriteLine($"ID : {current.Data.ID},name:{current.Data.name},date:{current.Data.date},description:{current.Data.description},status:{current.Data.status}");
                current = current.Next;
            }
        }
    }
}
