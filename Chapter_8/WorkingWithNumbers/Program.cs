using System.Numerics;

class Program
{
	public static void Main(string[] args)
	{
		// ulong big = ulong.MaxValue;
		// System.Console.WriteLine(format: "{0,50:N0}", big);
		// BigInteger bigger = BigInteger.Parse("123456789012345678901234567890");
		// System.Console.WriteLine(format: "{0,50:N0}", bigger);

		Complex c1 = new(real: 4, imaginary: 2);
		Complex c2 = new(real: 3, imaginary: 7);
		Complex c3 = c1 + c2;
		System.Console.WriteLine(format: "{0} + {1} = {2}", c1, c2, c3);
	}
}