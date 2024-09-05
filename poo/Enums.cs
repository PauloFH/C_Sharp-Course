using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo {
    public enum  GenresEnum { Action, Comedies, Horror, Romance, scifi};
    public class Movies {
        public string Title = String.Empty;
        public GenresEnum Genre;
    }

        internal class Enums {

            public static void Enums_test() {
                    var Movie = new Movies();
                    Movie.Title = "avatar";
                    Movie.Genre = GenresEnum.Action;
                    var id = Movie.Genre;// enum 
                    int id_int = (int)Movie.Genre; // vira int
                    Console.WriteLine(id_int);
            }


        }
    }

