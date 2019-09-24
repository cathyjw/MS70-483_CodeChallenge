using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var isContinue = "Y";

            do
            {
                bool rightOption = true;
                Console.WriteLine("Press any following key to perform an arithmetic operation:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multipliation");
                Console.WriteLine("4 - Division");

                var option = Console.ReadLine();

                Console.WriteLine("Enter Value 1: ");
                var val1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Value 2: ");
                var val2 = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case "1":
                        {
                            var result = val1 + val2;
                            Console.WriteLine("{0} + {1} = {2}", val1, val2, result);
                            break;
                        }
                    case "2":
                        {
                            var result = val1 - val2;
                            Console.WriteLine("{0} - {1} = {2}", val1, val2, result);
                            break;
                        }
                    case "3":
                        {
                            var result = val1 * val2;
                            Console.WriteLine("{0} * {1} = {2}", val1, val2, result);
                            break;
                        }
                    case "4":
                        {
                            var result = val1 / val2;
                            Console.WriteLine("{0} / {1} = {2}", val1, val2, result);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Option");
                            rightOption = false;
                            break;
                        }

                }



                do
                {
                    Console.WriteLine("Do you want to continue again (Y/N)?");
                    isContinue = Console.ReadLine();
                } while (isContinue.ToUpper() != "Y" && isContinue.ToUpper() != "N");


            } while (isContinue == "Y");
        }
    }
}
