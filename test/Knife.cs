using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public class Knife : IThrowWeapon
	{
		public int Damage => 10;

		public void Fire()
		{
			System.Console.WriteLine("Knife attack!");
		}

		public void Throw()
		{
			System.Console.WriteLine("Knife throw!");
		}
	}
}