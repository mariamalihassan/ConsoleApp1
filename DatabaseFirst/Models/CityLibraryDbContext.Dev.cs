using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Models
{
	public partial class CityLibraryDbContext
	{
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<AuthorsBook>(b =>
			{
				b.HasNoKey();
				b.ToTable((string)null);
			});

			modelBuilder.Entity<BookWithCatAndAuthor>().HasNoKey().ToView("BookWithCatAndAuthor");
		}
	}
}
