using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any following key");
            Console.ReadLine();
            Console.WriteLine("Enter Total Students :");

            try
            {
                int studentNumber = Convert.ToInt32(Console.ReadLine());
                string[,] students = new string[2, 4];

                for (int i = 0; i < studentNumber; i++)
                {
                    Console.WriteLine("Enter Student Name : ");
                    var name= Console.ReadLine();
                    students[i, 0] = name;
                    Console.WriteLine("Enter English Marks (Out Of 100) : ");
                    var eMarks = Console.ReadLine();
                    students[i, 1] = eMarks;
                    Console.WriteLine("Enter Math Marks (Out Of 100) : ");
                    var mMarks= Console.ReadLine();
                    students[i, 2] = mMarks;
                    Console.WriteLine("Enter Computer Marks (Out Of 100) : ");
                    var cMarks = Console.ReadLine();
                    students[i, 3] = cMarks;
                    if ((i + 1) < studentNumber)
                    {
                        Console.WriteLine("*********************************************");
                    }
                }

                Console.WriteLine("****************Report Card*******************");
                Console.WriteLine("****************************************");
                for (int i = studentNumber-1; i > -1; i--)
                {
                    var position = studentNumber - i;
                    var total = Convert.ToInt32(students[i, 1]) + Convert.ToInt32(students[i, 2]) + Convert.ToInt32(students[i, 3]);
                    Console.WriteLine("Student Name: {0}, Position: {1}, Total: {2} / 300", students[i,0], position.ToString(), total.ToString());
                    Console.WriteLine("****************************************");
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            
            



        }
    }
}
