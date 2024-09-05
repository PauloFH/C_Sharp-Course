namespace poo {
    internal class Get_Set {

        public static void Get_Set_test() {
            var car1 = new Car();
            var car2 = new Car(age: 2024, model: "gol bolinha");
            car1.setAge(2010);
            car1.SetModel("Truckbigao");
            Console.WriteLine($"carro1: {car1.GetModel} do ano {car1.GetAge}");
            Console.WriteLine($"carro1: {car2.GetModel} do ano {car2.GetAge}");

        }
        class Car {
            private int Age;
            private string Model;
            public Car(int age, string model) {
                this.Age = age;
                this.Model = model;
            }
            public Car() { Console.WriteLine(); }
            public int GetAge() {
                return this.Age;
            }
            public string GetModel() {
                return this.Model;
            }

            public void SetModel(string model) {
                this.Model = model;
            }
            public void setAge(int age) {
                this.Age = age;
            }

        }


    }
    class Props {

        public static void Props_test() {
            Props.person P = new();
            P.Name = "Test";

        }
        class person {
            private string name;
            public string Name {
                set { name = (value != string.Empty || value.Trim() != "") ? value : "nome"; }
                get { return $"{name}"; }
            }
            public int Age { get { return Age; } }

        }
        class Product {
            private int _amount = 0;
            private decimal _price;
            private decimal _discount;
            public decimal PriceDisconted {
                get => _price - (_price * _discount);

            }
            private string _name;
            public string Name {
                get => _name;
                set => _name = (value != string.Empty || value.Trim() != "") ? value : "nome";
            }
            public decimal Price {
                get => _price;
                set => _price = (value < 0 || value > int.MaxValue - 1) ? 1.99M : value;
            }
            private string? _description;

            public Product(string name, string description, decimal price, decimal discount) {
                Name = name;


            }
        }
    }
}
