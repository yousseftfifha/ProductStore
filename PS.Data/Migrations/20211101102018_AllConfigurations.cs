using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class AllConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Products_ListProductsProductId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_ListProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "ProductProvider",
                newName: "associationProdProv");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "MyCategories");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "MyName");

            migrationBuilder.RenameColumn(
                name: "Address_StreetAddress",
                table: "Products",
                newName: "MyAddress");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Products",
                newName: "MyCity");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_ListProvidersId",
                table: "associationProdProv",
                newName: "IX_associationProdProv_ListProvidersId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MyCategories",
                newName: "MyName");

            migrationBuilder.AlterColumn<string>(
                name: "MyAddress",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MyName",
                table: "MyCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_associationProdProv",
                table: "associationProdProv",
                columns: new[] { "ListProductsProductId", "ListProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_associationProdProv_Products_ListProductsProductId",
                table: "associationProdProv",
                column: "ListProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_associationProdProv_Providers_ListProvidersId",
                table: "associationProdProv",
                column: "ListProvidersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MyCategories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "MyCategories",
                principalColumn: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_associationProdProv_Products_ListProductsProductId",
                table: "associationProdProv");

            migrationBuilder.DropForeignKey(
                name: "FK_associationProdProv_Providers_ListProvidersId",
                table: "associationProdProv");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MyCategories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_associationProdProv",
                table: "associationProdProv");

            migrationBuilder.RenameTable(
                name: "MyCategories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "associationProdProv",
                newName: "ProductProvider");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MyCity",
                table: "Products",
                newName: "Address_City");

            migrationBuilder.RenameColumn(
                name: "MyAddress",
                table: "Products",
                newName: "Address_StreetAddress");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_associationProdProv_ListProvidersId",
                table: "ProductProvider",
                newName: "IX_ProductProvider_ListProvidersId");

            migrationBuilder.AlterColumn<string>(
                name: "Address_StreetAddress",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider",
                columns: new[] { "ListProductsProductId", "ListProvidersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Products_ListProductsProductId",
                table: "ProductProvider",
                column: "ListProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_ListProvidersId",
                table: "ProductProvider",
                column: "ListProvidersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
