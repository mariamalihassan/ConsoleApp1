using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	//[PrimaryKey(nameof())]
	public class CustomerService
	{
		
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }

		
		public int ServiceId { get; set; }
		public Service Service { get; set; }
		public int? Cost { get; set; }
	}
}
