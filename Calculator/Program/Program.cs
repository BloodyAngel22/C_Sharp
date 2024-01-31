using CalculatorLib;

class Program
{
	public static void Main(string[] args)
	{
		Calculator model = new();
		bool isRunning = true;
		bool isFirst = true;
		bool correctSign;
		while (isRunning)
		{
			System.Console.WriteLine("Enter sign. +, -, *, /, **, sqrt, r (reset), q (quit)");
			string? sign = null;
			do
			{
				sign = Console.ReadLine();
				correctSign = IsCorrect(sign);
				if (!correctSign)
					System.Console.WriteLine("Invalid sign. Please try again");
			} while (!correctSign);

			double a, b;
			a = b = 0.0;
			a = model.Results;
			if (sign != "q" && sign != "r")
			{
				if (isFirst)
				{
					System.Console.Write("Enter first value: ");
					a = Convert.ToDouble(Console.ReadLine());
					isFirst = false;
				}
				if (sign != "sqrt"){
					System.Console.Write("Enter second value: ");
					b = Convert.ToDouble(Console.ReadLine());
				}
			}

			switch (sign)
			{
				case "+":
					model.Add(a, b);
					break;
				case "-":
					model.Sub(a, b);
					break;
				case "*":
					model.Mul(a, b);
					break;
				case "/":
					model.Divide(a, b);
					break;
				case "**":
					model.DegreeConvert(a, b);
					break;
				case "sqrt":
					model.Sqrt(a);
					break;
				case "r":
					model.Reset();
					break;
				case "q":
					isRunning = false;
					break;
			}
			System.Console.WriteLine(format: "Result: {0}", model.Results);
		}
	}
	public static bool IsCorrect(string message)
	{
		string[] signs = ["+", "*", "-", "/", "r", "q", "**", "sqrt"];

		foreach (var sign in signs)
		{
			if (sign == message)
				return true;
		}

		return false;
	}
}