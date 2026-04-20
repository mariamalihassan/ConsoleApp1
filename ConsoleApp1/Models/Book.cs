using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class Book
	{
		public int Id { get; set; }
		public string Title { get; set; } = default!;

		public ICollection<BookPublisher> BookPublisher { get; set; }= new HashSet<BookPublisher>();
		
	
	}
}
