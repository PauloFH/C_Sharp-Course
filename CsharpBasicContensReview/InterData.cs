using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicContensReview {
    internal class InterData {
        public static void InterData_test() {
            bool status = false;
            do {
                status = false;
                try {
                    Console.WriteLine("Digite um numero inteiro");
                    int numberEntrada = int.Parse(Console.ReadLine());
                    }
                catch (Exception ex) {
                    Console.WriteLine($"valor inválido");
                    status = true;
                    }
                } while (status);
            }
        }
    }
