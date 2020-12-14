using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividesEvenly
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

                Console.WriteLine("Check if number divides evenly.\nIf the function " +
                " returns no remainder (equaling 0), it divides evenly.\n" +
                "Otherwise, it doesn't divide evenly.");

                Console.WriteLine("\nPlease input first number: ");
               var aString =Console.ReadLine();

            while(!int.TryParse(aString, out a)){
            
                Console.WriteLine("Please input a valid number.");
                aString = Console.ReadLine();
            }

                Console.WriteLine("\nPlease input second number: ");
               var bString = Console.ReadLine();

            while (!int.TryParse(bString, out b))
            {
                Console.WriteLine("Please input a valid number.");
                bString = Console.ReadLine();
            }

            Console.WriteLine(DividesEvenly(a, b));
            }
        public static bool DividesEvenly(int a ,int b)
        {
            var result = (a % b) != 0 ? false : true;
            return result;
        }
    }
}
