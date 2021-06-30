using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DTO.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Admin_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin_Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admin_Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Admin_ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Country_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Country_ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderStates",
                columns: table => new
                {
                    OrderState_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderState_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStates", x => x.OrderState_ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductStates",
                columns: table => new
                {
                    ProductState_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductState_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStates", x => x.ProductState_ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Size_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size_Key = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Size_ID);
                });

            migrationBuilder.CreateTable(
                name: "AdminLogs",
                columns: table => new
                {
                    Log_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin_ID = table.Column<int>(type: "int", nullable: false),
                    Log_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admin_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminLogs", x => x.Log_ID);
                    table.ForeignKey(
                        name: "FK_AdminLogs_Admins_Admin_ID1",
                        column: x => x.Admin_ID1,
                        principalTable: "Admins",
                        principalColumn: "Admin_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customer_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Customer_LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Customer_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country_ID = table.Column<int>(type: "int", nullable: false),
                    Customer_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_ID);
                    table.ForeignKey(
                        name: "FK_Customers_Countries_Country_ID1",
                        column: x => x.Country_ID1,
                        principalTable: "Countries",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Product_Price = table.Column<double>(type: "float", nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_ID = table.Column<int>(type: "int", nullable: false),
                    ProductState_ID = table.Column<int>(type: "int", nullable: false),
                    Category_ID1 = table.Column<int>(type: "int", nullable: true),
                    ProductState_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Category_ID1",
                        column: x => x.Category_ID1,
                        principalTable: "Categories",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductStates_ProductState_ID1",
                        column: x => x.ProductState_ID1,
                        principalTable: "ProductStates",
                        principalColumn: "ProductState_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Order_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Order_Total = table.Column<double>(type: "float", nullable: false),
                    OrderState_ID = table.Column<int>(type: "int", nullable: false),
                    Customer_ID1 = table.Column<int>(type: "int", nullable: true),
                    OrderState_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Order_ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_Customer_ID1",
                        column: x => x.Customer_ID1,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStates_OrderState_ID1",
                        column: x => x.OrderState_ID1,
                        principalTable: "OrderStates",
                        principalColumn: "OrderState_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductDetail_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texture_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Texture_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDetail_Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductDetail_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductDetail_UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Product_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductDetail_ID);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_Product_ID1",
                        column: x => x.Product_ID1,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    ProductsProduct_ID = table.Column<int>(type: "int", nullable: false),
                    SizesSize_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => new { x.ProductsProduct_ID, x.SizesSize_ID });
                    table.ForeignKey(
                        name: "FK_ProductSize_Products_ProductsProduct_ID",
                        column: x => x.ProductsProduct_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSize_Sizes_SizesSize_ID",
                        column: x => x.SizesSize_ID,
                        principalTable: "Sizes",
                        principalColumn: "Size_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetail_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_ID = table.Column<int>(type: "int", nullable: false),
                    ProductDetail_ID = table.Column<int>(type: "int", nullable: false),
                    OrderDetail_Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderDetail_Total = table.Column<double>(type: "float", nullable: false),
                    Order_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetail_ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_Order_ID1",
                        column: x => x.Order_ID1,
                        principalTable: "Orders",
                        principalColumn: "Order_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Feedback_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDetail_ID = table.Column<int>(type: "int", nullable: false),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Feedback_Rating = table.Column<int>(type: "int", nullable: false),
                    Feedback_Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Feedback_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer_ID1 = table.Column<int>(type: "int", nullable: true),
                    ProductDetail_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Feedback_ID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Customers_Customer_ID1",
                        column: x => x.Customer_ID1,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feedbacks_ProductDetails_ProductDetail_ID1",
                        column: x => x.ProductDetail_ID1,
                        principalTable: "ProductDetails",
                        principalColumn: "ProductDetail_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImage_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductImage_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDetail_ID = table.Column<int>(type: "int", nullable: false),
                    ProductDetail_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImage_ID);
                    table.ForeignKey(
                        name: "FK_ProductImages_ProductDetails_ProductDetail_ID1",
                        column: x => x.ProductDetail_ID1,
                        principalTable: "ProductDetails",
                        principalColumn: "ProductDetail_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminLogs_Admin_ID1",
                table: "AdminLogs",
                column: "Admin_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Country_ID1",
                table: "Customers",
                column: "Country_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Customer_ID1",
                table: "Feedbacks",
                column: "Customer_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ProductDetail_ID1",
                table: "Feedbacks",
                column: "ProductDetail_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Order_ID1",
                table: "OrderDetails",
                column: "Order_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer_ID1",
                table: "Orders",
                column: "Customer_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderState_ID1",
                table: "Orders",
                column: "OrderState_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Product_ID1",
                table: "ProductDetails",
                column: "Product_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductDetail_ID1",
                table: "ProductImages",
                column: "ProductDetail_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_ID1",
                table: "Products",
                column: "Category_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductState_ID1",
                table: "Products",
                column: "ProductState_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_SizesSize_ID",
                table: "ProductSize",
                column: "SizesSize_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminLogs");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderStates");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductStates");
        }
    }
}
