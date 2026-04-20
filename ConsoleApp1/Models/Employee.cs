using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class Employee
	{
		[Key]
		public int EmpId { get; set; }
		public string Name { get; set; } = default!;
		public string? Address { get; set; }
		public decimal Salary { get; set; }

		public Car Car { get; set; }

		public Employee? Manager { get; set; }
		public int? ManagerId { get; set; }



	}
}
