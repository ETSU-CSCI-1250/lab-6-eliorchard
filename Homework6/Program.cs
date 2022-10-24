using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Homework6
{
    public class Program
    {
        private static object cel;

        #region Celsius
        public static float Celsius(float far)
        {
            float cel = (9f / 5f) * (far - 32);
            return cel;
            return far;
            Console.WriteLine($"The temperatue in celcius is {cel}");

        }
        #endregion
        #region Char
        static char Char(string str, int index)
        {
            return str[index - 1];


        }
        #endregion
        #region CalculateRetail
        static double CalculateRetail(double price, double markup)
        {

            return price + price * markup / 100;


        }
        #endregion
        public static void Main(string[] args)
        {
           

                string str = "New York";
                Console.WriteLine(Char(str, 2));
                Console.WriteLine("Please eneter the wholesale cost:");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("What is the markup on the item?");
                double markup = double.Parse(Console.ReadLine());
                double total;
                total = CalculateRetail(price, markup);
                Console.WriteLine("Your total is $ " + total);
                Console.WriteLine("Please eneter the temperature in fahrenheit");
                float far = float.Parse(Console.ReadLine());
            Console.WriteLine($"The temperatue in celcius is {(9f / 5f) * (far - 32)}");







            for (int i = 80; i <= 100; i++)
            {

                float cel = (float)i;
                Console.WriteLine("   " + i + "           " + Celsius(cel));
            }

        }
        
       
        
    }
}


