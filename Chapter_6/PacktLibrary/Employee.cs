using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktLibrary
{
	public class Employee : Person
	{
		public string? EmployeeId { get; set; }
		public DateTime HireDate { get; set; }
		public new void PrintInfo()
		{
			System.Console.WriteLine(format: "Name {0}, Id {1}, Hire Date {2:dd/MM/yyyy}", Name, EmployeeId, HireDate);
		}
	}
}