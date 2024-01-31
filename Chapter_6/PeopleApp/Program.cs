using static System.Console;
using PacktLibrary;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic;

class Program
{
	public delegate int WordLengthDelegate(string word);
	public static void Main(string[] args)
	{
		Person harry = new()
		{
			Name = "Harry",
		};
		// Person mary = new()
		// {
		// 	Name = "Marry"
		// };
		// Person jill = new()
		// {
		// 	Name = "Jill"
		// };

		// Person baby1 = mary.ProcreateWith(harry);
		// baby1.Name = "Gary";
		// Person baby2 = Person.Procreate(harry, jill);
		// Person baby3 = harry * mary;

		// WriteLine($"{harry.Name} has {harry.Children.Count} children.");
		// WriteLine($"{mary.Name} has {mary.Children.Count} children.");
		// WriteLine($"{jill.Name} has {jill.Children.Count} children.");

		// System.Console.WriteLine("Harry's children");
		// foreach (var children in harry.Children)
		// {
		// 	System.Console.WriteLine(children.Name);	
		// }

		// WordLengthDelegate wld = new(WordLength);
		// int result = wld("Harry's children");
		// System.Console.WriteLine(result);

		// harry.Shout += Harry_Shout;
		// harry.Poke();
		// harry.Poke();
		// harry.Poke();
		// harry.Poke();
		// harry.Poke();

		// System.Collections.Hashtable lookupObject = new();
		// lookupObject.Add(1, "Alpha");
		// lookupObject.Add(2, "Beta");
		// lookupObject.Add(3, "Gamma");
		// lookupObject.Add(harry, "Delta");
		// System.Console.WriteLine(format:"Key: {0} has value: {1}", 2, lookupObject[2]);
		// System.Console.WriteLine(format:"Key: {0} has value: {1}", harry, lookupObject[harry]);

		// Dictionary<int, string> lookupIntString = new();
		// lookupIntString.Add(1, "Alpha");
		// lookupIntString.Add(2, "Beta");
		// lookupIntString.Add(3, "Gamma");
		// // lookupIntString.Add(harry, "Delta"); // error
		// lookupIntString.Add(4, "Delta"); // error
		// foreach (var item in lookupIntString)
		// {
		// 	System.Console.WriteLine(format:"Key: {0} has value: {1}", item.Key, item.Value);	
		// }

		// Person[] people =
		// {
		// 	new() { Name = "Simon"},
		// 	new() { Name = "Jenny"},
		// 	new() { Name = "Adam"},
		// 	new() { Name = "Richard"},
		// };

		// System.Console.WriteLine("Initial list of people");
		// foreach (var item in people)
		// {
		// 	System.Console.WriteLine(item.Name);			
		// }
		// Array.Sort(people, new PersonComparer());
		// System.Console.WriteLine("Sorted list of people");
		// foreach (var item in people)
		// {
		// 	System.Console.WriteLine(item.Name);			
		// }
		// Person p1 = new()
		// {
		// 	Name = "Adam"
		// };
		// Person p2 = new()
		// {
		// 	Name = "Adam"
		// };
		// System.Console.WriteLine(p1 == p2);//false

		// RecordPerson rp1 = new()
		// {
		// 	Name = "Adam"
		// };
		// RecordPerson rp2 = new()
		// {
		// 	Name = "Adam"
		// };
		// System.Console.WriteLine(rp1 == rp2);//true

		// DisplacementVector v1 = new(7, 5);
		// DisplacementVector v2 = new(-2, 12);
		// DisplacementVector v3 = v1 + v2;
		// System.Console.WriteLine(format:"x: {0}, y: {1}", v3.X, v3.Y);

		// Employee e1 = new()
		// {
		// 	Name = "Adam",
		// 	EmployeeId = "0-3217-44",
		// 	HireDate = new(2018, 7, 24)
		// };
		// e1.PrintInfo();
		// System.Console.WriteLine(e1.ToString());

		Person aliceInPerson = new Employee()
		{
			Name = "Alice",
			EmployeeId = "2-3208-42",
		};

		// if (aliceInPerson is Employee explicitAlice )
		// {
		// 	System.Console.WriteLine(nameof(aliceInPerson) + " is an employee");
		// 	string? name = explicitAlice.Name;
		// 	System.Console.WriteLine(name);
		// }

		// Employee? aliceAsEmployee = aliceInPerson as Employee;
		// if (aliceAsEmployee != null)
		// {
		// 	System.Console.WriteLine(nameof(aliceInPerson) + " as an employee");
		// }

		// Person john = new()
		// {
		// 	Name = "John",
		// 	DateOfBirth = new(2004, 12, 3),
		// };
		// try
		// {
		// 	john.TimeTravel(when: new(2005, 10, 12));
		// }
		// catch(PersonException ex)
		// {
		// 	System.Console.WriteLine(ex.Message);
		// }

		string email1 = "person@example.com";
		System.Console.WriteLine(format: "Email: {0} is valid: {1}", email1, StringExtensions.IsValidEmail(email1));

		string email2 = "per**son&index.com";
		System.Console.WriteLine(format: "Email: {0} is valid: {1}", email2, email2.IsValidEmail());
	}
	public static int WordLength(string message)
	{
		return message.Length;
	}
	public static void Harry_Shout(object? sender, EventArgs e)
	{
		if (sender is null)
			return;
		Person p = (Person)sender;
		System.Console.WriteLine(format:"{0} is this angry: {1}", p.Name, p.AngerLevel);
	}
}