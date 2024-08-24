using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelloWorld
{
    internal class Dates
    {
        public static void Dates_test()
        {
            #region DataTime
            DateTime now = DateTime.Now;
            Console.WriteLine("data de agora: " + now);
            DateTime today = DateTime.Today;
            Console.WriteLine("data de hoje: " + today);
            Console.WriteLine("Data daqui a 7 dias: " + now.AddDays(7));
            Console.WriteLine("Data 2 meses atrás : " + now.AddMonths(-2));
            Console.WriteLine("Daqui a 46 anos: " + today.AddYears(46));
            Console.WriteLine("Data em formato curto: " + today.ToShortDateString());
            Console.WriteLine("Data em formato longo: " + today.ToLongDateString());
            Console.WriteLine("Hora em formato curto: " + now.ToShortTimeString());
            Console.WriteLine("Hora em formato longo: " + now.ToLongTimeString());
            Console.WriteLine("Data e hora separado");
            Console.WriteLine(now.Date);
            Console.WriteLine(now.Day);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Year);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);
            Console.WriteLine(now.Millisecond + "\n");
            var dayOfWeek = now.DayOfWeek;

            Console.WriteLine(now.TimeOfDay + "\n");
            Console.WriteLine("Dia da semana :"+ dayOfWeek);

            if (!(dayOfWeek == DayOfWeek.Saturday) || !(dayOfWeek == DayOfWeek.Sunday))
            {
                Console.WriteLine("Dia de semana!!!!");
            }
            else
            {
                Console.WriteLine("Fim de semana");
            }
            Console.WriteLine(now.DayOfYear);
            #endregion

            #region Formatacao Date
            var formats = new string[] { "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t",
                "T", "u", "U", "Y"};

            foreach (var format in formats)
            {
                Console.WriteLine("data formatada em formato {0}: {1}", format, DateTime.Now.ToString(format));
            }
            Console.WriteLine("Datas usando interpolação de string");
            Console.WriteLine($"Data Formato d: {now:d}");
            Console.WriteLine($"Data Formatada personalizada: {now:dd-MMMM-yyyy}");
            var newdate = DateTime.Now.ToString("D");
            Console.WriteLine($"Data Formatada personalizada 2 :{newdate}");
            Console.WriteLine($"Data americana: {now:MM/dd/yyyy HH:mm:ss:fff}");

            #endregion
        }  
    }
}
