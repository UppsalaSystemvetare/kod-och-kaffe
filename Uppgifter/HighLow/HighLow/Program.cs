using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Detta är ett klassiskt spel där man som användare ska gissa vilket tal programmet 'tänker' på, 
             * vilket i sin tur ska svara med ledtrådar om man gissat för högt eller för lågt.
             * 
             * Mycket av koden är redan skriven men programmet innehåller ett antal fel som behöver fixas för att det ska fungera.
             * På alla rader där Visual Studio ger felmeddelanden ska det inom /* och * / ersättas av kod.
             * 
             * Lycka till!
             */

            Random rnd = new Random();
            bool stillWondering = true;
            int maxNumber = /*sätt högsta tal*/;
            int guessedNumber;
            int correctNumber = /*generera ett slumpmässigt tal med Random-objektet*/;
            Console.WriteLine("Jag tänker på ett tal mellan 0 och " + maxNumber + ". Gissa vilket!");
            while (/*loopen körs så länge uttrycket i parantesen är sant*/)
            {
                guessedNumber = Convert.ToInt32(Console.ReadLine());
                if (/*det vilkor som skall uppfyllas för att meddelandet nedan skall skrivas ut.*/)
                {
                    Console.WriteLine("För lågt!");
                }
                else if (/*det vilkor som skall uppfyllas för att meddelandet nedan skall skrivas ut.*/)
                {
                    Console.WriteLine("För högt!");
                }
                else
                {
                    Console.WriteLine(/*passande meddelande*/);
                    stillWondering = false;
                }
            }

            Console.ReadLine(); //Programmet avslutas automatiskt om vi inte säger åt det att vänta på en inmatning.
        }
    }
}
