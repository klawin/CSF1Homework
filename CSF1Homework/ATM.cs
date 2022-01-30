using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.Title = "ATM";
            Console.WriteLine("Welcome!");

            decimal acctBalance = 0;

            bool repeat = true;
            int attempts = 1;
            do
            {
                Console.Write("Enter your account number: ");
                int userAcctNbr = Convert.ToInt32(Console.ReadLine());
                if (userAcctNbr == 1234567)
                {
                    repeat = false;
                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Enter your pin number: ");
                        int userPin = Convert.ToInt32(Console.ReadLine());
                        
                        if (userPin == 1234)
                        {
                            Console.Clear();
                            Console.WriteLine("Access granted!");

                            do
                            {
                                Console.WriteLine("1) Deposit\n" +
                                    "2) Withdrawal\n" +
                                    "3) Balance\n" +
                                    "4) Exit\n");
                                ConsoleKey userChoice = Console.ReadKey(true).Key;
                                switch (userChoice)
                                {
                                    case ConsoleKey.D1:
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D:
                                        Console.WriteLine("Deposit\n");

                                        Console.Write("How much would you like to deposit? ");
                                        decimal depositAmt = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine("\n{0:c} will be desposited into account number {1}.", depositAmt, userAcctNbr);
                                        Console.WriteLine("\nAccount balance: {0:c}", acctBalance += depositAmt);
                                        Console.WriteLine("\nWould you like to make another transaction? Y/N");
                                        ConsoleKey anotherTrans = Console.ReadKey(true).Key;
                                        if (anotherTrans == ConsoleKey.Y)
                                        {
                                            Console.Clear();
                                            repeat = true;  
                                        }//end if
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Thank you! Have a great day.");
                                            repeat = false;
                                        }//end else
                                       
                                        break;

                                    case ConsoleKey.D2:
                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.W:
                                        Console.WriteLine("Withdrawal\n");

                                        Console.Write("How much would you like to withdrawal? ");
                                        decimal withdrawalAmt = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine("\n{0:c} will be withdrawn from account number {1}.", withdrawalAmt, userAcctNbr);
                                        Console.WriteLine("\nAccount balance: {0:c}", acctBalance -= withdrawalAmt);
                                        Console.WriteLine("\nWould you like to make another transaction? Y/N");
                                        anotherTrans = Console.ReadKey(true).Key;
                                        if (anotherTrans == ConsoleKey.Y)
                                        {
                                            Console.Clear();
                                            repeat = true;
                                        }//end if
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Thank you! Have a great day.");
                                            repeat = false;
                                        }//end else
                                        break;

                                    case ConsoleKey.D3:
                                    case ConsoleKey.NumPad3:
                                    case ConsoleKey.B:
                                        Console.WriteLine("Account balance: {0:c}", acctBalance);
                                        Console.WriteLine("\nWould you like to make another transaction? Y/N");
                                        anotherTrans = Console.ReadKey(true).Key;
                                        if (anotherTrans == ConsoleKey.Y)
                                        {
                                            Console.Clear();
                                            repeat = true;
                                        }//end if
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Thank you! Have a great day.");
                                            repeat = false;
                                        }//end else
                                        break;
                                    case ConsoleKey.D4:
                                    case ConsoleKey.NumPad4:
                                    case ConsoleKey.X:
                                    case ConsoleKey.E:
                                        Console.WriteLine("Thank you. Have a great day!");
                                        repeat = false;
                                        break;
                                    default:
                                        Console.WriteLine("I'm sorry. I did not understand. Please try again.");                        

                                        break;
                                }//end switch
                            } while (repeat);//end do while

                        }//end if

                        else if (attempts == 3)
                        {
                            Console.WriteLine("Access denied.");
                            repeat = true;
                        }//end else if

                        else
                        {
                            Console.WriteLine("Access denied. Try again");
                            repeat = true;
                        }//end else

                        attempts++;

                    } while (attempts <=3 && repeat);//end do while
                }//end if
                else if (attempts == 3)
                {
                    Console.WriteLine("Account not found.");
                }//end else if
                else
                {
                    Console.WriteLine("Account not found. Try again.");
                }//end else
                attempts++;
            } while (repeat && attempts <= 3);//end do while
        }//end main()
    }//end class
}//end namespace
