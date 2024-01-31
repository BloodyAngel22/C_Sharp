namespace PacktLibrary;

public class Person : Object, IComparable<Person>
{
	public string? Name;
	public DateTime DateOfBirth;
	public List<Person> Children = new();
	public event EventHandler? Shout;
	public int AngerLevel;

	public void PrintInfo()
	{
		System.Console.WriteLine(format:"{0} was born from {1:dddd}", Name, DateOfBirth);
	}
	public static Person Procreate(Person p1, Person p2)
	{
		Person baby = new()
		{
			Name = $"Babe of {p1.Name} and {p2.Name}"
		};
		p1.Children.Add(baby);
		p2.Children.Add(baby);

		return baby;
	}
	public Person ProcreateWith(Person patrner)
	{
		return Procreate(this, patrner);
	}
	public static Person operator *(Person p1, Person p2)
	{
		return Procreate(p1, p2);
	}
	public void Poke()
	{
		AngerLevel++;
		if (AngerLevel >= 3)
		{
			// if (Shout != null)
			// {
			// 	Shout(this, EventArgs.Empty);
			// }
			Shout?.Invoke(this, EventArgs.Empty);
		}
	}

	public int CompareTo(Person? other)
	{
		if (Name is null) return 0;
		return Name.CompareTo(other?.Name);
	}
	public override string ToString()
	{
		return $"{Name} is a {base.ToString()}";
	}

	public void TimeTravel(DateTime when)
	{
		if (when <= DateOfBirth)
		{
			throw new PersonException("If you travel back in time to a date earlier than your own birth, then the universe will explode!");
		}
		else
		{
			System.Console.WriteLine("Welcome to " + when.Year);
		}
	}
}
