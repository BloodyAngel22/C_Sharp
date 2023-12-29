using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public class Pistol : Gun
	{
		public override int Damage => 15;
		public override void Fire()
		{
			Console.WriteLine("Pistol fired!");
		}
	}
}