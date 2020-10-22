using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum=0;
            int n;
            Console.Write("enter a Number: ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number;i++)
            {
                if (number % i == 0)
                {
                    sum=sum + i;
                }
            }
                if (sum == n)
                {
                    Console.WriteLine("\n Entered number is a perfect number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\n Entered number is not a perfect number");
                    Console.ReadLine();
                }
            }
        }
    }

