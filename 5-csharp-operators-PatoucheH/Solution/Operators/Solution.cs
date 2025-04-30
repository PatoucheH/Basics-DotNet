using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Solution
    {
        public static string IsAdult(int age)
        {
            return age > 18 ? "You are an adult" : "You are a child";
        }

        public static string EvenOrOdd(int number){
            return number % 2 == 0 ? "Even" : "Odd";
        }

        public static int Add(int n1, int n2){
            return n1 + n2;
        }

        public static int Max(int n1, int n2){
             return Math.Max(n1, n2);
        }
    }
}
