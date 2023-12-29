using System;

namespace myClass
{
	public class Person
	{
		public Person(string Name, string Surname, string MiddleName)
		{
			this.Name = Name;
			this.Surname = Surname;
			this.MiddleName = MiddleName;
		}
		public string Name { get; set; }
		public string MiddleName { get; set; }
		public string Surname { get; set; }
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
	}
}