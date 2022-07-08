using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Title = "FizzBuzz";
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= userInput; i++)
            {
                

                if (i%3 == 0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (i%3 == 0 || i%5 == 0)
                {
                    if (i%3==0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine("Buzz");
                    }    
                }
                
                else
                {
                    Console.WriteLine(i);
                }

            }
            
        }//end Main()
    }//end class
}//end namespace