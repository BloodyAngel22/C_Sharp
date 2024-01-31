class Program
{
	public static void Main(string[] args)
	{
		string name = "Samantha Jones";

		int lengthOfFirst = name.IndexOf(' ');
		int lengthOfLast = name.Length - lengthOfFirst - 1;

		ReadOnlySpan<char> nameAsSpan = name.AsSpan();
		ReadOnlySpan<char> firstNameSpan = nameAsSpan[0..lengthOfFirst];
		ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lengthOfLast..^0];
		System.Console.WriteLine("First name: {0}, Last name: {1}",
		arg0: firstNameSpan.ToString(),
		arg1: lastNameSpan.ToString());
	}
}