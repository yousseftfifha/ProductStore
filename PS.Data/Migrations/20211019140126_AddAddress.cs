using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class AddAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Products",
                newName: "Address_City");

            migrationBuilder.RenameColumn(
                name: "StreetAdress",
                table: "Products",
                newName: "Images");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Products",
                newName: "Address_StreetAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Products",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Images",
                table: "Products",
                newName: "StreetAdress");

            migrationBuilder.RenameColumn(
                name: "Address_StreetAddress",
                table: "Products",
                newName: "ImageName");
        }
    }
}
