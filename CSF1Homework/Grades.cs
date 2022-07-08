using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Grades
    {
        static void Main(string[] args)
        {
            Console.Title = "Grades";
            Console.WriteLine("Grades");

            bool repeat = true;
            do
            {
                Console.Write("Enter test score: ");
                //int score = Convert.ToInt32(Console.ReadLine());
                //var testScore =new List<int>(score);

                //if (score>=0)
                //{
                //    Console.WriteLine(testScore);                    
                //}
                //else if(score<0)
                //{
                //    repeat = false;
                //    Console.WriteLine("Your scores: {0}", testScore);
                //}

            } while (repeat);

        }//end Main()
    }//end class
}//end namespace
