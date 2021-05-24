using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using University.Interfaces;
using University.Services;

namespace University
{
	public class Program
	{
		public static IServiceInformation serviceInformation { get; set; }
		public static void Main(string[] args)
		{

			serviceInformation = new ServiceInfomation();
			//var result = serviceInformation.GetAllProfessors();
			serviceInformation.GetAllProfessors();

		}
	}
}
