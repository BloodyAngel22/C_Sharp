using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class Student
    {
			private string _Name;
			private string _Surname;
			private string _Group;
			private Guid _Id; 
			private DateTime _Birthday;
			private Address _Address;

			public void Print(){
				System.Console.WriteLine("Info of student");
				System.Console.WriteLine($"ID: {_Id}");
				System.Console.WriteLine($"Surname: {_Surname}");
				System.Console.WriteLine($"Name: {_Name}");
				System.Console.WriteLine($"Group: {_Group}");
				System.Console.WriteLine($"Birthday: {_Birthday.Year}-{_Birthday.Month}-{_Birthday.Day}");
				System.Console.WriteLine($"Address: City: {_Address.City}, Street: {_Address.Street}");
			}
			public string GetFullName(){
				return $"FullName: {_Surname} {_Name}";
			}

			public Student(string Name, string Surname, string Group, DateTime Birthday){
				this._Name = Name;
				this._Surname = Surname;
				this._Group = Group;
				this._Id = Guid.NewGuid();
				this._Birthday = Birthday;
				this._Address = new Address
				{
					City = "Moscow",
          Street = "Leninskaya"
				};
			}
			public Student()
			{
				this._Name = "Student";
				this._Surname = "Surname";		
				this._Group = "Group";
				this._Id = Guid.NewGuid();
				this._Birthday = new DateTime(2000, 12, 6);
				this._Address = new Address{
					City = "Moscow",
          Street = "Leninskaya"
				};
			}
			public Student(Student student){
				this._Name = student._Name;
        this._Surname = student._Surname;
        this._Group = student._Group;
        this._Id = student._Id;
        this._Birthday = student._Birthday;
				this._Address = student._Address;
			}
			public void SetName(string Name){
        this._Name = Name;
      }
			public void SetSurname(string Surname){
        this._Surname = Surname;
      }
		}
}
