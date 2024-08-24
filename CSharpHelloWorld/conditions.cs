
namespace CSharpHelloWorld
{
    internal class conditions
    {   
        public static void conditions_test()
        {
            int operadorTeste = 0;

            #region Estruturas de Condicao

            //if and else
#if true

            if (operadorTeste < 0)
            {
                Console.WriteLine("Menor");

            }
            else if (operadorTeste == 0)
            {

            }
            else
            {
                Console.WriteLine("Maior");
            }
#endif
            //switch case
            switch (operadorTeste)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;

                case > 0:
                    Console.WriteLine("Maior");
                    break;
                case < 0:
                    Console.WriteLine("Menor");
                    break;
                default:
                    Console.WriteLine("erro");
                    break;
            }

            #endregion
        }
    }
}
