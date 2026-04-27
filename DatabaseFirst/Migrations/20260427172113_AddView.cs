using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view BookWithCatView 
as
select  B.Title [BookTitle] , A.FullName [AuthorName] ,B.BookCategory
from Library.Books  B, Library .Books_Authors BA, Library.Authors A 
where B.ISBN= BA.BookISBN and A.Id= BA.AuthorId")
                ;
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

			migrationBuilder.Sql(@"drop view BookWithCatView");
		}
    }
}
