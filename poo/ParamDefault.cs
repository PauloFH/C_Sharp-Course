using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo {
    internal class ParamDefault {

        public static int Add(int a = 1, int b = 1) {
            return a + b;
        }

        public static void ParamDefault_test() {

            Console.WriteLine(Add()); 
            Console.WriteLine(Add(34,56));
            Console.WriteLine(Add(b:6));
        }

    }
}
