using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.Title = "Warm Up: Login";
            Console.WriteLine("Warm Up: Login\n");

            bool repeat = true;

            int attempts = 1;

            do
            {

                Console.Write("Enter 'x' to EXIT.\nAttempt " + attempts + "\nEnter your username: ");
                string userName = Console.ReadLine().ToLower();

                if (userName == "kayla")
                {
                    Console.Clear();
                    repeat = false;

                    do
                    {

                    
                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine().ToLower();

                        if (password == "password")
                        {
                            Console.WriteLine("Access granted!");
                            repeat = false;
                        }

                        else if (attempts == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Access denied.");
                        }
                       
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Access denied. Try again.");
                            repeat = true;
                        }

                        attempts++;
                    } while (repeat && attempts<=3);

                }//end if
                else if (userName == "x")
                {
                    Console.WriteLine("Have a great day!");
                    repeat = false;
                }//end else if
                else
                {
                    Console.Clear();
                    Console.WriteLine("Access denied. Try again.");
                }//end else

                attempts++;

            } while (repeat && attempts <= 3);//end for

            

        }//end Main()
    }//end class
}//end namespace
