using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktLibrary
{
	public class DvdPlayer : IPlayable
	{
		public void Pause()
		{
			System.Console.WriteLine("DVD player pausing...");
		}

		public void Play()
		{
			System.Console.WriteLine("DVD player playing");
		}
	}
}