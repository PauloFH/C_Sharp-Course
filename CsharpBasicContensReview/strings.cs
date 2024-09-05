

namespace CSharpHelloWorld {
    internal class strings {
        public static void strings_test() {

            #region String
            string str = "Batata";
            string? stringTeste = string.Empty; // String Vazio
            Console.WriteLine(stringTeste.Equals(str)); // comparação de Strings
            String.Equals(str, stringTeste); // comparação de string usando a classe string
            if (String.IsNullOrEmpty(stringTeste)) // se for nulo ou vazio
            {
                Console.Write("ESCREVA Uma frase: ");
                stringTeste = Console.ReadLine();
            }
            Console.WriteLine("tamanho da frase: " + stringTeste?.Length); // mede tamanho da string
            Console.WriteLine("EM UPPER: " + stringTeste?.ToUpper()); // deixar tudo maiusculo
            Console.WriteLine("em lower: " + stringTeste?.ToLower()); // deixar tudo minusculo
            Console.WriteLine("Removendo os espaços do inicio e fim: " + stringTeste?.Trim());// remover espaços no inicio e fim
            Console.WriteLine("Removendo os espaços do fim: " + stringTeste?.TrimEnd());// remover espaços no fim
            Console.WriteLine("Removendo os espaços do inicio: " + stringTeste?.TrimStart());// remover espaços no inicio
            string[]? teste = stringTeste?.Split(',');
            string[] a = { "teste1", "teste" };
            List<string>? list = new List<string>();
            for (int i = 0; i < list.Count; i++) {
                list.Add(list[i].Replace("teste", "erro").Trim());
                Console.WriteLine(list[i]);
            }
            Console.WriteLine(list);
            #endregion

            #region Buscas String
            string names = "PaUlo Pedro Porco";
            Console.WriteLine("o indece da primeira letra P no nome " + names + " é :" + names.IndexOf("P"));//StringComparison.OrdinalIgnoreCase é opcional
            Console.WriteLine("o indece da ultima letra P no nome " + names + " é :" + names.LastIndexOf("P"));//StringComparison.OrdinalIgnoreCase é opcional
            Console.WriteLine("começa com Paulo: " + names.StartsWith("Paulo"));
            Console.WriteLine("começa com Paulo: " + names.StartsWith("Paulo", StringComparison.OrdinalIgnoreCase)); //StringComparison.OrdinalIgnoreCase é opcional
            Console.WriteLine("O trecho de string do 7 ao 12: " + names.Substring(6, "Pedro".Length));
            Console.WriteLine("contem pau em algum lugar da string: " + names.Contains("Pau"));
            Console.WriteLine("contem pau em algum lugar da string: " + names.Contains("pau", StringComparison.OrdinalIgnoreCase));//StringComparison.OrdinalIgnoreCase é opcional
            #endregion

        }

        public override bool Equals(object? obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string? ToString() {
            return base.ToString();
        }
    }
}
