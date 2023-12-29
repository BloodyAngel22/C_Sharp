using System;

namespace Matrix
{
	public class Program
	{
		private static void Main(string[] args)
    {
			Matrix matrix = new(3);
			matrix.FillMatrixRandomElementsInRange(1, 10);
			Matrix matrix2 = new(3);
			matrix2.FillMatrixRandomElementsInRange(1, 10);

			// System.Console.WriteLine(matrix.Dimension);
			// matrix.FillMatrixWithKeyboard();
			// matrix.PrintMatrix();

			// Action.MatrixSubtraction(matrix, matrix2);

			matrix.PrintMatrix();
			MatrixAction.TransposeMatrix(matrix);
			// matrix2.PrintMatrix();
			// MatrixAction.MatrixMultiplication(matrix, matrix2);
			matrix.PrintMatrix();
		}
	}
}