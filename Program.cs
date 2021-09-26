using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check prime");
            int num = int.Parse(Console.ReadLine());
            int temp = 0;
            for( int i=2 ; i<num-1 ; i++)
            {
                if(num%i == 0)
                {
                    temp += 1;
                }
            }
            if(temp > 0)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not prime number");

            }

        }
    }
}
