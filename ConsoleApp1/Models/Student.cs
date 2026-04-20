using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	[Table("Students",Schema ="edu")]
	internal class Student
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int StdId { get; set; }
		[MaxLength(100, ErrorMessage = "Cant be more than 100 char ")]
		[Required]
		[Column("STDFirstName")]
		public string FirstName { get; set; }
		[Column (TypeName = "varchar(100)")]
		[MaxLength(100, ErrorMessage = "Cant be more than 100 char ")]
		public string LastName { get; set; }
		[Range(16,30)]//validation hint
		public int Age { get; set; }
		[NotMapped]
		public string FullName  => $"{FirstName} {LastName}";


	}
}
