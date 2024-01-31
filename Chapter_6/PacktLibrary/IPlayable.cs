using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktLibrary
{
	public interface IPlayable
	{
		void Play();
		void Pause();
		void Stop()
		{
			System.Console.WriteLine("Stop");
		}
	}
}