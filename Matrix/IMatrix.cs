using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix
{
	public interface IMatrix
	{
		int Dimension { get; }
		int this[int row, int col] { get; set; }
		void PrintMatrix();	
		void FillMatrixRandomElementsInRange(int begin, int end);
		void FillMatrixWithKeyboard();
	}
}