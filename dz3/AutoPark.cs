using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
	class AutoPark
	{
		private Vehicle[] arr = new Vehicle[1];
		private int index = 0;

		public AutoPark(Vehicle[] arr)
		{
			this.arr = arr;
			index = arr.Length;
		}

		public void AddElement(Vehicle a)
		{
			Array.Resize(ref arr, index + 1);
			index++;
			arr[index] = a;
		}

		public void GetFullInfo()
		{
			foreach (var i in arr)
			{
				i.GetFullInfo();
			}
		}
	}
}
