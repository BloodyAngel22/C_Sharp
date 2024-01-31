using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktLibrary
{
	public struct DisplacementVector // use struct if size doesn't greater than 16 bytes, uses value types and isn't inherited
	{
		public int X;
		public int Y;
		public DisplacementVector(int x, int y)
		{
			X = x;
			Y = y;
		}
		public static DisplacementVector operator +(DisplacementVector left, DisplacementVector right)
		{
			return new (left.X + right.X, left.Y + right.Y);
		}
	}
}