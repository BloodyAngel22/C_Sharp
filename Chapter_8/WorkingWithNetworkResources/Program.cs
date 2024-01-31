using System.Net;
using System.Net.NetworkInformation;

class Program
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Enter a valid web address");
		string? address = System.Console.ReadLine();

		if (string.IsNullOrEmpty(address))
		{
			address = "https://stackoverflow.com/search?q=securestring";
		}

		Uri uri = new(address);
		System.Console.WriteLine("Address: " + address);
		System.Console.WriteLine(uri.Scheme);
		System.Console.WriteLine(uri.Port);
		System.Console.WriteLine(uri.Host);
		System.Console.WriteLine(uri.AbsolutePath);
		System.Console.WriteLine(uri.Query);

		IPHostEntry ipEntry = Dns.GetHostEntry(uri.Host);
		System.Console.WriteLine("IP address: {0}", ipEntry.HostName);
		foreach (var _address in ipEntry.AddressList)
		{
			System.Console.WriteLine("{0} :({1})", _address, _address.AddressFamily);	
		}

		try
		{
			Ping ping = new();
			System.Console.WriteLine("Pinging server. Please wait...");
			PingReply reply = ping.Send(uri.Host);
			
			System.Console.WriteLine("{0} was pinged and replied: {1}", uri.Host, reply.Status);
			
			if (reply.Status == IPStatus.Success)
			{
				System.Console.WriteLine("Reply from {0} took {1:N0}ms", reply.Address, reply.RoundtripTime);
			}
		}
		catch (Exception ex)
		{
			System.Console.WriteLine("{0} says {1}", ex.GetType().ToString(), ex.Message);
		}
	}
}