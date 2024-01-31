using System.Globalization;
using myClass;
using test;
using BAExtensions;
using System.Drawing;
using Experimental;
using static System.Console;
using System.Xml;
using System.Data;
using System.Threading.Tasks.Dataflow;
using System.Linq.Expressions;
using static System.Convert;
using System.Net;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace Test;

class Program
{
	delegate void MyDelegate(ref int a, ref int b);
	static void PrintArray(int[] arr, int i = 0)
	{
		if (i < arr.Length)
		{
			System.Console.WriteLine(arr[i]);
			PrintArray(arr, ++i);
		}
	}
	static void Foo(ref int a)
	{
		System.Console.WriteLine(a);
	}
	static void Foo_2(out int a)
	{
		a = 10;
		System.Console.WriteLine(a);
	}
	static void Foo_3(in int a)
	{ // a - const
		// a = 10; error
		System.Console.WriteLine(a);
	}
	static int Sum(params int[] value)
	{
		int result = 0;

		for (int i = 0; i < value.Length; i++)
			result += value[i];

		return result;
	}
	static int[] CreateArray(int size)
	{
		int[] new_arr = new int[size];
		return new_arr;
	}
	static void HelloWorld()
	{
		System.Console.WriteLine("Hello World!");
	}
	enum MODE
	{
		ON = 1,
		OFF = 0
	}
	static void Insert(ref int[] array, int data)
	{
		Array.Resize(ref array, array.Length + 1);
		array[array.Length - 1] = data;
	}
	static void Main(string[] args)
	{
		/* string name; */
		/* string surname; */

		/* System.Console.WriteLine("Введите вашу фамилию: "); */
		/* surname = Console.ReadLine(); */
		/* System.Console.WriteLine("Введите ваше имя: "); */
		/* name = Console.ReadLine(); */

		/* System.Console.WriteLine("Здравствуйте " + surname + " " + name); */

		/* string str_1 = Console.ReadLine(); */
		/* string str_2 = Console.ReadLine(); */
		/* int a = Convert.ToInt32(str_1); */
		/* int b = Convert.ToInt32(str_2); */
		/* Console.WriteLine(a+b); */

		/* string str = "6dfdsf"; */


		/* NumberFormatInfo nfi = new NumberFormatInfo(){ */
		/*   NumberDecimalSeparator = ".", */
		/* }; */

		/* double a = double.Parse(str, nfi); */

		/* double a = Convert.ToDouble(str, nfi); */

		/* Console.WriteLine(a); */

		/* try{ */
		/*   double a = double.Parse(str); */
		/*   Console.WriteLine(a); */
		/* } */
		/* catch (Exception){ */
		/*   Console.WriteLine("Convert error"); */
		/* } */


		// uint counter_even = 0; //Четное
		// uint counter_odd = 0; //Нечетное

		// int counter = 0;
		// while (counter != 101){
		//   if (counter % 2 == 0){
		//     counter_even++;
		//     Console.WriteLine(counter + " % " + "2 = 0");
		//   }
		//   else {
		//     counter_odd++;
		//     Console.WriteLine(counter + " % " + "2 = 1");
		//   }
		//   counter++;
		// }
		// Console.WriteLine(counter_even);
		// Console.WriteLine(counter_odd);

		/* string pass = "qwerty"; */
		/* string storage = "qwerty"; */
		/* bool isTrue = pass == storage;  */
		/* Console.WriteLine(pass == storage); */

		/* int[] arr = new int[5]; */
		/* arr = Enumerable.Range(3,10).ToArray(); */
		/*  */
		/* for (int i = 0; i < arr.Length; i++) */
		/*   Console.WriteLine(arr[i]); */
		/*  */
		/* Console.WriteLine(arr.Where(i => i % 2 == 0).Min()); */

		/* string str = "Hello world! :)"; */
		/* Console.WriteLine(str[^2..]); */

		/* int[,] arr = new int [5,5]; */
		/* for (int i = 0; i < arr.GetLength(0); i++) */
		/*   for (int j = 0; j < arr.GetLength(1); j++) */
		/*     arr[i,j] = j; */
		/*  */
		/* for (int i = 0; i < arr.GetLength(0); i++){ */
		/*   for (int j = 0; j < arr.GetLength(1); j++) */
		/*     Console.Write(arr[i,j] + " "); */
		/*  */
		/*   Console.WriteLine(); */
		/* } */

		/* static int Sum(int a, int b){ */
		/*   return a+b; */
		/* } */

		/* Console.WriteLine(Sum(4,5)); */

		/* Random rand = new Random(); */

		/* int [ , ] arr = new int[5,5]; */

		/* for (int i = 0; i < arr.GetLength(0); i++) */
		/*   for (int j = 0; j < arr.GetLength(1); j++) */
		/*     arr[i,j] = rand.Next(10, 100); */
		/*  */
		/* for (int i = 0; i < arr.GetLength(0); i++){ */
		/*   for (int j = 0; j < arr.GetLength(1); j++) */
		/*     Console.Write(arr[i,j] + " "); */
		/*   Console.WriteLine(); */
		/* } */

		/* string str = "qwerty"; */
		/* string str = null; */

		/* str ??= string.Empty; */
		/*  */
		/* if (str == string.Empty) */
		/*   Console.WriteLine("Doesn't data"); */
		/* else */
		/*   Console.WriteLine(str); */

		/* int [] arr = null; */
		/* arr ??= new int[0]; */
		/* Console.WriteLine(arr.Length); */

		// Person person_1 = new Person("Maxim", "Zh", "Evg");
		// System.Console.WriteLine(person_1.GetFullName(enablePrint: true));

		// static void Foo(ref int a){
		// 	a = 1;
		// }

		// int number = 4;
		// Foo(ref number);
		// System.Console.WriteLine(number);

		// int[] arr = {1,2,3,4,5};
		// System.Console.WriteLine(arr.Length);
		// Array.Resize(ref arr, 3);
		// System.Console.WriteLine(arr.Length);
		// Array.Resize(ref arr, 9);
		// System.Console.WriteLine(arr.Length);
		// foreach (var item in arr)
		// {
		// 	System.Console.Write(item + " ");	
		// }

		// int[] arr = {1,2,3,4,5};
		// Insert(ref arr, 9);

		// int[] arr = {1,2,3};
		// for (int i = 0; i < 10; i++)
		// 	Insert(ref arr, i);

		// foreach (var item in arr)
		// {
		// 	System.Console.Write(item + " ");	
		// }

		// int[] arr = CreateArray(10);
		// Array.Fill(arr, 5);

		// foreach (var item in arr)
		// {
		// 	System.Console.Write(item + " ");	
		// }
		// int a = 10;
		// int b;
		// Foo(ref b);
		// Foo_2(out b);

		// System.Console.WriteLine(Sum(1,2,3,4,5,6,7));

		// int[] arr = new int[5];
		// for (int i = 0; i < arr.Length; i++) // 	arr[i] = i+1;
		// PrintArray(arr);

		// var curMode = MODE.ON;
		// bool isEnable = Convert.ToBoolean(curMode);
		// int isEnableINT = Convert.ToInt32(curMode);

		// System.Console.WriteLine(curMode);
		// System.Console.WriteLine(isEnable);
		// System.Console.WriteLine(isEnableINT);

		// Student student = new Student(Name: "Maxim", Surname: "Zh", Group: "IVT-2", Birthday: new DateTime(2001, 1, 1));
		// student.Print();
		// System.Console.WriteLine(student.GetFullName());

		// Student student2 = new Student(Name: "John", Surname: "Smith", Group: "IVT-1", Birthday: new DateTime(2000, 1, 1));
		// student2.Print();
		// System.Console.WriteLine(student2.GetFullName());

		// Student student3 = new Student();
		// student3.Print();
		// System.Console.WriteLine(student3.GetFullName());

		// Student student4 = new Student(student);
		// student4.SetSurname("Smith2");
		// student4.Print();

		// Point2D point1 = new Point2D(4,5);
		// point1.Print();
		// System.Console.WriteLine($"X: {point1.X}");
		// point1.SetCoordinate(12,0);
		// point1.Print();
		// point1.X = 0;
		// point1.Print();
		// // Point2D.SetId(5);
		// Point2D point2 = new();
		// point2.Print();
		// System.Console.WriteLine(Point2D.ID);

		// Point2DExtensions.Print(point1);
		// point2.X = 10;
		// Point2DExtensions.Print(point2);
		// System.Console.WriteLine(Point2DExtensions.IsEqual(point1, point2));
		// System.Console.WriteLine(Point2D.TMP);

		// Worker worker = new Worker("Maxim", "Zh", "Evg");
		// worker.Print();
		// Person person = new Worker("Maxim", "Zh", "Evg");
		// person.Print();

		// Worker? worker = person as Worker;
		// worker?.Print();

		// if (person is Worker worker2){
		// 	worker2.Print();
		// }

		// Driver driver = new Driver();
		// driver.Drive(new SportCar());

		Player player = new Player();
		// player.WeaponInfo(new Shotgun());
		// player.WeaponInfo(new Sword());

		Gun[] inventory = [new Pistol(), new Minigun(), new Shotgun()];

		// foreach (Gun gun in inventory)
		// {
		// 	gun.GetInfo();
		//   gun.Fire();
		// }

		// IWeapon[] weapons = [new Pistol(), new Minigun(), new Shotgun(), new Sword(), new Knife()];

		// foreach (IWeapon weapon in weapons)
		// {
		//   weapon.Fire();
		// }

		// player.Throw(new Knife());

		// Class sbClass = new Class();
		// Bar(sbClass); // Bar_2(sbClass);
		// var obj = new Class();
		// if (obj is IInterface2 iInterface1){
		// 	iInterface1.Print();
		// }

		// MainStruct mainStruct = new MainStruct();
		// mainStruct.SetCoordinates(1,1,2);
		// mainStruct.Print();
		// ChangeCoordinate(mainStruct);
		// mainStruct.Print();

		// MainClass mainClass = new MainClass();
		// mainClass.Foo();
		// mainClass.Bar();
		// mainClass.SetCoordinate(1,1,2);
		// mainClass.Print();
		// ChangeCoordinate(mainClass);
		// mainClass.Print();

		// float a = 1.5f;
		// float b = 5.2f;
		// System.Console.WriteLine($"{a} ; {b}");
		// Swap(ref a, ref b);
		// System.Console.WriteLine($"{a},{b}");
		// ModificatedSwap(ref a, ref b);
		// System.Console.WriteLine($"{a} ; {b}");

		// MyList<int> myList = new MyList<int>();
		// for (int i = 0; i < 10; i++)
		// {
		// 	myList.Add(i+1);
		// }
		// myList.PrintList();
		// myList.Remove(5);
		// myList.PrintList();

		// int a = 10;
		// int b = 20;
		// System.Console.WriteLine($"{a} ; {b}");
		// MyDelegate meth = new MyDelegate(Swap);
		// meth(ref a, ref b);
		// System.Console.WriteLine($"{a} ; {b}");

		// Random random = new Random();
		// int a = random.Next(10, 100);
		// double b = random.NextDouble();
		// System.Console.WriteLine($"{a} ; {b}");
		// double c = a * b;
		// System.Console.WriteLine($"{a} * {b} = {c}");

		// String str = "qwerty";
		// str = str.ToUpper();
		// str = str.Replace("q", "Asdf");
		// str = str.Insert(0, "Mr. ");
		// System.Console.WriteLine($"{str}");

		// double temperature = 10;
		// String message = (temperature > 18) ? "Hot" : "Cold";
		// System.Console.WriteLine(message);

		// string filePath = "C:\Users\BA22\Desktop\test.txt"; //error message
		// string filePath = @"C:\Users\BA22\Desktop\test.txt"; //right message

		// int million = 1_000_000;

		// double a = 0.1;
		// double b = 0.2;
		// if (a + b == 0.3)
		// {
		// 	System.Console.WriteLine($"{a} + {b} = 0.3");
		// }
		// else
		// {
		// 	System.Console.WriteLine($"{a} + {b} != 0.3");
		// }

		// decimal c = 0.1M;
		// decimal d = 0.2M;
		// if (c + d == 0.3M)
		// {
		// 	System.Console.WriteLine($"{c} + {d} = 0.3");
		// }
		// else
		// {
		// 	System.Console.WriteLine($"{c} + {d} != 0.3");
		// }

		// object a = 12;
		// System.Console.WriteLine(a);
		// a = 25.4f;
		// System.Console.WriteLine(a);
		// a = "Hello, world!";
		// System.Console.WriteLine(a);
		// a = new[] {1,2,3,4};
		// System.Console.WriteLine(a);

		// int[] a = new int[] {1,2,3,4};
		// int[] a = [1,2,3,4];

		// Person person = new("John", "Smith", "Smith");

		// string[] names = new string[4];
		// names[0] = "John";
		// names[1] = "Smith";
		// names[2] = "Adam";
		// names[3] = "Alex";

		// foreach (string name in names)
		// {
		// 	System.Console.WriteLine(name);
		// }

		// int numberOfApples = 5;
		// decimal pricePerApple = 4.2M;
		// Console.WriteLine($"{numberOfApples} apple costs {pricePerApple * pricePerApple}");

		// string name = "John";
		// string surname = "Smith";
		// string fullName = $"{name} {surname}";
		// System.Console.WriteLine(fullName);

		// WriteLine("Hello, world!"); //using static System.Console
		// System.Console.WriteLine("Hello, world!");
		// Console.WriteLine("Hello, world!");

		// WriteLine("Press any key to continue...");
		// ConsoleKeyInfo key = ReadKey();
		// WriteLine();
		// System.Console.WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modified: {key.Modifiers}");

		// System.Console.WriteLine(args.Length);
		// foreach (var arg in args)
		// {
		// 	System.Console.WriteLine(arg);
		// }

		// try 
		// {
		// 	CursorSize = int.Parse(args[2]);
		// }
		// catch (PlatformNotSupportedException)
		// {
		// 	System.Console.WriteLine("Does not support");
		// }

		// int a = 3;
		// int b = a++;
		// System.Console.WriteLine($"a = {a}, b = {b}");

		// double a = 11.0;
		// System.Console.WriteLine($"{a:N2}");
		// double b = 4.0;
		// System.Console.WriteLine($"{a+b:N2}");

		// int myVariable = 12;
		// System.Console.WriteLine(nameof(myVariable));
		// System.Console.WriteLine(sizeof(int));

		// int a = int.Parse(ReadLine());
		// if (a == 0)
		// {
		// 	System.Console.WriteLine("a == 0");
		// }
		// else if (a >= 1)
		// {
		// 	System.Console.WriteLine("a >= 1");
		// }
		// else
		// {
		// 	System.Console.WriteLine("a < 0");
		// }

		// object a = 5;
		// if (a is int i) // if a is int then int i = a; 
		// {
		// 	System.Console.WriteLine(i*i);
		// }
		// else
		// {
		// 	System.Console.WriteLine("a isn't integer");
		// }

		// int number = new Random().Next(1,6);
		// System.Console.WriteLine(number);

		// switch (number)
		// {
		// 	case 1:
		// 	System.Console.WriteLine("1");
		// 	break;
		// 	case 2:
		// 	goto case 1;
		// 	case 3:
		// 	goto case 2;
		// 	case 4:
		// 	System.Console.WriteLine("4");
		// 	break;
		// 	case 5:
		// 	goto case 4;
		// }

		// string result = number switch
		// {
		// 	1 => "1",
		// 	2 => "2",
		// 	3 => "3",
		// 	4 => "4",
		// 	5 => "5"
		// };
		// System.Console.WriteLine(result);

		// double a = 5.7;
		// int b = a; // error cast
		// int b = (int)a; // correct cast b = 5;
		// int b = ToInt32(a); // using static System.Convert b = 6;
		// System.Console.WriteLine(b);
		// double c = 10.5;
		// // int b = ToInt32(c); // c = 10 because 10 % 2 == 0; banking conversion
		// double b = Math.Round(value: c, digits: 0, mode: MidpointRounding.AwayFromZero);
		// System.Console.WriteLine(b); // c = 11
		// int a = 10;
		// string b = a.ToString();
		// System.Console.WriteLine(GetTypeCode(b));
		// System.Console.WriteLine(b);

		// DateTime dt = DateTime.Now;
		// System.Console.WriteLine(dt.ToString());

		// int age = int.Parse("19");
		// DateTime birthDate = DateTime.Parse("6 November 2004");
		// System.Console.WriteLine($"{birthDate:D}");
		// if (int.TryParse("19", out int curAge))
		// {
		// 	System.Console.WriteLine(curAge);
		// }
		// else
		// {
		// 	System.Console.WriteLine("Couldn't parse age");
		// }

		// string? input = ReadLine();

		// try
		// {
		// 	int age = int.Parse(input);
		// 	System.Console.WriteLine(age);
		// }
		// catch (FormatException)
		// {
		// 	System.Console.WriteLine("Doesn't convert");
		// }
		// catch (Exception ex)
		// {
		// 	System.Console.WriteLine($"{ex.GetType()} says {ex.Message}");
		// }

		// System.Console.WriteLine("Enter the number");
		// string? input = ReadLine();

		// try
		// {
		// 	int number = int.Parse(input);
		// }
		// catch (FormatException) when (input.Contains("$"))
		// {
		// 	System.Console.WriteLine("Number cannot use the dollar sign");
		// }
		// catch (FormatException)
		// {
		// 	System.Console.WriteLine("Number must be only contains digits");
		// }

		// int number = int.MaxValue - 1;
		// checked
		// {
		// 	System.Console.WriteLine(number);
		// 	number++;
		// 	System.Console.WriteLine(number);
		// 	number++;
		// 	System.Console.WriteLine(number);
		// }

		// int number = int.MaxValue + 1; // error overflow
		// unchecked
		// {
		// 	int number = int.MaxValue + 1; //correct
		// 	System.Console.WriteLine(number);
		// 	number++;
		// 	System.Console.WriteLine(number);
		// }

		// for (uint i = 1; i <= 10; i++)
		// {
		// 	MultiplicationTable(i);
		// }
		// int number = 12;
		// try
		// {
		// 	System.Console.WriteLine($"{Factorial(number):N0}");
		// }
		// catch (OverflowException)
		// {
		// 	System.Console.WriteLine($"{number}! is too so big for a int32");
		// }

		// Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

		// Trace.AutoFlush = true;

		// Debug.WriteLine("Debug says hello every one");
		// Trace.WriteLine("Trace says hello every one");

		// ConfigurationBuilder builder = new();
		// builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

		// IConfigurationRoot configurationRoot = builder.Build();
		// TraceSwitch ts = new(displayName: "PacktSwitch", description: "JSON configuration switch");
		// configurationRoot.GetSection("PacktSwitch").Bind(ts);

		// Trace.WriteLineIf(ts.TraceError, "Trace error");
		// Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
		// Trace.WriteLineIf(ts.TraceInfo, "Trace information");
		// Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

		// string message = "";
		// int number = -1;
		// Foo_4(message, number);

		// Person person = new("John", "Smith", "Smithovich")
		// {
		// 	dateOfBirth = new(2000, 7, 24),
		// 	favoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia,
		// 	bucketList = 
		// 	{
		// 		WondersOfTheAncientWorld.ColossusOfRhodes,
		// 		WondersOfTheAncientWorld.HangingGardensOfBabylon,
		// 		WondersOfTheAncientWorld.TempleOfArtemisAtEphesus
		// 	}
		// };
		// person.PrintFullInfo();

		// (string Name, WondersOfTheAncientWorld favoriteAncient) = person.GetNameAndAncientWorld();
		// System.Console.WriteLine(format: "Name: {0}, Favorite Ancient: {1}", arg0: Name, arg1: favoriteAncient);
		// var (name, dob) = person;
		// System.Console.WriteLine(format: "Name: {0}, Date of Birth: {1:d MMM yyyy}", arg0: name, arg1: dob);

		// Person person = new()
		// {
		// 	Name = "John",
		// 	Surname = "Smith",
		// 	MiddleName = "Smithovich"
		// };
		// person.Name = "Alex" //doesn't work because it's init property
		// person.MiddleName = "Alex";
		// person.PrintFullInfo();

		// Vehicle v1 = new()
		// {
		// 	Wheels = 4,
		// 	Color = "red"
		// };
		// Vehicle v2 = v1 with //creating an object v2 similar to v1. This is record not class
		// {
		// 	Color = "green"
		// };
		// System.Console.WriteLine(v2.Wheels);
		// System.Console.WriteLine(v2.Color);

		// Vehicle v3 = new(4, "red");
		// var (counterWheels, color) = v3;
		// System.Console.WriteLine(counterWheels + " " + color);
	}

	static void Bar(IInterface1 interface1)
	{
		interface1.Print();
	}
	static void Bar_2(IInterface2 interface2)
	{
		interface2.Print();
	}
	static void ChangeCoordinate(MainStruct mainStruct)
	{
		mainStruct.SetCoordinates(2, 3, 2);
	}
	static void ChangeCoordinate(MainClass mainClass)
	{
		mainClass.SetCoordinate(2, 3, 2);
	}
	static void Swap(ref int a, ref int b)
	{
		int temp = a;
		a = b;
		b = temp;
	}
	static void Swap(ref double a, ref double b) //not effective
	{
		double temp = a;
		a = b;
		b = temp;
	}
	static void ModificatedSwap<T>(ref T a, ref T b) //effective
	{
		T temp = a;
		a = b;
		b = temp;
	}
	public static void MultiplicationTable(uint number)
	{
		for (int i = 1; i <= 10; i++)
		{
			System.Console.WriteLine($"{number} * {i} = {number * i}");
		}
	}
	/// <summary>
	/// Передайте число и получите факториал этого числа 
	/// </summary>
	/// <param name="number">Number может быть int32</param>
	/// <returns>Возваращается факториал числа</returns>
	static int Factorial(int number)
	{
		int result = 1;

		if (number <= 0)
			return 0;
		else if (number == 1)
			return 1;
		checked
		{
			for (int i = 1; i <= number; i++)
			{
				result = result * i;
			}

			return result;
		}
	}
	static void Foo_4(string message, int number)
	{
		if (message.Length == 0)
		{
			// throw new ArgumentNullException(paramName: nameof(message));
			message.Append(' ');
		}
		if (number <= 0)
		{
			// throw new ArgumentException("Number must be greater than zero");
			int defaultValue = 1;
			number = defaultValue;
		}

		System.Console.WriteLine(message + " " + number);
	}

}
