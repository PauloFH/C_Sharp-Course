
using System.Globalization;

namespace poo {
    internal class Constructors {
        public static void Constructors_test() {
            var CarOld1 = new CarOld();
            CarOld1.Manufacture = "bmw";
            CarOld1.Age = 2010;
            CarOld1.Model = "320i";

            CarOld CarOld2 = new CarOld("Hammer","gmc",2023 );
            Console.WriteLine($"First CarOld: \n{CarOld1.ToString()}\n" +
                $"Second CarOld:\n{CarOld2.ToString()}");
        }

    }
    
   class CarOld {
        public string? Model;
        public string? Manufacture;
        public int? Age;

        public CarOld() {}

        public CarOld(string Model, string Manufacture, int Age) {
            this.Model = Model;
            this.Manufacture = Manufacture;
            this.Age = Age;
        }
        public override string ToString() {

            return string.Format($"{line()}"+
                $"Manufacture: {this.Manufacture}\n" +
                $"Model: {this.Model}\n" +
                $"Age: {this.Age}\n"+ $"{line()}");
        }
        public string line() {
            return "______________________________\n";
        }
    }

}
