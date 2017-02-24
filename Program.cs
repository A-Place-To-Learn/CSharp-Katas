using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        enum months { January, Febuary, March, April, May, June, July, Augest, Sepetember, October, November, December};

        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the month in numerical value (1-12)");
            Console.ReadLine();
            int result;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out result))
            {
                
                if (result < 1 && result > 12)
                {
                    
                    Console.WriteLine("Please close the program, run the program again, and input  number between 1-12");
                    Console.ReadLine();

                }

            }
            }

     
           
        }

    }

