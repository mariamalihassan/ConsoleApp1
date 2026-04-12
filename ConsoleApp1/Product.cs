using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	//Model | Entity | POCO  Class | Domain Class
	internal class Product
	{
		//Id | ProductId 
		public int Id { get; set; }//primry key  =Identity column

		//Nulllable refrence type
		//sreing=> Nvarchar(max) allo null
		public string ProductName { get; set; }

		//Non Nullable value type
		//Decimal (18,2)
		public decimal Price { get; set; }
		//Non Nullable value type
		//int Not null

		public int UnitInStock { get; set; }
	}
}
