
namespace poo {
    class Class_Methods {
        public static void Class_Methods_test() {
            Person paulo = new Person();
            paulo.Name = "Paulo";
            paulo.Age = 21;
            //paulo.introduceConsole();
            Console.WriteLine(paulo.introduce());
        }
        #region Classe em Método Interno

        internal class Person {
            public int Age = 0;
            public string Name = "";

            public string introduce() {
                return $"Hello, my name is {this.Name} and I'm {this.Age} years old!!";
            }
            public void introduceConsole() {
                Console.WriteLine(introduce());
            }
        }
        #endregion
    }



}

