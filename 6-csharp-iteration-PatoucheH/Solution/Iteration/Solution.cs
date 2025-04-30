using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    public class Solution
    {
        public static int SumOfNumbers()
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Negative numbers don't have factorials.");
            }
            else
            {
                int result = 1;
                int counter = 1;
                while (counter <= n)
                {
                    result *= counter;
                    counter++;
                }
                return result;
            }
        }

        public static void MultiplicationTableNumber()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }

        public static void EnterGoodNumber()
        {
            int result;
            do
            {
                Console.WriteLine("Enter a number between 1 and 10 : ");
                result = Convert.ToInt32(Console.ReadLine());
            } while (result < 1 || result > 10);
            Console.WriteLine(result);
        }

        public static void GetSmallestNumber()
        {
            List<int> numbers = new List<int>();
            int number;
            {
                Console.WriteLine("Enter an integer above 0 or 0 to stop : ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number != 0) numbers.Add(number);
            } while (number != 0) ;

            Console.WriteLine($"The smallet number is : {numbers.Min()}");
        }
    }
}
