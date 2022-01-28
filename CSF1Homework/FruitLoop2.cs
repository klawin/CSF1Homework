using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            Console.Title = "Warm Up: Fruit Loop 2";
            Console.WriteLine("Warm Up: Fruit Loop 2");

            string[] fruits = { "apple", "orange", "pear", "watermelon", "banana", "strawberry" };
            string y = ".";
            for (int x = 0; x < 6; x++, y+=".")
            {
                Console.WriteLine(fruits[x]);
                Console.WriteLine(y);
            }

        }//end Main()
    }//end class
}//end namespace
