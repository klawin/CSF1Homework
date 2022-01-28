using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            Console.Title = "Warm Up: Fruit Loop 1";
            Console.WriteLine("Warm Up: Fruit Loop 1");

            string[] fruits = { "apple", "orange", "pear", "watermelon", "banana", "strawberry" };
            
            for (int x = 0; x < 6; x++)
            {
                Console.WriteLine(fruits[x]);
            }

        }//end Main()
    }//end class
}//end namescape
