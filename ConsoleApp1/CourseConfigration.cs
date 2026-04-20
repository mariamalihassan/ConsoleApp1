using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class CourseConfigration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.ToTable("Courses");
			builder.HasKey(c => c.Id);

			builder.Property(C => C.Credit).HasDefaultValue(1000);
			builder.Property(c => c.CourseTime).HasDefaultValueSql("GETDATE()");
		}
	}
}
