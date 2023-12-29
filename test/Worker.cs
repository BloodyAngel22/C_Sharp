using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myClass;

namespace test
{
    public class Worker : Person
    {
			public Guid _IdCard; 
			public Worker(string Name, string Surname, string MiddleName) : base(Name, Surname, MiddleName)
			{
        this.Name = Name;
				this.Surname = Surname;
				this.MiddleName = MiddleName;
				this._IdCard = Guid.NewGuid();
			}
			public void Print(){
				base.Print();
				System.Console.WriteLine($"IdCard: {_IdCard}");
			}
    }
}