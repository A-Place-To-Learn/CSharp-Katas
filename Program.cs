using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        enum month { January, Febuary, March, Apirl, May, June, July, Augest, September, October, November, December };
        static void Main(string[] args)
        {
            string[] months = { "January", "Febuary", "March", "April", "May", "June", "July", "Augest", "September", "October", "November", "December" };
            Console.WriteLine("Please enter the month in numerical value (1-12)");
            Console.ReadLine();



            string input = Console.ReadLine();
            int result;
            if (!int.TryParse(input, out result))
            {

                if (result > 1 && result < 13)

                {

                    Console.WriteLine("Please close the program, run the program again, and input  number between 1-12");
                    Console.ReadLine();

                }
                else
                {

                    switch (result)
                    {
                        case 1:
                            Console.WriteLine("Your month is a Winter month.");

                            break;

                        case 2:
                            Console.WriteLine("Your month is a Winter month");
                            break;

                        case 3:
                            Console.WriteLine("Your month is a Spring month");
                            break;

                        case 4:
                            Console.WriteLine("Your month is a Spring month.");
                            break;
                        case 5:
                            Console.WriteLine("Your month is a Spring month.");
                            break;
                        case 6:
                            Console.WriteLine("Your month is a Summer month.");
                            break;
                        case 7:
                            Console.WriteLine("Your month is a Summer month.");
                            break;
                        case 8:
                            Console.WriteLine("Your month is a Summer month.");
                            break;
                        case 9:
                            Console.WriteLine("Your month is a Fall month.");
                            break;
                        case 10:
                            Console.WriteLine("Your month is a Fall month.");
                            break;
                        case 11:
                            Console.WriteLine("Your month is a Fall month.");
                            break;
                        case 12:
                            Console.WriteLine("Your month is a Winter month.");
                            break;
                    }
                }
                Console.ReadLine();

            }
        }
    }
}


