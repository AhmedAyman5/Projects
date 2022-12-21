using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1__perfect_numbers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" - Please enter first number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("\n - Please enter first number : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("\n - Perfect numbers between " + n1 + " and " + n2 + " are : ");

            for (int i = n1; i <= n2; i++)
            {

                int sum = 0;
                for (int j = 1; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        sum += j;
                    }

                }

                if (sum == i)
                {

                    Console.Write(" " + i + " ,");
                }

            }
            Console.ReadKey();
        }
    }
}
