using System;

namespace Experimental
{
	class MainClass : ParentClass
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
		public void SetCoordinate(int x, int y, int z)
		{
			X = x;
      Y = y;
      Z = z;
		}
		public void Print()
		{
			Console.WriteLine($"{X},{Y},{Z}");
		}
	}
	struct MainStruct
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
		public void SetCoordinates(int x, int y, int z)
		{
			X = x;
      Y = y;
      Z = z;
		}
		public void Print()
    {
      Console.WriteLine($"{X},{Y},{Z}");
    }
	}
	class ParentClass
	{
		public void Foo()
		{
			Console.WriteLine("Foo");
		}
		public void Bar()
    {
      Console.WriteLine("Bar");
    }
	}
}