
using System.Globalization;

namespace poo {
    internal class Constructors {
        public static void Constructors_test() {
            var car1 = new Car();
            car1.Manufacture = "bmw";
            car1.Age = 2010;
            car1.Model = "320i";

            Car car2 = new Car("Hammer","gmc",2023 );
            Console.WriteLine($"First car: \n{car1.ToString()}\n" +
                $"Second Car:\n{car2.ToString()}");
        }

    }
    
    class Car {
        public string? Model;
        public string? Manufacture;
        public int? Age;

        public Car() {}

        public Car(string Model, string Manufacture, int Age) {
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
