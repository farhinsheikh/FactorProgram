using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeFactorProgram
{
    //created class Factor
    class Factor
    {
        //PrimeFactors() method to find prime factors
        public static void PrimeFactors()
        {
            Console.WriteLine("Enter the number");
            // converting string value to int
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Factors=");
            // for loop iterates to the given number
            for (int i = 2; i * i <= number; i++)
            {
                // checking for perfect divisible value
                while (number % i == 0)
                {                       
                    Console.Write(i + " ");

                    number = number / i;
                }
            }
            //// if number is prime and above 1 then it types the number 
            if (number > 1)
            {
                Console.Write(number);
            }

            Console.WriteLine();
        }
    }
}

    

