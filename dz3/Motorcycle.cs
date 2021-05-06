using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
	class Motorcycle : Vehicle
	{
		private string destination;
		public Motorcycle(int maxSpeed, double engineCapacity, string typeTransmission,string destination) :base(maxSpeed, engineCapacity, typeTransmission)
		{
			this.destination = destination;
		}

		public override void GetFullInfo()
		{
			Console.WriteLine($"maxSpeed={MaxSpeed},engineCapacity={EngineCapacity}," +
				$"typeTransmission={TypeTransmission}, destination= {destination} ");
		}
	}
}
