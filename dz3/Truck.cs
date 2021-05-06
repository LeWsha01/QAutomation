using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
	class Truck : Vehicle
	{
		private int carrying;
		public Truck(int maxSpeed, double engineCapacity, string typeTransmission, int carrying) : base(maxSpeed, engineCapacity, typeTransmission)
		{
			this.carrying = carrying;
		}

		public override void GetFullInfo()
		{
			Console.WriteLine($"maxSpeed={MaxSpeed},engineCapacity={EngineCapacity}," +
				$"typeTransmission={TypeTransmission}, carrying= {carrying} ");
		}
	}
}
