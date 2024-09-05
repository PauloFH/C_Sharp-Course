using System;
using System.Collections.Generic;


namespace Colections {
    internal class QueueCollection {

        public static void QueueCollection_test() {
           var queue = new Queue<string>();
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("Third");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);
        }

    }
}
