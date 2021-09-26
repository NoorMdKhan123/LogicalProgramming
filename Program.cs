using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0, num2=1, num3;
            Console.WriteLine("Enter the number of elements");
          int number = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2  +" ");
            for(int i = 2; i<number; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;

            }

        }
    }
}
