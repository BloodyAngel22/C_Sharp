using System;
using Microsoft.Extensions.Configuration;
using test;

namespace myClass
{
	public class Person
	{
		public Person()
		{
			Name = "Name";
			Surname = "Surname";
			MiddleName = "MiddleName";
		}
		public Person(string Name, string Surname, string MiddleName)
		{
			this.Name = Name;
			this.Surname = Surname;
			this.MiddleName = MiddleName;
		}
		public string Name { get; init; }
		public string MiddleName { get; set; }
		public string Surname { get; init; }
		public DateTime dateOfBirth;
		public WondersOfTheAncientWorld favoriteAncientWonder;
		public List<WondersOfTheAncientWorld> bucketList = new();
		public static readonly string homePlanet = "Earth";
		public List<Person> children = new();
		public string GetFullName(bool enablePrint = false)
		{
			if (enablePrint)
			{
				string full_data = "Фамилия: {0}, Имя: {1}, Отчество: {2}";
				System.Console.WriteLine(full_data, Surname, Name, MiddleName);
			}
			return Surname + " " + Name + " " + MiddleName;
		}
		public void Print()
    {
      System.Console.WriteLine($"Фамилия: {Surname}, Имя: {Name}, Отчество: {MiddleName}");
    }
		public void PrintFullInfo()
		{
			System.Console.WriteLine($"{Name} {Surname} {MiddleName} {dateOfBirth:dd MMM yyyy} favoriteAncientWonder: {favoriteAncientWonder}");
			System.Console.WriteLine("Bucket List: ");
			foreach (var item in bucketList)
			{
				System.Console.Write(item + ", ");	
			}
			System.Console.WriteLine();
		}
		public (string name, WondersOfTheAncientWorld favoriteAncientWonder) GetNameAndAncientWorld()
		{
			return (Name, this.favoriteAncientWonder);
		}
		public void Deconstruct(out string name, out DateTime dateOfBirth)
		{
			name = Name;
			dateOfBirth = this.dateOfBirth;
		}
		public Person this[int index]
		{
			get
			{
				return children[index];
			}
			set
			{
				children[index] = value;
			}
		}
	}
}