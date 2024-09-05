
using System.Globalization;
using System.Net.NetworkInformation;
using System.Xml.Schema;

namespace poo {
     class Params {

        public static void Params_test() {
            test("Ronald", "Petter", "Paul", "Robert");
            var car = new Car(manufacture: "volkswagen", model: "gol");

        }

        public static void test(params string[] people) {
          foreach(var person in people) {
                Console.WriteLine("Hello!, {0}",person);
            }
        }
        
        internal class Car {
            string Model;
            string Manufacture;

            public Car(string model, string manufacture) {
                Model = model;
                Manufacture = manufacture;
            }
        }
           
    }

}
