using Microsoft.EntityFrameworkCore.Migrations;

namespace BookList.Migrations
{
    public partial class updateNameProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "books",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");
        }
    }
}
