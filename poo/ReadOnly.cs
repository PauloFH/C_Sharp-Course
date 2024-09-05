using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo {
    internal class ReadOnly {

        public static void ReadOnly_test() {
            string name = "geraldo";
            var newPerson = new Person(name:name, new DateTime(day:21,month:01, year: 2003));

            Console.WriteLine(newPerson.ToString());
        }

    }
     public class Person {
       private string _name = String.Empty;
       readonly private DateTime _bornDate; // nascimento será setado dentro do contrutor e não muda mais
        public string Name {
            get => _name;
            set => _name = value.Trim() == string.Empty ? "name" : value;
        }
        public string BornDate {
            get => $"{_bornDate.Day}/{_bornDate.Month}/{_bornDate.Year}";
        }

        public Person(string name , DateTime date) { 
               Name = name;
                _bornDate = date;
        }
        public override string ToString() {
            return $"Name: {this. Name} \nBorn in :{this.BornDate}";
        }
    }
}
