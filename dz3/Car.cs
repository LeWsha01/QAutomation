using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
	class Car: Vehicle
	{
		private string brand;
		public Car(int maxSpeed, double engineCapacity, string typeTransmission, string brand) : base(maxSpeed, engineCapacity, typeTransmission)
		{
			this.brand = brand;
		}

		public override void GetFullInfo()
		{
			Console.WriteLine($"maxSpeed={MaxSpeed},engineCapacity={EngineCapacity}," +
				$"typeTransmission={TypeTransmission}, brand= {brand} ");
		}
	}
}
