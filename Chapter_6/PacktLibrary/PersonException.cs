using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktLibrary;

public class PersonException : Exception
{
	public PersonException() : base() { }
	public PersonException(string message) : base(message) { }
	public PersonException(string message, Exception inner) : base(message, inner) {}
}