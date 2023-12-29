using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public interface IInterface1
    {
			public void Print();
    }
		public interface IInterface2
		{
			public void Print();
		}

		public class Class : IInterface1, IInterface2
		{
			void IInterface1.Print()
			{
				Console.WriteLine("IInterface1");
			}
			void IInterface2.Print()
      {
				Console.WriteLine("IInterface2");
      }
		}
}