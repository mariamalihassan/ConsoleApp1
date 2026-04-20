using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class Course
	{
		public int Id { get; set; }
		public string Title { get; set; } 
		public string ? Description { get; set; }
		public int Credit { get; set; }
		public DateTime CourseTime { get; set; }
	}
}
