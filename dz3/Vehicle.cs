using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
	abstract class Vehicle
	{
		protected int MaxSpeed { get; set; }
		protected double EngineCapacity { get; set; }
		protected string TypeTransmission { get; set; }

		public Vehicle(int maxSpeed, double engineCapacity, string typeTransmission)
		{
			this.MaxSpeed = maxSpeed;
			this.EngineCapacity = engineCapacity;
			this.TypeTransmission = typeTransmission;
		}

		public virtual void GetFullInfo() 
		{
			Console.WriteLine( $"{MaxSpeed}, {EngineCapacity}, {TypeTransmission}");
		}
	}
}
