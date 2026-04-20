using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

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


			using AppDbContext dbContext = new AppDbContext();
			#region Create

			//var employee01 = new Employee()
			//{
			//	Name = "Ahmed",
			//	Salary = 5000,
			//	HomeAddress = new Address()
			//	{
			//		City = "Cairo",
			//		Country = "Egypt",
			//		Street = "Nasr City"
			//	}
			//};
			//Console.WriteLine(dbContext.Entry(employee01).State);

			////dbContext.Employees.Add(employee01);//recomended 
			//dbContext.Set<Employee>().Add(employee01);
			////dbContext.Add(employee01);

			//Console.WriteLine(dbContext.Entry(employee01).State);

			//dbContext.SaveChanges();
			//Console.WriteLine(dbContext.Entry(employee01).State);

			#endregion

			#region Read

			//var employee01 = dbContext.Employees.AsNoTracking().FirstOrDefault(X=>X.EmpId==1);

			//if(employee01 != null)
			//{
			//	Console.WriteLine(employee01.Name);
			//	Console.WriteLine($"State = {dbContext.Entry(employee01).State}");
			//} 
			#endregion
			#region Update


			//var employee01 = dbContext.Employees.Find(1);
			//if (employee01 != null)
			//{
			//	Console.WriteLine($"State before updating = {dbContext.Entry(employee01).State}");
			//	employee01.Salary = 8000;
			//	dbContext.Update(employee01);
			//	Console.WriteLine($"State after updating = {dbContext.Entry(employee01).State}");
			//	dbContext.SaveChanges();
			//	Console.WriteLine($"State after saving = {dbContext.Entry(employee01).State}");
			//} 
			#endregion

			#region Delete
			//var employee01= dbContext.Employees.Find(1);
			//if (employee01 != null)
			//{
			//	Console.WriteLine($"State before remove {dbContext.Entry(employee01).State}");
			//	dbContext.Employees.Remove(employee01);
			//	//dbContext.Remove(employee01);
			//	//dbContext.Set<Employee>().Remove(employee01);

			//	//dbContext.Entry(employee01).State = EntityState.Deleted;
			//	Console.WriteLine($"State after remove {dbContext.Entry(employee01).State}");
			//	dbContext.SaveChanges();
			//	Console.WriteLine($"State after saving {dbContext.Entry(employee01).State}");
			//} 
			#endregion

			//var result = dbContext.Employees.Where(S=>S.Salary >5000).ExecuteUpdate(e=>e.SetProperty(p => p.Salary, p => p.Salary + 1000));
			//Console.WriteLine(result);

			#region CrudOverview
			//var employee = dbContext.Employees.FirstOrDefault(X => X.EmpId == 2);
			//if(employee != null)
			//{
			//	employee.Salary = 10000;
			//	Console.WriteLine($"State {dbContext.Entry(employee).State}");
			//	using AppDbContext newdbcontext = new();


			//	//newdbcontext.Employees.Update(employee);
			//	newdbcontext.Employees.Attach(employee);
			//	Console.WriteLine($"State {newdbcontext.Entry(employee).State}");


			//	newdbcontext.Entry(employee).Property(E=>E.Salary).IsModified = true;
			//	Console.WriteLine($"State {newdbcontext.Entry(employee).State}");

			//} 
			#endregion

			//dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
			//var employee01 = dbContext.Employees.FirstOrDefault(X => X.EmpId == 1);
			////////
			////////
			/////
			//dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
			////Tracked

			dbContext.Database.Migrate();

			if (!dbContext.Customers.Any())
			{
				
				{
				  dbContext.Customers.Add(new Customer(){Name="Customer 01"});
					  dbContext.Customers.Add(new Customer(){Name="Customer 02"});
	  dbContext.Customers.Add(new Customer(){Name="Customer 03"});

					int result= dbContext.SaveChanges();
					if(result != 0)
						Console.WriteLine("Customer data seed");
					else
						Console.WriteLine("Failed to seed");

				};




				}









		}
	}
}
