using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public partial class Point2D
	{
		public void Print()
		{
			Console.WriteLine($"X: {_x} Y: {_y}");
			Console.WriteLine($"ID: {curId}");
		}

	}
}