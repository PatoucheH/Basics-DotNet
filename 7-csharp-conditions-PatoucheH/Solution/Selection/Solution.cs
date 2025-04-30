using System;

namespace Selection
{
    public class Solution
    {

        public static int GetValidatedAge(string userEnter)
        {
            try
            {
                var number = int.Parse(userEnter);
                if (number < 0 || number > 110) throw new FormatException("Invalid Age");
                else return number;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Age");
            }

        }

        public static string CanEnterInTheCasino()
        {
            try
            {
                Console.WriteLine("Enter you age : ");
                int age = GetValidatedAge(Console.ReadLine());

                if (age >= 18) return "You can enter! Be welcome!";
                else return "Sorry, you can't enter! Be patient!";
            }
            catch (FormatException)
            {
                return "Invalid Age";
            }
            catch (Exception)
            {
                return "Invalid Age";
            }

        }

        public static string SignOfNumber(int number)
        {

            if (number > 0) return "The number is positive.";
            else if (number < 0) return "The number is negative.";
            else return "The number is zero.";
        }


        public static double DiscountPriceCalculator(int discount, double price)
        {
            if (discount == 1) return price * 0.9;
            else if (discount == 2) return price * 0.95;
            else if (discount == 3) return price * 0.80;
            else throw new ArgumentException("Invalid choice. Please enter a number between 1 and 3.");


        }


        public static string TriangleClassification(double c1, double c2, double c3)
        {
            if (c1 != c2 && c2 != c3 && c3 != c1) return "The triangle is scalene.";
            else if (c1 == c2 && c2 == c3) return "The triangle is equilateral.";
            else return "The triangle is isosceles.";
        }

    }
}
