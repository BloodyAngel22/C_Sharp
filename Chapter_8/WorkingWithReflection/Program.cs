using System.Reflection;
using System.Runtime.CompilerServices;
using WorkingWithReflection;

class Program
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Assembly metadata: ");
		Assembly? assembly = Assembly.GetEntryAssembly();
		if (assembly is null)
		{
			System.Console.WriteLine("Failed to get entry assembly");
			return;
		}

		System.Console.WriteLine("Full name {0}", assembly.FullName);
		System.Console.WriteLine("Location {0}", assembly.Location);

		IEnumerable<Attribute> attributes = assembly.GetCustomAttributes();
		System.Console.WriteLine("Assembly attributes");
		foreach (var attribute in attributes)
		{
			System.Console.WriteLine(attribute.GetType());	
		}

		AssemblyInformationalVersionAttribute? versionAttribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
		System.Console.WriteLine("Version {0}", versionAttribute?.InformationalVersion);
		AssemblyCompanyAttribute? company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
		System.Console.WriteLine("Company {0}", company?.Company);

		System.Console.WriteLine("* Types:");
		Type[] types = assembly.GetTypes();
		foreach (var type in types)
		{
			System.Console.WriteLine();	
			System.Console.WriteLine("Type {0}", type.FullName);
			MemberInfo[] members = type.GetMembers();

			foreach (var member in members)
			{
				System.Console.WriteLine("{0}: {1} ({2})", member.MemberType, member.Name, member.DeclaringType?.Name);

				IOrderedEnumerable<CoderAttribute> coders = member.GetCustomAttributes<CoderAttribute>().OrderByDescending(c => c.LastModified);

				foreach (var coder in coders)
				{
					System.Console.WriteLine("-> Modified by {0} on {1}", coder.Coder, coder.LastModified.ToShortDateString());	
				}
			}
		}
	}
}

class Animal
{
	[Coder ("BloodyAngel22", "30.01.2024")]
	public void Speak()
	{
		System.Console.WriteLine("Woof...");
	}
}