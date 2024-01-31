using Packt;
using Xunit;

namespace CalculatorLibUnitTests
{
	public class CalculatorUnitTests
	{
		[Fact]
		public void Adding2And2()
		{
			//input data
			double a = 2;
			double b = 2;

			//expected data
			double expected = 4;

			//test data
			Calculator calc = new();
			double actual = calc.Add(a, b);

			//check result
			Assert.Equal(expected, actual);
		}
		[Fact]
		public void Adding2And3()
		{
			//input data
			double a = 2;
			double b = 3;

			//expected data
			double expected = 5;

			//test data
			Calculator calc = new();
			double actual = calc.Add(a, b);

			//check result
			Assert.Equal(expected, actual);
		}
	}
}