using System;

namespace Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			//Matrix arr = new Matrix(3);
			//Console.WriteLine(arr[2, 1]);
			DiagonalMatrix ar = new DiagonalMatrix(4);
			Console.WriteLine(ar[2, 2]);
		}
	}
}
