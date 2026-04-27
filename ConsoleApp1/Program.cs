using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

			#region Session01
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
			#endregion


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

			#region Seeddata
			//dbContext.Database.Migrate();

			//if (!dbContext.Customers.Any())
			//{

			//	{
			//	  dbContext.Customers.Add(new Customer(){Name="Customer 01"});
			//		  dbContext.Customers.Add(new Customer(){Name="Customer 02"});
			//dbContext.Customers.Add(new Customer(){Name="Customer 03"});

			//		int result= dbContext.SaveChanges();
			//		if(result != 0)
			//			Console.WriteLine("Customer data seed");
			//		else
			//			Console.WriteLine("Failed to seed");

			//	};




			//	} 
			#endregion

			#region Problem
			//var order= dbContext.Orders.FirstOrDefault(x=>x.OrderId == 1);	
			//if(order != null)
			//{
			//	Console.WriteLine($"OrderId= {order.OrderId}");
			//	Console.WriteLine($"OrderName {order.Name}");
			//	Console.WriteLine($"CusId = {order.CusId}");
			//	Console.WriteLine($"CusId= {order.OrderCustomer.CustomerId}");//ex
			//}

			//var order = dbContext.Orders.Select(o => new
			//{
			//	OrderId = o.OrderId,
			//	OrderName = o.Name,
			//	CusId = o.CusId,
			//	CusName = o.OrderCustomer.Name

			//}).FirstOrDefault(x=>x.OrderId==1);

			//if (order != null)
			//{
			//	Console.WriteLine($"OrderId= {order.OrderId}");
			//	Console.WriteLine($"OrderName {order.OrderName}");
			//	Console.WriteLine($"CusId = {order.CusId}");
			//	Console.WriteLine($"CusName= {order.CusName}");
			//}

			#endregion


			#region Include
			//var order = dbContext.Orders.Include(o=>o.OrderCustomer).FirstOrDefault(x => x.OrderId == 1);

			//if (order != null)
			//{
			//	Console.WriteLine($"OrderId= {order.OrderId}");
			//	Console.WriteLine($"OrderName {order.Name}");
			//	Console.WriteLine($"CusId = {order.CusId}");
			//	Console.WriteLine($"CusName= {order.OrderCustomer.Name}");
			//}

			//var customer= dbContext.Customers.Include(C=>C.Orders).Include(c=>c.CustomerServices).FirstOrDefault(x => x.CustomerId == 1);

			//if (customer != null)
			//{
			//	Console.WriteLine($"CustoemerId={customer.CustomerId}");
			//	Console.WriteLine($"CustomerOrder={customer.Orders.Count()}");
			//	Console.WriteLine($"CustomerService={customer.CustomerServices.Count()}");
			//}

			//var customer= dbContext.Customers.Include(x=>x.CustomerServices).ThenInclude(cs=>cs.Service).FirstOrDefault(x => x.CustomerId == 1);
			//if (customer != null)
			//{
			//	Console.WriteLine($"CustomerName={customer.Name}");
			//	Console.WriteLine($"Service {customer.CustomerServices.Count()}");
			//	foreach (var item in customer.CustomerServices)
			//	{
			//		Console.WriteLine($"ServiceName={item.Service.Name}");
			//	}
			//} 
			#endregion




			#region Explicitloading
			//var order = dbContext.Orders.FirstOrDefault(x => x.OrderId == 1);
			//if(order != null)
			//{
			//	Console.WriteLine($"order CustomerId {order.CusId}");
			//	//Console.WriteLine($"Customername = {order.OrderCustomer.Name}");
			//	dbContext.Entry(order).Reference(o=>o.OrderCustomer).Load();
			//	Console.WriteLine($"Customername = {order.OrderCustomer.Name}");


			//}



			//var customer = dbContext.Customers.FirstOrDefault(x => x.CustomerId == 1);
			//if (customer != null)
			//{
			//	Console.WriteLine($"CusName {customer.Name}");
			//	dbContext.Entry(customer).Collection(c => c.Orders).Load();
			//	foreach (var order in customer.Orders)
			//	{
			//		Console.WriteLine($"OrderName {order.Name}");
			//	}
			//}
			#endregion


			#region LAzy
			//var order = dbContext.Orders.FirstOrDefault(x => x.OrderId == 1);
			//if(order != null)
			//{
			//	Console.WriteLine($"Name {order.Name}");
			//	Console.WriteLine($"Order customername {order.OrderCustomer.Name}");
			//} 
			#endregion

			#region Inner Join 

			//var result = dbContext.Orders.Join(dbContext.Customers, o => o.CusId, c => c.CustomerId, (o, c) => new
			//{
			//	OrderName = o.Name,
			//	CustomerName = c.Name
			//});

			//result= from o in dbContext.Orders
			//		join C in dbContext.Customers
			//		on o.CusId equals C.CustomerId
			//		select new
			//		{
			//			OrderName = o.Name,
			//			CustomerName = C.Name
			//		};

			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);

			//}







			#endregion

			#region Group Join 

			#region Example 01


			//var result = dbContext.Customers.GroupJoin(dbContext.Orders, c => c.CustomerId, o => o.CusId, (c, o) => new
			//{
			//	customerName = c.Name,
			//	Orders = o
			//});

			//foreach (var item in result)
			//{
			//	Console.WriteLine(item.customerName);
			//	foreach (var order in item.Orders)
			//	{
			//		Console.WriteLine($"OrderName {order.Name}");
			//	}
			//}


			#endregion

			#region Example 02

			#endregion

			#region Query Syntax



			#endregion

			#endregion

			#region Left Join 

			//var result = dbContext.Customers.LeftJoin(dbContext.Orders, c => c.CustomerId, o => o.CusId, (c, o) => new
			//{
			//	Customername = c.Name,
			//	OrderNumber = o.OrderId

			//});


			#region Left Join Pre .Net 10



			//var result = dbContext.Customers.GroupJoin(dbContext.Orders, c => c.CustomerId, o => o.CusId, (c, o) => new
			//{
			//	customername= c.Name,
			//	orders=o
			//}).SelectMany(x => x.orders.DefaultIfEmpty(), (x, o) => new
			//{
			//	customername = x.customername,
			//	ordernumber= o==null?0 :o.OrderId
			//});


			//foreach (var item in result)
			//{
			//	Console.WriteLine($"CustomerName {item.customername} OrderNumber {item.ordernumber}");
			//}

			#endregion




			#endregion

			#region Cross Join 

			//var result= dbContext.Customers.SelectMany(c=>dbContext.Orders, (c, o) => new
			//{
			//	CustomerName = c.Name,
			//	OrderName = o.Name
			//});

			//result= from c in dbContext.Customers
			//		from o  in dbContext.Orders
			//		select new
			//		{
			//			CustomerName = c.Name,
			//			OrderName = o.Name
			//		};
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}



			#endregion















		}
	}
}
