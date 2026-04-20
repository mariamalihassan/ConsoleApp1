using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class Customer
	{
		public int CustomerId { get; set; }
		public string Name { get; set; }

		[InverseProperty(nameof(Order.OrderCustomer))]

		public ICollection<Order> Orders { get; set; }= new HashSet<Order>();

		public ICollection<CustomerService> CustomerServices { get; set; } = new HashSet<CustomerService>();



	}
}
