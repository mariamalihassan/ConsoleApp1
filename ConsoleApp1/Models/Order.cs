using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public string Name { get; set; }

		public virtual Customer OrderCustomer { get; set; }
		
		public int CusId { get; set; }

	}
}
