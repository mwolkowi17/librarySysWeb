using Microsoft.EntityFrameworkCore.Migrations;

namespace LibrarySysWeb.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Rented",
                table: "BookB",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RentedbyReader",
                table: "BookB",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rented",
                table: "BookB");

            migrationBuilder.DropColumn(
                name: "RentedbyReader",
                table: "BookB");
        }
    }
}
