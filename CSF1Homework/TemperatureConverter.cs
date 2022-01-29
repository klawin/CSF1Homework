using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TemperatureConverter
    {
        static void Main(string[] args)
        {
            Console.Title = "Warm Up: Temperature Converter";
            Console.WriteLine("Warm Up: Temperature Converter");
            bool repeat = true;
            do
            {

            
                Console.WriteLine("Please choose an option\n");

                Console.WriteLine("1) Celsius to Fahrenheit\n" +
                "2) Fahrenheit to Celsius\n");

                ConsoleKey userchoice = Console.ReadKey(true).Key;

                switch (userchoice)
                {
                    case ConsoleKey.C:
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        Console.Write("Please provide a temperature in °C: ");
                        int degreesC = Convert.ToInt32(Console.ReadLine());
                        int degreesF = (degreesC * 9 / 5) + 32;

                        Console.WriteLine($"{degreesC}°C = {degreesF}°F.\n");

                        break;

                    case ConsoleKey.F:
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        Console.Write("Please provide a temperature in °F: ");
                        degreesF = Convert.ToInt32(Console.ReadLine());
                        degreesC = (degreesF - 32) * 5 / 9;

                        Console.WriteLine($"{degreesF}°F = {degreesC}°C.\n");
                        
                        break;
                        
                    default:
                        Console.WriteLine("User input not recognized.");
                        break;
                }//end switch

                Console.WriteLine("Would you like to convert another? Y/N");
                ConsoleKey yes = Console.ReadKey(true).Key;
                if (yes == ConsoleKey.Y)
                {
                    Console.Clear();
                }//end if
                else
                {
                    Console.WriteLine("Have a good day!");
                    repeat = false;
                }//end else
                
            } while (repeat);//end do while
            
         

        }//end Main()
    }//end class
}//end namespace
