using Microsoft.EntityFrameworkCore.Migrations;

namespace books.Migrations
{
    public partial class addednewusercolumnssuchasaddresscitystatezipandusernamepasswordemailfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "City",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "State",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "employee");
        }
    }
}
