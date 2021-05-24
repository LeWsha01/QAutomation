using System;
using System.Collections.Generic;
using System.Text;

namespace University
{
	public class Faculty: Department
	{
		public List<Student> Students { get; set; }
		public List<Specialty> Specialties { get; set; }
		public List<Professor> Professors { get; set; }
	}
}
