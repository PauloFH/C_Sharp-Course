using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo {
    class StructxClass {

         public static void StructxClass_test() {
            var pont1 = new SPoint {X = 1,Y = 9};
            var pont2 = new CPoint { X = 4,Y = 93};
            var copyp2 = pont2;
            SPoint copyp1 = pont1;
            Console.WriteLine($" ponto 1: { pont1.X}");
            Console.WriteLine($" copia ponto 1: {copyp1.X}");
            Console.WriteLine($" ponto 2: {pont2.X}");
            Console.WriteLine($" copia ponto 2: {copyp2.X}");
            pont1.X = 2;
            pont2.X = 43;
            Console.WriteLine($" ponto 1: {pont1.X}");
            Console.WriteLine($" copia ponto 1: {copyp1.X}");
            Console.WriteLine($" ponto 2: {pont2.X}");
            Console.WriteLine($" copia ponto 2: {copyp2.X}");



        }

    }
    public struct SPoint{
        public int X;
        public int Y;
    }
    public class CPoint {
        public int X;
        public int Y;    
    }
}
