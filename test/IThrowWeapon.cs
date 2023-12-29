using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public interface IThrowWeapon : IWeapon
	{
		public void Throw();
	}
}