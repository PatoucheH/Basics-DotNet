namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your age : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.IsAdult(number));
            Console.WriteLine(Solution.EvenOrOdd(number));
            Console.WriteLine(Solution.Add(10, number));
            Console.WriteLine(Solution.Max(10, number));
        }
    }
}
