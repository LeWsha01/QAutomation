using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using University.Interfaces;

namespace University.Services
{
	public class ServiceInfomation : IServiceInformation
	{
		public void GetAllCourses()
		{
			throw new NotImplementedException();
		}

		public void GetAllProfessors()
		{
			var filename = GetPathFile("Professors.xml");
			var xml = XDocument.Load(filename);
			var list = xml.Descendants("Professor").Where(st => 
			{
				var course = st.Element("Сourses").Descendants("Сourse");
				var countCourse = course.Count();
				return (int)countCourse > 1;
			});
			//realization
			//var list = from item in xml.Elements("Professor") select (string)item.Element("name").Value;
			//foreach (var i in list)
			//{
			//	Console.WriteLine(i.Name.ToString());
			//}
			foreach (var item in list)
			{
				Console.WriteLine($"{item.Attribute("Name").Value}");
			}
			

		}

		private string GetPathFile(string xmlName)
		{
			if (string.IsNullOrWhiteSpace(xmlName))
			{
				throw new Exception("12121");
			}
			//combine path
			var filename = $"D:/C#/University/University/{xmlName}";
			return filename;
		}
	}
}
