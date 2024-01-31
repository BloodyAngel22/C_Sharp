using System.Collections.Immutable;

class Program
{
	public static void Output(string title, IEnumerable<string> collection)
	{
		System.Console.WriteLine(title);
		foreach (var item in collection)
		{
			System.Console.WriteLine(" "+item);
		}
	}
	public static void WorkingWithLists()
	{
		List<string> cities = ["London", "Paris", "Milan"];

		// Output("List of cities", cities);
		// System.Console.WriteLine(format: "The first cities {0}", cities[0]);
		// System.Console.WriteLine(format: "The last cities {0}", cities[cities.Count - 1]);
		// System.Console.WriteLine(format: "The last cities {0}", cities[^1]);
		// cities.Insert(0, "Sidney");
		// Output("After inserting Sidney", cities);
		// cities.RemoveAt(1);
		// cities.Remove("Milan");
		// Output("After removing two cities", cities);

		// ImmutableList<string> immutableCities = cities.ToImmutableList();
		ImmutableList<string> immutableCities = [.. cities];
		ImmutableList<string> newList = immutableCities.Add("Rio");
		immutableCities.Add("Moscow");
		immutableCities.Add("Bryansk");

		Output("Immutable Cities", immutableCities);
		Output("New List", newList);
	}
	public static void WorkingWithDictionaries()
	{
		Dictionary<string, string> keywords = new()
		{
			["int"] = "32-bit integer data type",
			["long"] = "64-bit integer data type",
			["float"] = "Single precision floating point number"
		};

		Output("Dictionary keys", keywords.Keys);
		Output("Dictionary values", keywords.Values);

		string key = "long";
		System.Console.WriteLine(keywords[key]);
	}
	public static void WorkingWithQueues()
	{
		Queue<string> coffee = new();
		coffee.Enqueue("Damir");
		coffee.Enqueue("Andrea");
		coffee.Enqueue("Roland");
		coffee.Enqueue("Amin");
		coffee.Enqueue("Irina");

		Output("Initial queue", coffee);
		System.Console.WriteLine(coffee.Dequeue());
		System.Console.WriteLine(coffee.Dequeue());

		Output("Current queue", coffee);

		System.Console.WriteLine(coffee.Peek());

		Output("Current queue", coffee);
	}
	public static void OutputPQ<TElement, TPriority> (string title, IEnumerable<(TElement Element, TPriority Priority)> collection)
	{
		System.Console.WriteLine(title);
		foreach (var item in collection)
		{
			System.Console.WriteLine(format: "{0}: {1}", item.Element, item.Priority);	
		}
	}
	public static void WorkingWithPriorityQueues()
	{
		PriorityQueue<string, int> vaccine = new();
		vaccine.Enqueue("Pamela", 1);
		vaccine.Enqueue("Rebecca", 3);
		vaccine.Enqueue("Juliet", 2);
		vaccine.Enqueue("Ian", 1);

		OutputPQ("Current queue", vaccine.UnorderedItems);
	}
	public static void Main(string[] args)
	{
		// List<string> names = [];
		// names.EnsureCapacity(10);
		// for (int i = 0; i < 10; i++)
		// {
		// 	System.Console.WriteLine(format: "Capacity: {0}",names.Capacity);
		// 	System.Console.WriteLine(format: "Current Size: {0}", names.Count);
		// 	string name = "John";
		// 	names.Add(name);
		// }
		// System.Console.WriteLine(format: "Capacity: {0}", names.Capacity);
		// System.Console.WriteLine(format: "Current Size: {0}", names.Count);

		// Dictionary<uint, string> names = [];
		// for (uint i = 0; i < 10; i++)
		// {
		// 	names.Add(i+1, "John");	
		// }

		// names[2] = "Alan";
		// names[11] = "Max";
		// foreach (var name in names)
		// {
		// 	System.Console.WriteLine(name);	
		// }
		// System.Console.WriteLine(names[2]);

		WorkingWithLists();
		// WorkingWithDictionaries();
		// WorkingWithQueues();
		// WorkingWithPriorityQueues();

	}
}