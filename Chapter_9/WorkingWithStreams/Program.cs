using System.Xml;
using System.IO.Compression;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
using System.Xml.Resolvers;

class Program
{
	public static void WorkWithText()
	{
		string textFile = Combine(CurrentDirectory, "streams.txt");

		StreamWriter writer = File.CreateText(textFile);
		foreach (var item in Viper.Callsigns)
		{
			writer.WriteLine(item);
		}
		writer.Close();

		System.Console.WriteLine("{0} contains {1:N0} bytes", textFile, textFile.Length);
		System.Console.WriteLine(File.ReadAllText(textFile));
	}
	public static void WorkWithXml()
	{
		FileStream? xmlStream = null;
		XmlWriter? xmlWriter = null;

		try
		{
			string xmlFile = Combine(CurrentDirectory, "streams.xml");

			xmlStream = File.Create(xmlFile);
			xmlWriter = XmlWriter.Create(xmlStream, new XmlWriterSettings { Indent = true });

			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("callsigns");
			foreach (var item in Viper.Callsigns)
			{
				xmlWriter.WriteElementString("callsign", item);
			}
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
			xmlStream.Close();

			System.Console.WriteLine("{0} contains {1:N0} bytes", xmlFile, new FileInfo(xmlFile).Length);

			System.Console.WriteLine(File.ReadAllText(xmlFile));
		}
		catch (Exception ex)
		{
			System.Console.WriteLine("{0} says {1}", ex.GetType(), ex.Message);
		}
		finally
		{
			if (xmlWriter is not null)
			{
				xmlWriter.Dispose();
				System.Console.WriteLine("Xml write's have been disposed");
			}
			if (xmlStream is not null)
			{
				xmlStream.Dispose();
				System.Console.WriteLine("Xml stream's have been disposed");
			}
		}
	}
	public static void WorkWithCompression()
	{
		string fileExt = "gzip";
		string filePath = Combine(CurrentDirectory, $"streams.{fileExt}");
		FileStream file = File.Create(filePath);
		Stream compressor = new GZipStream(file, CompressionMode.Compress);

		using (compressor)
		{
			using (XmlWriter xml = XmlWriter.Create(compressor))
			{
				xml.WriteStartDocument();
				xml.WriteStartElement("callsigns");
				foreach (var item in Viper.Callsigns)
				{
					xml.WriteElementString("callsign", item);
				}
			}
		}

		System.Console.WriteLine("{0} contains {1:N0} bytes", filePath, new FileInfo(filePath).Length);

		System.Console.WriteLine("The compressed content");
		System.Console.WriteLine(File.ReadAllText(filePath));

		System.Console.WriteLine("Reading the compressed xml content");
		file = File.Open(filePath, FileMode.Open);

		Stream decomressor = new GZipStream(file, CompressionMode.Decompress);

		using (decomressor)
		{
			using (XmlReader reader = XmlReader.Create(decomressor))
			{
				while (reader.Read())
				{
					if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "callsign"))
					{
						reader.Read(); 
						WriteLine($"{reader.Value}"); 
					}
				}
			}
		}
	}
	public static void Main(string[] args)
	{
		// WorkWithText();
		WorkWithXml();
		WorkWithCompression();
	}
}

static class Viper
{
	public static string[] Callsigns = new[]
	{
		"Husker", "Starbuck", "Apollo", "Boomer", "Bulldog", "Athena", "Helo", "Racetrack"
	};

}