using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AD.Collecction
{
    public class queue
    {
        public static void queues() {
            Queue<Object> num = new Queue<Object>();
            //adds the number to the queue using enqueue
            num.Enqueue("one");
            num.Enqueue("two");
            num.Enqueue("three");
            num.Enqueue("four");
            num.Enqueue("five");

            //looping the numbers out of the queue
            foreach (string number in num)
            {
                Console.WriteLine(number);
            }

            //dequeuing one and then peeking to see what the next value is, then dequeuing that one
            Console.WriteLine("\nDequeuing '{0}'", num.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}",
                num.Peek());
            Console.WriteLine("Dequeuing '{0}'", num.Dequeue());

            // Create a copy of the queue
            Queue<Object> queueCopy = new Queue<Object>(num.ToArray());

            //makes a copy of the first set that was not set to dequeue
            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }
            //Check if the queue contains four, if it does then it returns true
            Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
                queueCopy.Contains("four"));
            //Clears the queue
            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.ReadKey();
        }
    }
}
