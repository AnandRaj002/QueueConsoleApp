using System;

namespace QueueConsoleApp
{
    public class Node
    {
        public int data;
        public Node link;
    }

    public class QueueLinkedList
    {
        public Node first, last;

        public QueueLinkedList()
        {
            this.first = null;
            this.last = null;
        }

        public void Enqueue(int x)
        {
            Node node = new Node();
            node.data = x;

            if (first == null)
            {
                first = last = node;
            }

            last.link = node;
            last = node;
        }

        public int PeeK()
        {
            if((first != null))
            {
                return first.data;
            }
            else
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
        }

        public int Dequeue()
        {
            if(first != null)
            {
                int data = first.data;
                first = first.link;
                return data;
            }
            else
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
        }
    }
}
