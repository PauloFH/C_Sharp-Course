

using System.Collections;

namespace Colections {

    internal class Product {
        public string Name;
        public decimal Price;
        public string? Description;

        public Product(string name, decimal price) {
            Name = name;
            Price = price;
        }
        public Product(string name, decimal price, string? description) {
            Name = name;
            Price = price;
            Description = description;

        }

        public override bool Equals(object? obj) {
            return obj is Product product &&
                   Name == product.Name &&
                   Price == product.Price &&
                   Description == product.Description;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Name, Price, Description);
        }

        public override string ToString() {
            return $"Name: {this.Name}, price: {this.Price};{((Description != null) ? this.Description : "")}";
        }
    }
    internal class Lists {



        public static void Lists_test() {

            List<Product> products = new List<Product>();
            Product product = new Product("cake", 3.50M);
            products.Add(product);

            Console.WriteLine(products.Count);
            products.Add(new Product("bag", 25.00M));
            products.Add(new Product("ball", 1.99M));
            products.Add(new Product("Shirt", 15.00M));
            products.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine(products.Count);
            products.RemoveAt(1);
            products.ForEach(p => Console.WriteLine(p.ToString())); 
        }

    }
}
