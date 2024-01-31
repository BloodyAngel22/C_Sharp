namespace CalculatorLib;

public class Calculator 
{
	double storage = 0.0;	

	public Calculator()
	{
		System.Console.WriteLine("Welcome to Calculator");
	}
	public double Add(double value1, double value2)
	{
		storage = value1;
		storage += value2;
		return storage;
	}
	public double Sub(double value1, double value2)
	{
		storage = value1;
		storage -= value2;
		return storage;
	}
	public double Mul(double value1, double value2)
	{
		storage = value1;
		storage *= value2;
		return storage;
	}
	public double Divide(double value1, double value2)
	{
		storage = value1;
		storage /= value2;
		return storage;
	}
	public double DegreeConvert(double value1, double value2)
	{
		storage = value1;
		storage = Math.Pow(storage, value2);
		return storage;
	}
	public double Sqrt(double value1)
	{
		storage = value1;
		return storage = Math.Sqrt(storage);
	}
	public void PrintResults()
	{
		System.Console.WriteLine(format: "Results: {0}", storage);
	}
	public void Reset()
	{
		storage = 0.0;
	}
	public double Results { get => storage; }
}
