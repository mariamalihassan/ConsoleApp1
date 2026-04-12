using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
        using  AppDbContext dbContext = new AppDbContext();

			//addmigration  ==> removemigration
			//update database==> remove migartion-force, Update-Databe 0


		//await	dbContext.Database.MigrateAsync();

   //         var user01= new User();
   //         dbContext.Users.Add(user01);
   //         dbContext.Users.Remove(user01);

   //         user01.Id = 20;

			//dbContext.SaveChanges();


			//        var optionbuilder= new DbContextOptionsBuilder<AppDbContext>();
			//        string env= Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Dev";
			//        if (env == "Dev")
			//optionbuilder.UseSqlServer("Server=.;Database=EfCore01;Trusted_Connection=true,TrustServerCertificate=true");
			//        using AppDbContext dbContext = new AppDbContext(optionbuilder.Options);

		}
    }
}
