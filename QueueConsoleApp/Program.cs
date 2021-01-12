using System;
using System.Collections.Generic;

namespace QueueConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic Class Queue in C#
            Queue<int> queue = new Queue<int>();
            int count = 0;

            Console.WriteLine("Queue Generic Class");

            Console.WriteLine("How many element needed in Queue");
            var inputCount = Console.ReadLine();

            if(Int32.TryParse(inputCount, out count))
            {
                for(int i=0;i<count;i++)
                {
                    queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Number of elements in Queue is {queue.Count}");
            Console.WriteLine($"Latest element in Queue is {queue.Peek()} - Queue PeeK Operation");

            while(queue.Count > 0)
            {
                Console.WriteLine($"Element in Queue is {queue.Dequeue()} - Queue Dequeue Operation");
            }

            // Queue with Linked List
            Console.WriteLine();
            QueueLinkedList queueLinkedList = new QueueLinkedList();
            Console.WriteLine("How many element needed in Queue");
            var inputListCount = Console.ReadLine();

            if (Int32.TryParse(inputListCount, out count))
            {
                for (int i = 0; i < count; i++)
                {
                    queueLinkedList.Enqueue(Convert.ToInt32(Console.ReadLine()));
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Latest element in Queue is {queueLinkedList.PeeK()} - Queue PeeK Operation");

            while (queueLinkedList.first != null)
            {
                Console.WriteLine($"Element in Queue is {queueLinkedList.Dequeue()} - Queue Dequeue Operation");
            }

        }
    }
}
