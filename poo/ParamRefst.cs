
namespace poo {
    internal class ParamRefst {

        public static void AlterarRef( ref int numero) {
             numero += 1000;
        }
        public static void AlterarOut(out int numero) {
            numero = 0;
            numero += 400;
        }
        public static void ParamRefst_test() {
            int numero1 = 5;
            AlterarRef(ref numero1);
            
            AlterarOut(out int numero2);
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            //string teste1 = "string";
            string teste2 = "text";
            AlterarOut(out string teste1);
            AlterarRef(ref teste2);
            Console.WriteLine(teste1);
            Console.WriteLine(teste2);

        }
        public static void AlterarRef( ref string arg) {
            arg = arg.ToUpper() + " MUDADO";
        }
        public static void AlterarOut(out string arg) {
            arg = "";
                arg = arg.ToUpper() + " MUDADO";
            }
    }
}
