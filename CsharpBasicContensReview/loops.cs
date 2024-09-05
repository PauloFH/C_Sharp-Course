
namespace CSharpHelloWorld {
    internal class loops {
        public static void loops_test() {


            #region Estruturas de Repeticao
            int[] vetor = { 1, 6, 5, 32, 65 };
            //forech
            foreach (var item in vetor) { Console.WriteLine(item); }
            //for
            for (int i = 0; i < vetor.Length; i++) {
                Console.WriteLine(vetor[i]);
            }
            //do - while
            do {
                Console.WriteLine("saida");
            }
            while (false);
            // while
            int cout = 0;
            while (cout < vetor.Length) { Console.WriteLine(vetor[cout++]); }
            #endregion

        }
    }
}
