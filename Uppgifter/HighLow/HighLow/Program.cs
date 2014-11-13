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
