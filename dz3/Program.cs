using System;

namespace AutoPark
{
	class Program
	{
		static void Main(string[] args)
		{

			Car a = new Car(10, 2.0, "full", "bmw");
			//a.GetFullInfo();
			Motorcycle b = new Motorcycle(10, 2.0, "full", "bmw");
			//b.GetFullInfo();
			Truck c = new Truck(10, 2.0, "full", 10);
			//c.GetFullInfo();
			Bus d = new Bus(10, 2.0, "full", 10);
			//d.GetFullInfo();
			//Vehicle[] array = new Vehicle[] {a, b, c, d };
			AutoPark result = new AutoPark(new Vehicle[] { a, b, c, d });
			result.GetFullInfo();
		}
	}
}
