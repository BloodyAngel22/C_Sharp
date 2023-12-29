using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public class Minigun : Gun
	{
		public override int Damage => 5;
		public override void Fire()
		{
			System.Console.WriteLine("Minigun fired!");
		}
	}
}