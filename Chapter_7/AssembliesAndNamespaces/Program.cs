using System.Xml.Linq;
using Packt.Shared;
using static System.Console;

class Program
{
	public static void Main(string[] args)
	{
		Write("Enter a color value in hex: ");
		string? hex = ReadLine(); // или "00ffc8"
		WriteLine("Is {0} a valid color value? {1}",
		arg0: hex, arg1: hex.IsValidHex());
		Write("Enter a XML element: ");
		string? xmlTag = ReadLine(); // или "<h1 class=\"<\" />"
		WriteLine("Is {0} a valid XML element? {1}",
		arg0: xmlTag, arg1: xmlTag.IsValidXmlTag());
		Write("Enter a password: ");
		string? password = ReadLine(); // или "secretsauce"
		WriteLine("Is {0} a valid password? {1}",
		arg0: password, arg1: password.IsValidPassword());
	}
}