using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class EmployeeCar
	{

		[Key]
		[ForeignKey(nameof(Car))]
		public int CarId { get; set; }//fk 
		public Car Car { get; set; } = default!;

		[ForeignKey(nameof(Employee))]
		public int EmpId { get; set; }//fk


		public Employee Employee { get; set; } = default!;


	}
}
