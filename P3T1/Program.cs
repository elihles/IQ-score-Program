using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("What is your IQ score:");
            num1 = Convert.ToInt32(Console.ReadLine());
            if ((num1 < 0 || num1 > 200))
                Console.WriteLine("invalid IQ value");
            else
            {
                if (num1 < 100)
                    Console.WriteLine("IQ is below average");
                else
                {
                    if (num1 == 100)
                        Console.WriteLine(" IQ is average");
                    else
                    {
                        if (num1 > 100)
                            Console.WriteLine("IQ is Above average");

                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
