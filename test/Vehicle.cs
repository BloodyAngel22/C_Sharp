using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	// public record Vehicle
	// {
	// 	public int Wheels { get; init; }
	// 	public string? Color { get; init; }
	// }

	public record Vehicle(int wheels, string color);
}