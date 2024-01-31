class Program
{
	public static void Output(IEnumerable<string> cohort, string description ="")
	{
		if (!string.IsNullOrEmpty(description))
		{
			System.Console.WriteLine(description);
		}
		System.Console.Write(" ");
		System.Console.WriteLine(string.Join(", ", cohort.ToArray()));
		System.Console.WriteLine();
	}
	public static void Main(string[] args)
	{
		string[] cohort1 = new[]
		{ "Rachel", "Gareth", "Jonathan", "George" };
		string[] cohort2 = new[]
		{ "Jack", "Stephen", "Daniel", "Jack", "Jared" };
		string[] cohort3 = new[]
		{ "Declan", "Jack", "Jack", "Jasmine", "Conor" };

		Output(cohort1, "Cohort 1");
		Output(cohort2, "Cohort 2");
		Output(cohort3, "Cohort 3");

		Output(cohort2.Distinct(), "Cohort 2 Distinct");
	}
}