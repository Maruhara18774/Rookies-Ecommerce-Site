using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations
{
    public partial class fixinsertconflict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategory_SubCategory_ID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Categories_Category_ID",
                table: "SubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory");

            migrationBuilder.RenameTable(
                name: "SubCategory",
                newName: "SubCategories");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategory_Category_ID",
                table: "SubCategories",
                newName: "IX_SubCategories_Category_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories",
                column: "SubCategory_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_SubCategory_ID",
                table: "Products",
                column: "SubCategory_ID",
                principalTable: "SubCategories",
                principalColumn: "SubCategory_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_Category_ID",
                table: "SubCategories",
                column: "Category_ID",
                principalTable: "Categories",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_SubCategory_ID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_Category_ID",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories");

            migrationBuilder.RenameTable(
                name: "SubCategories",
                newName: "SubCategory");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_Category_ID",
                table: "SubCategory",
                newName: "IX_SubCategory_Category_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory",
                column: "SubCategory_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategory_SubCategory_ID",
                table: "Products",
                column: "SubCategory_ID",
                principalTable: "SubCategory",
                principalColumn: "SubCategory_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Categories_Category_ID",
                table: "SubCategory",
                column: "Category_ID",
                principalTable: "Categories",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
