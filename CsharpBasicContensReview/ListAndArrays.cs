
namespace CSharpHelloWorld {
    internal class ListAndArrays {
        public static void listAndArrays_test() {
            string stringToInt = "2";
            int cout;
            #region Arrays e Matriz
            int[] ints = new int[10]; // criação de um array vazio com espaço definido
            int[] ints2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // criação de um array de 10 espaços já cheio
            int[] ints3 = new int[10];
            // passar uma string parra array
            string stringToArrayString = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
            string[] stringArrayToIntArray = stringToArrayString.Split(",");

            for (int i = 0; i < stringArrayToIntArray.Length; i++) {
                stringToInt = stringArrayToIntArray[i];

                ints3[i] = Convert.ToInt32(stringToInt);
            }
            Console.WriteLine(ints3);
            foreach (int i in ints3) {
                Console.WriteLine(i);
            }
            for (int i = 0; i < ints.Length; i++) {
                ints[i] = ints2[i];
            }
            //Matriz a divisão de termos/camadas é por virgula [,](duas camadas) [,,] trê camadas e por ai vai

            int[,] matriz = new int[2, 2];
            cout = 0;
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    matriz[i, j] = cout++;
                }
            }
            foreach (int i in matriz) {
                Console.WriteLine(i);
            }
            #endregion

            #region Listas
            // podemos usar var para receber listas
            int[] numbers = { 3, 5, 6, 7, 6, 7 };
            var listaString = new List<string>(); // ele vai definir automaticamente  o listaString para List<string>
            List<int> listaInts = new List<int>(numbers);
            listaInts.Add(2);
            listaInts.Add(1);
            listaInts.AddRange(numbers);// addRange Pode receber tanto array como listas para insersão
            Console.WriteLine(listaInts.Contains(3));
            System.Console.WriteLine("lista ORDENADA:");
            listaInts.ForEach(l => Console.WriteLine(l));
            listaInts.Reverse();
            System.Console.WriteLine("lista REVERSA:");
            listaInts.ForEach(l => Console.WriteLine(l));
            listaInts.Sort();
            System.Console.WriteLine("lista ORDENADA SEM REPETIDOS:");
            listaInts.ForEach(l => Console.WriteLine(l));
            listaInts.Remove(1);
            System.Console.WriteLine("lista SEM O numero 1:");
            listaInts.ForEach(l => Console.WriteLine(l));
            listaInts.RemoveAt(4);
            System.Console.WriteLine("lista SEM O QUARTO TERMO:");
            listaInts.ForEach(l => Console.WriteLine(l));
            listaInts.RemoveAll(l => l > 3);
            System.Console.WriteLine("lista SEM OS MAIORES QUE 3:");
            listaInts.ForEach(l => Console.WriteLine(l));
            listaInts.Clear();
            System.Console.WriteLine("lista VAZIA:");
            System.Console.WriteLine("tamanho da lista atualmente: " + listaInts.Count);
            #endregion
           
        }
    }
}
