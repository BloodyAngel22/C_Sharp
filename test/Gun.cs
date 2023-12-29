using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	abstract public class Gun : IInfo, IWeapon
	{
		abstract public int Damage { get; }
		abstract public void Fire();
		public void GetInfo()
		{
			System.Console.WriteLine(GetType().Name);
			System.Console.WriteLine("Damage: " + Damage);
		}
	}
}