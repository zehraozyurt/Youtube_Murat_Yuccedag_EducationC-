using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_video
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            double number;
            number = 4.85;
            Console.WriteLine(number);

            Console.WriteLine("**********Prince List**********");
            Console.WriteLine();
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 1.485;
            orangePrice = 2.095;
            strawberryPrice = 0.405;
            potatoPrice = 0.95;
            tomatoPrice = 0.688;

            double appleGram = 1.245;
            double orangeGram = 2.650;
            double strawberryGram = 0.750;
            double potatoGram = 4.859;
            double tomatoGram = 3.745;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;

            Console.WriteLine("Received item: Apple " + "     Unit price: " + applePrice + "          Grammage: " + appleGram + "      total amount: " + appleTotalPrice);
            Console.WriteLine("Received item: Orange " + "    Unit price: " + orangePrice + "          Grammage: " + orangeGram + "       total amount: " + orangeTotalPrice);
            Console.WriteLine("Received item: Strawberry " + "Unit price: " + strawberryPrice + "          Grammage: " + strawberryGram + "       total amount: " + strawberryTotalPrice);
            Console.WriteLine("Received item: Potato " + "    Unit price: " + potatoPrice + "           Grammage: " + potatoGram + "      total amount: " + potatoTotalPrice);
            Console.WriteLine("Received item: Tomato " + "    Unit price: " + tomatoPrice + "          Grammage: " + tomatoGram + "      total amount: " + tomatoTotalPrice);

            #endregion
        }
    }
}
