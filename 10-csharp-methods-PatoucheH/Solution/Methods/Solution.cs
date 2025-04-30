using System;

namespace Methods
{
  public class Solution
  {
    public static int Sum(int x, int y)
    {
      return x + y;
    }

    public static string Whos(string firstName, string lastName, int age)
    {
      return $"Firstname : {firstName}\nLastname : {lastName}\nAge : {age}";
    }

    public static void SumAndProduct(int x, int y, out int sum, out int product)
    {
      sum = x + y;
      product = x * y;
    }

    public static (int quotient, int remainder) QuotientAndRemainder(int x, int y)
    {
      int quotient = x / y;
      int remainder = x % y;
      return (quotient, remainder); 
    }

    public static int MethodWithDefaultValue(int n = 10)
    {
      return n * 2;
    }

  }
}