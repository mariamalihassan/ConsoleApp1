using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class BookPublisher
	{
		public int BookId { get; set; }//fk to book relationship 
		public Book Book { get; set; }

		public int PublisherId { get; set; }//fk to publisher relationship
		public Publisher Publisher { get; set; }
	}
}
