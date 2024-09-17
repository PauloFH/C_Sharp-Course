using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo {
    internal class Payment {
        //public string Id { get; set; }

        public delegate void Pay(decimal amount);

    }
    internal class Delgate {
        public static void PaySucess(decimal amount) {
            Console.WriteLine("Payment Sucess : {0}", amount.ToString("#.##"));
        }

        public static void Delgate_test() {
            var pay = new Payment.Pay(PaySucess);
            pay(34.4M);

        }

    }
}
