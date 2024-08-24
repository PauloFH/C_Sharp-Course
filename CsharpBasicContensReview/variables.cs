
namespace CSharpHelloWorld
{
    internal class variables
    {
        public static void variables_test()
        {
            #region Variables
            char ch = 'a';
            bool bul = false;
            string str = "batata";
            int interger = 10;
            decimal dec = 3.3M;
            float flt = 4.3f;
            double doub = 6.7;
            #endregion

            #region Conversões
            double intToDouble = interger; //conversão implícita
            int doubleToInt = (int)intToDouble; //conversão explícita
            string stringToDouble = "3.6";
            intToDouble = Double.Parse(stringToDouble); // conversão com parse
            string stringToInt = "5";
            interger = Int32.Parse(stringToInt); // conversão com parse
            interger = Convert.ToInt32(intToDouble); // Conversão com Convert
            doub = Convert.ToDouble(stringToDouble);// conversão com Convert 
            #endregion


            #region Operadores matematicos
            //soma e subtração + - ++ --
            int operadorTeste = 10;


            Console.WriteLine(operadorTeste++); // soma após passar a linha
            Console.WriteLine(++operadorTeste); // soma antes de passar a linha
            Console.WriteLine(operadorTeste--); // subtrai após passar a linha
            Console.WriteLine(--operadorTeste); // subtrai antes de passar a linha
            int soma = operadorTeste + 4;
            int subtracao = soma - operadorTeste;
            //multiplicaçao, divisão 
            int multi = soma * 4;
            int divisao = operadorTeste / 4; //divisão removendo o resto;
            decimal divisaoreal = soma / 3;
            //resto
            int resto = soma % 3;
            //potência e raiz quadrada e logarithm
            double potencia = Math.Pow(operadorTeste, 2);//potência
            double raiz = Math.Sqrt(operadorTeste);//Raiz
            int bases = 10;
            double log = Math.Log(operadorTeste, bases); //log
            #endregion

            #region operadores de comp e igual
            Console.WriteLine(log < operadorTeste);
            Console.WriteLine(bases > operadorTeste);
            Console.WriteLine(log >= operadorTeste);
            Console.WriteLine(operadorTeste <= soma);
            Console.WriteLine(bases == 10);
            Console.WriteLine(log != operadorTeste);

            #endregion

            #region Operadores Lógicos
            //and = & && or = | || xor = ^ not = !
            //ternario condition ? consequent : alternative

            Console.WriteLine(true | true);// or booleano
            Console.WriteLine(true || false); //or logico
            Console.WriteLine(true & false); // and booleano
            Console.WriteLine(true && true); // and logico
            Console.WriteLine(true ^ false); // xor ou or exclusivo
            Console.WriteLine(!false); //not
            Console.WriteLine(!false ? "RUIM" : "MAL"); // ternario
            #endregion

        }
    }
}
