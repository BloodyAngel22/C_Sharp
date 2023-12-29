using System.Globalization;
using myClass;
using test;
using BAExtensions;
using System.Drawing;
using Experimental;

namespace Test{

  class Program{
		static void PrintArray(int[] arr, int i = 0){
			if (i < arr.Length){
				System.Console.WriteLine(arr[i]);
				PrintArray(arr, ++i);
			}
		}
		static void Foo(ref int a){
			System.Console.WriteLine(a);
		}
		static void Foo_2(out int a){
			a = 10;
			System.Console.WriteLine(a);
		}
		static void Foo_3(in int a){ // a - const
		  // a = 10; error
			System.Console.WriteLine(a);
		}
		static int Sum(params int[] value){
			int result = 0;

			for (int i = 0; i < value.Length; i++)
				result += value[i];

			return result; 
		}
		static int[] CreateArray(int size){
			int[] new_arr = new int[size];
			return new_arr;
		}
		static void HelloWorld(){
			System.Console.WriteLine("Hello World!");
		}
		enum MODE{
			ON = 1,
			OFF = 0
		}
		static void Insert(ref int[] array, int data){
			Array.Resize(ref array, array.Length + 1);
			array[array.Length - 1] = data;
		}
    static void Main(string[] args){
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
			// Bar(sbClass);
			// Bar_2(sbClass);

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

			MyList<int> myList = new MyList<int>();
			for (int i = 0; i < 10; i++)
			{
				myList.Add(i+1);
			}
			myList.PrintList();
			myList.Remove(5);
			myList.PrintList();
		}

		static void Bar(IInterface1 interface1){
			interface1.Print();
		}
		static void Bar_2(IInterface2 interface2){
      interface2.Print();
    }
		static void ChangeCoordinate(MainStruct mainStruct)
		{
			mainStruct.SetCoordinates(2,3,2);
		}
		static void ChangeCoordinate(MainClass mainClass)
		{
			mainClass.SetCoordinate(2,3,2);
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
		static void ModificatedSwap <T> (ref T a, ref T b) //effective
		{
			T temp = a;
      a = b;
      b = temp;
		}
		
  }
}
