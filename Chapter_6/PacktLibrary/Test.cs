using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PacktLibrary;

public class Test1
{
	public int x;
	public Test1(int x)
	{
		this.x = x;
		System.Console.WriteLine(x);
	}
}

public class Test2 : Test1
{
	public int y;
	public Test2(int x, int y) : base(x)
	{
		this.y = y;
		System.Console.WriteLine();
	}
}