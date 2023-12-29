using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public class Shotgun : Gun
	{
		public override int Damage => 10;
		public override void Fire()
    {
			System.Console.WriteLine("Shotgun fired!");
    }
	}
}