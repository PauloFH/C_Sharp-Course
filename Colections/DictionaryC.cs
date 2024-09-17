using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections {
    internal class DictionaryC {

        public static void DictionaryC_test() {
           var movies = new Dictionary<int,string>();
            movies.Add(2024, "Trap");
            movies.Add(1987, "Dirty Dancing");
            movies.Add(2023,"T.Boy and T. Heron");

            if (movies.ContainsKey(2023))
            {
                Console.WriteLine(movies[2023]);
                Console.WriteLine(movies.GetValueOrDefault(2023));
                Console.WriteLine(movies.ContainsValue("Dirty Dancing"));
            }
            Console.WriteLine($"EXISTE E REMOVEU? {movies.Remove(2004)}");

           bool result = movies.TryGetValue(1987, out var value);
            Console.WriteLine($"result operation: {result}  out:{value} ");
            foreach (var keys in movies.Keys) {
                Console.WriteLine(keys);
            }
            foreach (var movie in movies.Values)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
            foreach(KeyValuePair<int, string> movie in movies)
            {
                Console.WriteLine($"movie: {movie.Value} year:{movie.Key}");
            }
            Console.WriteLine();
            foreach (var movie in movies)
            {
                Console.WriteLine($"movie: {movie.Value} year:{movie.Key}");
            }
        }
        
    }
}
