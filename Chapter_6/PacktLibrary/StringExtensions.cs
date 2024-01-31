using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PacktLibrary;

public static class StringExtensions
{
	public static bool IsValidEmail(this string email)
	{
		return Regex.IsMatch(email, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
	}
}