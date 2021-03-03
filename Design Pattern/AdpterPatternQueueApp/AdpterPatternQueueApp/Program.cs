using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdpterPatternQueueApp.Model;

namespace AdpterPatternQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            QueueAdapter<int> queue = new QueueAdapter<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Console.WriteLine("After three Enqueue 10, 20 and 30");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Before Dequeue count is ==> "+queue.Count());
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("After Dequeue count is ==> " + queue.Count());

            Console.WriteLine("Again two Enqueue with 20 and 30");
            queue.Enqueue(20);
            queue.Enqueue(30);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
