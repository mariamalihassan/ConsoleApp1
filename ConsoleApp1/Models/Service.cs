using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class Service
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;

		public ICollection<CustomerService> CustomerServices { get; set; } = new HashSet<CustomerService>();


	}
}
