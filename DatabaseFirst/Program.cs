using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using CityLibraryDbContext dbContext = new CityLibraryDbContext();
			//var publicationyear = "2010 or 1=1";
			//var result = dbContext.Books.FromSql($"Select * from Library.Books where PublicationYear > {publicationyear}").ToList();

			//foreach (var book in result) 
			//	Console.WriteLine(book.Title);


			//var result = dbContext.Set<AuthorsBook>().FromSql($"Exec SP_AuthorBooks").ToList();
			//foreach (var item in result)
			//	Console.WriteLine($"{item.AuthorName} - {item.CountOfBooks}");

//			string name = "Mohamed";
//			string nt= "Egyptian";
//			DateTime dob = DateTime.Now;


//			var  rowaff=dbContext.Database.ExecuteSql(@$"

//INSERT INTO [Library].[Authors]
//           ([FullName]
//           ,[Nationality]
//           ,[DateOfBirth])
//     VALUES
//           ({name},
//          {nt}
//           ,{dob})

//");

//			Console.WriteLine(rowaff);


			//var result= dbContext.Database.SqlQuery<BookInfo> ($"SELECT ISBN, Title FROM Library.Books").ToList();

		}
	}
}

public record BookInfo(string ISBN, string Title);
