using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_
{
    class SinglyLinkedListcs
    {
        private Node head;

        public SinglyLinkedListcs()
        {
            head = null;
        }

        public void AddItems(Task task)
        {
            Node newNode = new Node(task);

            if (head == null)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void Show_Tasks()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine($"ID : {current.Data.ID},name:{current.Data.name},date:{current.Data.date},description:{current.Data.description},status:{current.Data.status}");
                current = current.Next;
            }
        }

        public Node Remove_Head()
        {
            if (head == null) return null;

            Node temp = head;
            head = head.Next;
            temp.Next = null;
            return temp;
        }
        public Node GetHead()
        {
            return head;
        }
    }
}
