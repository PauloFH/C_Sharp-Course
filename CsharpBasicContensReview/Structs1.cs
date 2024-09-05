using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicContensReview {
    internal class Structs1 {
        interface Point { void DiagonalMove(int delta);     }
        struct Coordinate : Point {
            public int X;
            public int Y;

            public Coordinate(int x, int y) {
                X = x;
                Y = y;
            }

            public void DiagonalMove(int delta) {
               X += delta;
               Y += delta;
            }
        }
        public static void Structs_test() {
            Coordinate initialCoordinates;
            initialCoordinates.Y = 10;
            initialCoordinates.X = 5;
            Console.WriteLine("initial coordinate:");
            Console.WriteLine("X:{0}", initialCoordinates.X);
            Console.WriteLine("Y:{0}", initialCoordinates.Y);
            Coordinate finalCoordinates = new Coordinate(8,5);
            finalCoordinates.DiagonalMove(10);
            Console.WriteLine("final coordinate:");
            Console.WriteLine("X:{0}", finalCoordinates.X);
            Console.WriteLine("Y:{0}", finalCoordinates.Y);

        }

    }
}
