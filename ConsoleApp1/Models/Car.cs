using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	
	internal class Car
	{
	
		public int EmpId { get; set; }//pk for Employee  fk Car

		public int CarId { get; set; }
		public string Model { get; set; }
		public Employee Employee { get; set; }







	}
}
