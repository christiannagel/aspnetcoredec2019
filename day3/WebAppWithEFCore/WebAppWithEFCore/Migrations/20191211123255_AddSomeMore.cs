using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppWithEFCore.Migrations
{
    public partial class AddSomeMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bar",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foo",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bar",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Foo",
                table: "Books");
        }
    }
}
