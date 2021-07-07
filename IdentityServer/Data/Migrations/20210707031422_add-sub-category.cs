using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations
{
    public partial class addsubcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Category_ID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Category_ID",
                table: "Products",
                newName: "SubCategory_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Category_ID",
                table: "Products",
                newName: "IX_Products_SubCategory_ID");

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    SubCategory_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategory_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Category_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.SubCategory_ID);
                    table.ForeignKey(
                        name: "FK_SubCategory_Categories_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "Categories",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_Category_ID",
                table: "SubCategory",
                column: "Category_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategory_SubCategory_ID",
                table: "Products",
                column: "SubCategory_ID",
                principalTable: "SubCategory",
                principalColumn: "SubCategory_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategory_SubCategory_ID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.RenameColumn(
                name: "SubCategory_ID",
                table: "Products",
                newName: "Category_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SubCategory_ID",
                table: "Products",
                newName: "IX_Products_Category_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Category_ID",
                table: "Products",
                column: "Category_ID",
                principalTable: "Categories",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
