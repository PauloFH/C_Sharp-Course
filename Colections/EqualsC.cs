using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections {
    internal class EqualsC {

        public static void EqualsC_test() {
            var prod1 = new Product("Pen", 1.89M);
            var prod2 = new Product("Pen", 1.89M);
            var prod3 = prod2;

            Console.WriteLine(prod1 == prod2);
            Console.WriteLine(prod2 == prod3);
            Console.WriteLine(Console.Equals(prod3, prod1));

        }

    }
}
