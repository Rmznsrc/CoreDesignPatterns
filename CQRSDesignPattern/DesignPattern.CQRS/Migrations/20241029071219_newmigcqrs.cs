using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPattern.CQRS.Migrations
{
    public partial class newmigcqrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produts",
                table: "Produts");

            migrationBuilder.RenameTable(
                name: "Produts",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Produts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produts",
                table: "Produts",
                column: "ProductID");
        }
    }
}
