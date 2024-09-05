using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo {
    internal class ChainMethods {
        public static void ChainMethods_test() {
            var chain  = new ChainCalculator();

            var value = chain.AddInt(5).MultInt(4).DivInt(2).Print().Clean().AddInt(500).DivInt(11).Print().Result();
            Console.WriteLine(value.ToString("F"));
        }   

      
    }
    class ChainCalculator {
        decimal result;

        public ChainCalculator AddInt(int number) {
            result +=number;
            return this;
        }
        public ChainCalculator AddDecimal(decimal number) {
            result +=number;
            return this;
        }
        public ChainCalculator SubInt(int number) { 
            result -=number;
            return this;
        }
        public ChainCalculator SubDecimal(int number) {
            result -= number;
            return this;
        }
        public ChainCalculator MultInt(int number) {
            result *= number;
            return this;
        }
        public ChainCalculator MultDecimal(int number) {
            result *= number;
            return this;
        }
        public ChainCalculator DivInt(int number) {
            result /= number;
            return this;
        }
        public ChainCalculator DivDecimal(int number) {
            result /= number;
            return this;
        }
        public ChainCalculator Print() {
            Console.WriteLine($"the result is: {result.ToString("#.##")}");
            return this;
        }
        public ChainCalculator Clean() {
            result = 0;
            return this;
        }

        public decimal Result() { return result; }


    }
}
