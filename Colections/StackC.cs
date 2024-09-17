using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections {
    internal class StackC {

        public static void StackC_test() {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(4);
            stack.Push("game");
            stack.Push(5.5M);

            foreach (var item in stack){
                Console.Write($"   {item}");
            }

            Console.WriteLine("\n"+stack.Pop());
            Console.WriteLine(stack.Peek());
            foreach (var item in stack) {
                Console.Write($"   {item}");
            }
        }

    }
}
