using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            Console.Title = "Interest Calculator";
            Console.Write("Enter the beginning balance: ");
            decimal principal = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the interest rate percentage: ");
            decimal interest = Convert.ToDecimal(Console.ReadLine());
            interest = interest / 100;
            Console.Write("Enter the number of years: ");
            decimal year = Convert.ToDecimal(Console.ReadLine());

            decimal total = principal + (principal*interest*year);

            Console.WriteLine("The amount you will have in 2 years: {0:c}", total);


        }//end Main()
    }//end class
}//end namespace
