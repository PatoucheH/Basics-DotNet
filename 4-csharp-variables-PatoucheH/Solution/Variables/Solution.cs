using System;

namespace Variables
{
    public class Solution
    {
        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }

        public static float AgeToFloat(int age )
        {
            return age / 2.0f;
        }

        public static decimal CelciusToFarenheit(decimal celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double KilometersToMiles(double kilometers)
        {
            return Math.Round(kilometers * 0.621371, 1);
        }

        public static int ReturnRandomNumber()
        {
            return new Random().Next(1, 11);
        }
    }
}
