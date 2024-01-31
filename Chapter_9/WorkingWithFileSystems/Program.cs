using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using static System.Console;

class Program
{
	public static void OutputFileSystemInfo()
	{
		System.Console.WriteLine("{0,-33} {1}", Path.PathSeparator, PathSeparator);
		WriteLine("{0,-33} {1}", arg0: "Path.DirectorySeparatorChar",
		arg1: DirectorySeparatorChar);
		WriteLine("{0,-33} {1}", arg0: "Directory.GetCurrentDirectory()",
		arg1: GetCurrentDirectory());
		WriteLine("{0,-33} {1}", arg0: "Environment.CurrentDirectory",
		arg1: CurrentDirectory);
		WriteLine("{0,-33} {1}", arg0: "Environment.SystemDirectory",
		arg1: SystemDirectory);
		WriteLine("{0,-33} {1}", arg0: "Path.GetTempPath()",
		arg1: GetTempPath());
		WriteLine("GetFolderPath(SpecialFolder");
		WriteLine("{0,-33} {1}", arg0: " .System)",
		arg1: GetFolderPath(SpecialFolder.System));
		WriteLine("{0,-33} {1}", arg0: " .ApplicationData)",
		arg1: GetFolderPath(SpecialFolder.ApplicationData));
		WriteLine("{0,-33} {1}", arg0: " .MyDocuments)",
		arg1: GetFolderPath(SpecialFolder.MyDocuments));
		WriteLine("{0,-33} {1}", arg0: " .Personal)",
		arg1: GetFolderPath(SpecialFolder.Personal));
	}
	public static void WorkWithDrives()
	{
		WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
"NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");
		foreach (DriveInfo drive in DriveInfo.GetDrives())
		{
			if (drive.IsReady)
			{
				WriteLine(
			"{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
			drive.Name, drive.DriveType, drive.DriveFormat,
			drive.TotalSize, drive.AvailableFreeSpace);
			}
			else
			{
				WriteLine("{0,-30} | {1,-10}", drive.Name, drive.DriveType);
			}
		}
	}
	public static void WorkWithFiles()
	{
		string path = "./OutputFiles";
		CreateDirectory(path);

		string? textFile = Combine(path, "text.txt");
		string? backupFile = Combine(path, "text.bak");

		// System.Console.WriteLine("Working with {0}", textFile);

		// StreamWriter writer = File.CreateText(textFile);
		// writer.WriteLine("Hello, C#");
		// writer.Close();
		// System.Console.WriteLine("Exit {0}", textFile);

		// System.Console.WriteLine("Copy data {0} in {1}", textFile, backupFile);
		// File.Copy(textFile, backupFile, true);

		// System.Console.WriteLine("Delete {0} file", textFile);
		// File.Delete(textFile);

		// System.Console.WriteLine("Reading content from backup {0}", backupFile);
		// StreamReader reader = File.OpenText(backupFile);
		// System.Console.WriteLine(reader.ReadToEnd());
		// reader.Close();

		System.Console.WriteLine("Folder name {0}", GetDirectoryName(textFile));
		System.Console.WriteLine("File name {0}", GetFileName(textFile));
		System.Console.WriteLine("File name without extension {0}", GetFileNameWithoutExtension(textFile));
		System.Console.WriteLine("File extension {0}", GetExtension(textFile));
		System.Console.WriteLine("Random file name {0}", GetRandomFileName());
		System.Console.WriteLine("Temp file name {0}", GetTempFileName());

		FileInfo info = new(backupFile);
		System.Console.WriteLine(backupFile);
		System.Console.WriteLine("Contains {0} bytes", info.Length);
		System.Console.WriteLine("Last accessed time {0}", info.LastAccessTime);
		System.Console.WriteLine("Has readonly set to {0}", info.IsReadOnly);
	}
	public static void Main(string[] args)
	{
		// OutputFileSystemInfo();
		// WorkWithDrives();
		WorkWithFiles();
	}
}