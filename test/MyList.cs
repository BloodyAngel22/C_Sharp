using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public class MyList <T>
	{
		private T[] _array = Array.Empty<T>();

		public T this[int index]
		{
			get => _array[index];
			set => _array[index] = value;
		}
		public int Count => _array.Length;
		public void Add(T value)
    {
			var newArray = new T[_array.Length + 1];
			Array.Copy(_array, newArray, _array.Length);
			newArray[_array.Length] = value;
			_array = newArray;
    }
		public void PrintList()
		{
			foreach (var item in _array)
      {
        System.Console.Write(item + " ");
      }
			System.Console.WriteLine();
		}
		public void Remove(int index)
    {
			var newArray = new T[_array.Length - 1];
			int i = 0;
			for (int j = 0; j < _array.Length; j++)
			{
				if (j != index)
        {
          newArray[i] = _array[j];
          i++;
        }
			}
			_array = newArray;
		}
	}
}