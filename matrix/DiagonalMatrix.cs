using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
	class DiagonalMatrix : Matrix
	{
		public DiagonalMatrix(int Size) : base(Size)
		{
			this.Size = Size;
			for (int i = 0; i < Size; i++)
			{
				Arr[i] = int.Parse(Console.ReadLine());
			}
		}

		public new int this[int row, int colom]
		{
			get
			{
				return Arr[row * Size + colom];
			}
			set
			{
				Arr[row * Size + colom] = value;
			}
		}
	}
}
