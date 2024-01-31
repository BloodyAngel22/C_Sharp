using System.Diagnostics;
using static System.Console;

class Program
{
	public static void Main(string[] args)
	{
		Stopwatch watch = new();
		System.Console.WriteLine("Press Enter to start");
		ReadLine();
		watch.Start();

		int max = 45;
		IEnumerable<int> numbers = Enumerable.Range(1, max);
		System.Console.WriteLine("Calculating Fibonacci numbers...");
		int[] fibonacciNumbers = numbers.AsParallel()
			.Select(number => Fibonacci(number))
			.OrderBy(number => number)
			.ToArray();

		watch.Stop();
		System.Console.WriteLine("{0:#,##0} elapsed seconds", watch.Elapsed.TotalSeconds);

		System.Console.WriteLine("Results:");
		foreach (var item in fibonacciNumbers)
		{
			System.Console.WriteLine(" {0}", item);	
		}
	}
	public static int Fibonacci(int term) => term switch
	{
		1 => 0,
		2 => 1,
		_ => Fibonacci(term - 1) + Fibonacci(term - 2)
	};
}