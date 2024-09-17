using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo {
    public abstract class CelPhone {
        public  abstract string Sing();

        public virtual void Net() {
            Console.WriteLine("Conected");
        }
    }
    public class Iphone : CelPhone {
        public override string Sing() {
            return "TRIMM";
        }
    }

    internal class Abstract {

        public static void Abstract_test() {
            new Iphone().Net();
            Console.WriteLine(new Iphone().Sing());

        }

    }
}
