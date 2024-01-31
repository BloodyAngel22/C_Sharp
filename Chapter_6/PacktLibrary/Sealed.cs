using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktLibrary;

public sealed class Sealed
{
	public int x = 5;
}

public class NotSealed
{
	public virtual void Print()
	{
		System.Console.WriteLine("Not sealed method");
	}
}

public class SealedMethod : NotSealed
{
	public sealed override void Print()
	{
		System.Console.WriteLine("This is a sealed method");
	}
}

public class SonSealedMethod : SealedMethod
{
	// public override void Print() // error
	// {
	// 	System.Console.WriteLine("This is a son sealed method");
	// }
}

// public class TestSealed : Sealed // error. Sealed class is sealed