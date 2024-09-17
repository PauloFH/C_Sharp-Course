using System;

using ClassLibrary;
namespace poo
{
    class Encapsulation {
        public class BastardChild : Famous {
            public new void Info() {
                Console.WriteLine(publicInfo);
                Console.WriteLine(social);
                //Console.WriteLine(cellphone);
                Console.WriteLine(secrets);
                //Console.WriteLine(signs);
                //Console.WriteLine(realAge);
            }
        }

        public class Fan {

            public readonly Famous friend = new Famous();
            public void Info() {
                Console.WriteLine(friend.publicInfo);
                //Console.WriteLine(friend.social);
                //Console.WriteLine(friend.cellphone);
                //Console.WriteLine(friend.secrets);
                //Console.WriteLine(friend.signs);
                // Console.WriteLine(realAge);
            }
        }
        public static void Encapsulation_test() {
            Console.WriteLine("Famous");
            new Famous().Info();
            Console.WriteLine("FamousChild");
            new FamousChild().Info();
            Console.WriteLine("BastardChild");
            new BastardChild().Info();
            Console.WriteLine("Friend");
            new Friend().Info();
            Console.WriteLine("Fan");
            new Fan().Info();

            


        }

    }
}
