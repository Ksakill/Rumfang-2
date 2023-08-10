using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i am sure about some more then other wthin the code below thought i have an ok understanding of what has been made, or am pretty sure i understand.
            double L, B, H;

            Console.Write("Insert length (L): "); // writes what is within the ""
            string lengthInput = Console.ReadLine(); // Reads the user input and stores it as a string
            L = Convert.ToDouble(lengthInput); // Convert the string into a double and stire in vriable B

            Console.Write("Insert width (B): ");
            string widthInput = Console.ReadLine();
            B = Convert.ToDouble(widthInput);

            Console.Write("Insert height (H): ");
            string heightInput = Console.ReadLine();
            H = Convert.ToDouble(heightInput);

            double volume = Rumfang(L, B, H); //does the same as above in the string length just with diffrent variables and functions.

            Console.WriteLine($"Rumfanget er {volume}");
        }

        static double Rumfang(double L, double B, double H)
        {
            return L * B * H; // returns the numbers given into the final result,
        }
    }
}
// note i got help online form both reading a bit and some from my old projects to make this. also my Debug function isnt too fond of this program it works if you run it on no debug ill try to find out why.