using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix
{
	public static class MatrixAction
	{
		public static void MatrixAddition(IMatrix matrix1, IMatrix matrix2)
		{
			if (matrix1.Dimension != matrix2.Dimension)
			{
				System.Console.WriteLine("Dimension mismatch");
				return;
			}

			for (int row = 0; row < matrix1.Dimension; row++)
      {
        for (int col = 0; col < matrix1.Dimension; col++)
        {
          matrix1[row, col] += matrix2[row, col];
        }
      }
		}
		public static void MatrixSubtraction(IMatrix matrix1, IMatrix matrix2)
		{
			if (matrix1.Dimension != matrix2.Dimension)
			{
				System.Console.WriteLine("Dimension mismatch");
				return;
			}
			for (int row = 0; row < matrix1.Dimension; row++)
      {
        for (int col = 0; col < matrix1.Dimension; col++)
        {
          matrix1[row, col] -= matrix2[row, col];
        }
      }
		}
		public static void MatrixMultiplication(IMatrix matrix1, IMatrix matrix2)
		{
			if (matrix1.Dimension != matrix2.Dimension)
			{
				System.Console.WriteLine("Dimension mismatch");
				return;
			}
			Matrix result = new (matrix1.Dimension);
			for (int row = 0; row < matrix1.Dimension; row++)
      {
				for (int col = 0; col < matrix2.Dimension; col++)
        {
					for (int i = 0; i < matrix1.Dimension; i++)
					{
						result[row, col] += matrix1[row, i] * matrix2[i, col];
					}
        }
			}

			for (int row = 0; row < matrix1.Dimension; row++)
			{
				for (int col = 0; col < matrix2.Dimension; col++)
        {
          matrix1[row, col] = result[row, col];
        }
			}
		}
		public static void MultiplyingMatrixByNumber(IMatrix matrix, int number)
		{
			for (int row = 0; row < matrix.Dimension; row++)
      {
        for (int col = 0; col < matrix.Dimension; col++)
        {
          matrix[row, col] *= number;
        }
      }
		}
		public static void TransposeMatrix(IMatrix matrix)
		{
			Matrix result = new (matrix.Dimension);
			for (int row = 0; row < matrix.Dimension; row++)
			{
				for (int col = 0; col < matrix.Dimension; col++)
        {
					result[col, row] = matrix[row, col];
        }
			}

			for (int row = 0; row < matrix.Dimension; row++)
      {
				for (int col = 0; col < matrix.Dimension; col++)
        {
          matrix[row, col] = result[row, col];
        }
			}
		}
	}
}