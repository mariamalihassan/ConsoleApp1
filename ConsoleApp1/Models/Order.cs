using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class Order
	{
		public int OrderId { get; set; }
		public string Name { get; set; }

		public Customer OrderCustomer { get; set; }
		
		public int CusId { get; set; }

	}
}
