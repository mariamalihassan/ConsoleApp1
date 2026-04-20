using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class AppDbContext : DbContext
	{
		//public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		//{

		//}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;Database=EFCore01;Trusted_Connection=True;TrustServerCertificate = true");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>(
				entity =>
				{
					entity.ToTable("Employees").HasKey(e=>e.EmpId);
					entity.Property(E=>E.Name).IsRequired().HasMaxLength(100).HasColumnType("varchar")
					.HasColumnName("EmpName");

					entity.Property(e => e.Salary).HasColumnType("decimal(10,2)");

				}
				);

			modelBuilder.ApplyConfiguration(new CourseConfigration());
			modelBuilder.Entity<Test>().HasKey(x => x.TId);
			modelBuilder.Entity<Test>().Property(X => X.TId).UseIdentityColumn(10, 10);
			modelBuilder.Entity<Test>().Property(X => X.TId).ValueGeneratedOnAdd();

			#region oneToone

			//modelBuilder.Entity<Car>().HasOne(c => c.CarOwner)
			//	.WithOne(E => E.Car)

			//modelBuilder.Entity<Employee>().HasOne(E => E.EmployeeCar).WithOne(c => c.CarOwner).HasForeignKey<Car>(e=>e.EmpId);

			//modelBuilder.Entity<Car>().Property<int>("EmpId");//shadow property

			//modelBuilder.Entity<Employee>().HasOne<Car>().WithOne().HasForeignKey < Car>("EmpId");

			modelBuilder.Entity<Car>().ToTable("Employees").HasKey(c => c.EmpId);
			modelBuilder.Entity<Car>().HasOne(E => E.Employee).WithOne(c => c.Car).HasForeignKey<Car>(c => c.EmpId);

			modelBuilder.Entity<Customer>().HasMany(C=>C.Orders).WithOne(C=>C.OrderCustomer).HasForeignKey(O => O.CusId);

			modelBuilder.Entity<BookPublisher>().HasKey(x=>x.PublisherId);

			//modelBuilder.Entity<Customer>().HasMany(C => C.Services).WithMany(S => S.Customers)
			//	.UsingEntity(c =>
			//	{
			//		c.ToTable("CusService");
			//		c.Property<DateTime>("CreatedAt").HasDefaultValueSql("GETDATE()");

			//	}
			//	);

			modelBuilder.Entity<CustomerService>().HasKey(c=>new {c.CustomerId,c.ServiceId});
			modelBuilder.Entity<Employee>().HasOne(E=>E.Manager).WithMany()
				.HasForeignKey(E => E.ManagerId).OnDelete(DeleteBehavior.NoAction);
			#endregion


		}

		//public DbSet<User> Users { get; set; }
		//public DbSet<Product > Products { get; set; }
		//public DbSet<Student> StudentTable { get; set; }
		//public DbSet<Car> Cars { get; set; }
		//public DbSet<Employee> Employees { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Publisher> publishers { get; set; }
		public DbSet<Book> Books { get; set; }

		public DbSet<Service> Services { get; set; }
	}
}
