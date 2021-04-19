using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int max = 0;
			int count = 0;
			/*string str = "assqwedddddqwertyuioasd";*/
			string str = args[0];
			for (int i = 0; i < str.Length - 1; i++)
			{
				
				if (str[i] != str[i + 1])
				{
					count++;
				}
				else
				{
					count = 0;
				}

				if (max < count)
				{
					max = count;
				}

			}

			Console.WriteLine(max.ToString());
		}
	}
}
