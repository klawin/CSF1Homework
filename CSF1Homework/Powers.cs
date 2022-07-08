using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            Console.Title = "Powers";
            Console.WriteLine("Powers");

            for (int i = 1; i<=50; i++)
            {
                double power = Math.Pow(2, i);
                Console.WriteLine("{0}", power);
            }

        }//end Main()
    }//end class
}//end namespace
