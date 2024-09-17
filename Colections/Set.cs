

using System.Collections;

namespace Colections {
   
    internal class Set {

        public static void Set_test() {

            HashSet<Product> products = new HashSet<Product>();
            Product product = new Product("cake", 3.50M);
            products.Add(product);
            HashSet<Product> more = new HashSet<Product> {
                new Product("gun", 783.00M)
            };
            products.UnionWith(more);
            Console.WriteLine(products.Count);
            products.Add(new Product("bag", 25.00M));
            products.Add(new Product("ball", 1.99M));
            products.Add(new Product("Shirt", 15.00M));
            foreach (Product p in products) {
                Console.WriteLine(p.ToString());
            }
            //products.ForEach(p => Console.WriteLine(p.ToString()));
            
            Console.WriteLine(products.Count);
            // products.RemoveAt(1);
            products.RemoveWhere(p => string.Equals("ball", p.Name, StringComparison.OrdinalIgnoreCase));
            foreach (Product p in products) {
                Console.WriteLine(p.ToString());
            }
        }

    }
}
