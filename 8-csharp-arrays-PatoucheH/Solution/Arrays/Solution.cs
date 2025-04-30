using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Solution
    {
            public static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 11);
            }

            foreach (int n in array)
            {
                Console.WriteLine(n);
            }
            return array;
        }

        public static int Sum(int[] numbers)
        {
            int result = 0;
            foreach (int n in numbers)
            {
                result += n;
            }
            return result;
        }

        public static double Average(int[] numbers)
        {
            double result = 0;
            foreach (int n in numbers)
            {
                result += n;
            }
            return result / numbers.Length;
        }


        public static void MaxAndMin(int[] numbers,out int max,out int min)
        {
            max = numbers[0];
            min = numbers[0];

            foreach (int n in numbers)
            {
                if (n > max) max = n;
                if (n < min) min = n;
            }
        }


        public static int[] SortAndArray(int[] numbers)
        {
            Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            return numbers;
        }


        public static string Palindrome(int[] numbers)
        {

            int[] reversedArray = (int[])numbers.Clone();
            Array.Reverse(reversedArray);
            if (numbers.SequenceEqual(reversedArray))
            {
                return "The array is a palindrome";
            }
            else
            {
                return "The array is not a palindrome";
            }
        }

    }
}
