using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.Title = "Warm Up: Mad Lib";
            Console.WriteLine("Warm Up: Mad Lib");

            string[] input = new string[3];

            Console.Write("Enter an adjective: ");
            input[0] = Console.ReadLine();

            Console.Write("Enter a verb: ");
            input[1] = Console.ReadLine();

            Console.Write("Enter a noun: ");
            input[2] = Console.ReadLine();

            Console.WriteLine($"The {input[2]} will {input[1]} until it is {input[0]}!");



        }//end Main()
    }//end class
}//end namespace
