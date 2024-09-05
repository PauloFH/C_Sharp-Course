using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections {
    internal class ArrayLists {

        public static void ArrayLists_test() {
            
            var arraylist = new ArrayList {
                "Test",
                33,
                false
            };
            arraylist.Add(2.22M);
            foreach (var item in arraylist) {
                Console.WriteLine(item);
            }
        }

    }
}
