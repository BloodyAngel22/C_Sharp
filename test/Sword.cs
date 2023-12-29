using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public class Sword : IInfo, IWeapon
	{
		public int Damage => 20;

		public void Fire()
		{
			System.Console.WriteLine("Sword attacked!");
		}

		public void GetInfo()
		{
			System.Console.WriteLine(GetType().Name);
			System.Console.WriteLine("Damage: " + Damage);
		}
	}
}