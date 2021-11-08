using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class InvoiceClientAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Cin");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    clientFk = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    dateAchat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductFK = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => new { x.clientFk, x.ProductFK, x.dateAchat });
                    table.ForeignKey(
                        name: "FK_Invoices_Clients_clientFk",
                        column: x => x.clientFk,
                        principalTable: "Clients",
                        principalColumn: "Cin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Products_ProductFK",
                        column: x => x.ProductFK,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProductFK",
                table: "Invoices",
                column: "ProductFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Cin");

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
    }
}
