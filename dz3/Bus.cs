using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
	class Bus : Vehicle
	{
		private int NumberOfSeats;
		public Bus(int maxSpeed, double engineCapacity, string typeTransmission, int NumberOfSeats) : base(maxSpeed, engineCapacity, typeTransmission)
		{
			this.NumberOfSeats = NumberOfSeats;
		}

		public override void GetFullInfo()
		{
			Console.WriteLine($"maxSpeed={MaxSpeed},engineCapacity={EngineCapacity}," +
				$"typeTransmission={TypeTransmission}, NumberOfSeats= {NumberOfSeats} ");
		}
	}
}
