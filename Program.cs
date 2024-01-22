using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //decalaration
            string name = "John";
            int age = 35;
            bool isTall = false;
            double weight = 80.2;

            /*for the smallest least precise decimal use flaot,
             * in most cases double will do just fine,
             *  */

            Console.WriteLine(name + " is " + age + " he weighs " + weight);
            Console.WriteLine("it is " + isTall + " that he is tall");

            //freeze console
            Console.ReadLine();

        }
    }
}
