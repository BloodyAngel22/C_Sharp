using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix
{
	public class Matrix : IMatrix
	{
		private int _dimension;
		private int[,] _matrix;

		public Matrix(int dimension)
		{
			if (dimension <= 0)
			  throw new Exception("Dimension must be greater than 0.");
			_dimension = dimension;
			_matrix = new int[dimension, dimension];
		}

		public int this[int row, int col] { get => _matrix[row, col]; set => _matrix[row, col] = value; }

		public int Dimension => _dimension;

		public void FillMatrixRandomElementsInRange(int begin, int end)
		{
			for (int row = 0; row < _dimension; row++)
      {
        for (int col = 0; col < _dimension; col++)
        {
          _matrix[row, col] = new Random().Next(begin, end);
        }
      }
		}

		public void FillMatrixWithKeyboard()
		{
			System.Console.WriteLine("Enter the numbers");
			for (int row = 0; row < _dimension; row++)
      {
        for (int col = 0; col < _dimension; col++)
        {
					var input = Console.ReadLine();
          _matrix[row, col] = int.Parse(input);
        }
      }
		}

		public void PrintMatrix()
		{
			for (int row = 0; row < _dimension; row++)
      {
        for (int col = 0; col < _dimension; col++)
        {
          Console.Write($"{_matrix[row, col]} ");
        }
        Console.WriteLine();
      }
		}
	}
}