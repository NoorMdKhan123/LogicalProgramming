using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1; i<num; i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("Number is perfect number");
            }
            else
            {
                Console.WriteLine("Number is not prime number");
            }
        }
    }
}
