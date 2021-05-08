using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
	class Matrix
	{
		protected int Size;
		protected int[] Arr;

		public Matrix(int size)
		{
			Size = size;
			Arr = new int[Size * Size];
			for(int i = 0; i < Size; i++)
			{
				Arr[i*(size + 1)] = int.Parse(Console.ReadLine());
			}
		}


		public int this [int row, int colom]
		{
			get
			{
				return Arr[row* Size + colom];
			}
			set
			{
				Arr[row * Size + colom] = value;
			}
		}
	}
}
