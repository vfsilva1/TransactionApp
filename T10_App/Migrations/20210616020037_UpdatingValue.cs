using Microsoft.EntityFrameworkCore.Migrations;

namespace T10_App.Migrations
{
    public partial class UpdatingValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Transaction",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "Transaction",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
