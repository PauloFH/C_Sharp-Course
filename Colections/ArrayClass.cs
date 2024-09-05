
namespace Colections {
    internal class ArrayClass {

        public static void ArrayClass_test() {

            String[] strings = new string[5]; // fixed-size homogeneous array
            strings[0] = "Aa  aaa";
            strings[1] = "B";
            strings[2] = "Ccccc";
            Object[] objects = new Object[5];//fixed size "heterogeneous" array
            objects[1] = 1;
            objects[2] = "ABABA";
            objects[3] = 4.53M;

            foreach (Object obj in objects) {
                Console.WriteLine(obj);
            }
            Decimal[] val = {5.7M, 4.5M, 2.3M };
            Decimal average = Decimal.Zero;

            foreach (var v in val) {
                average += v;
            }
            average /= val.Length;
            Console.WriteLine(average.ToString("#.#"));
        }

    }
}
