using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public interface IWeapon
	{
		public int Damage { get; }
		public void Fire();
	}
}