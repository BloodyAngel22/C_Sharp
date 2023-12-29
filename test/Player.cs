using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public class Player
	{
		public void Fire(IWeapon gun)
		{
			gun.Fire();
		}
		public void CheckGun(Gun gun)
		{
			gun.GetInfo();
		}
		public void WeaponInfo(IInfo info)
		{
			info.GetInfo();
		}
		public void Throw(IThrowWeapon weapon){
			weapon.Throw();
		}

	}
}