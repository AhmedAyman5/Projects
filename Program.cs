using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1__Prime_numbers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" - Please enter first number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("\n - Please enter second number : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("\n - Prime numbers between " + n1 + " and " + n2 + " are : ");

            for (int i = n1; i <= n2; i++)
            {

                if (i == 0 || i == 1)
                {
                    continue;
                }

                int x = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        x = 0;
                        break;
                    }
                }

                if (x == 1)
                {
                    Console.Write(" " + i + " ,");
                }
            }
            Console.ReadKey();
        }
    }
}
