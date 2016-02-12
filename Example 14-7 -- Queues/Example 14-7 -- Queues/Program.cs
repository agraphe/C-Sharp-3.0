using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_14_7____Queues
{
    public class Tester
    {

        static void Main()
        {
            Queue<Int32> intQueue = new Queue<Int32>();

            // populate the Queue.
            for (int i = 0; i < 5; i++)
            {
                intQueue.Enqueue(i * 5);
            }

            // Display the Queue.
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);

            // Remove an element from the Queue.
            Console.WriteLine("\n(Dequeue)\t{0}", intQueue.Dequeue());
            
            // Display the Queue.
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);

            // Remove another element from the Queue.
            Console.WriteLine("\n(Dequeue)\t{0}", intQueue.Dequeue());

            // Display the Queue.
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);

            // View the first element in the
            // Queue but do not remove.
            Console.WriteLine("\n(Peek)  \t{0}", intQueue.Peek());
            
            // Display the Queue.
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);
        }

        public static void PrintValues(IEnumerable<Int32> myCollection)
        {
            IEnumerator<Int32> myEnumerator = myCollection.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.Write("{0} ", myEnumerator.Current);
            }
            Console.WriteLine();
        }

    }
}
