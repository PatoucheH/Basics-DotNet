namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.SumOfNumbers());
            Console.WriteLine("Enter a number to display its factorials : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Solution.Factorial(n));
            Solution.MultiplicationTableNumber();
            Solution.EnterGoodNumber();
            Solution.GetSmallestNumber();
            Console.ReadLine();
        }
    }
}
