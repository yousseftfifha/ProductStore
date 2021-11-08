using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class ClientFacture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Cin = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Cin);
                });

            migrationBuilder.CreateTable(
                name: "ClientProduct",
                columns: table => new
                {
                    ClientsCin = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProduct", x => new { x.ClientsCin, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_ClientProduct_Client_ClientsCin",
                        column: x => x.ClientsCin,
                        principalTable: "Client",
                        principalColumn: "Cin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientProduct_ProductsProductId",
                table: "ClientProduct",
                column: "ProductsProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientProduct");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
