using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DTO.Migrations
{
    public partial class fixerrorkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminLogs_Admins_Admin_ID1",
                table: "AdminLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Countries_Country_ID1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Customers_Customer_ID1",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_ProductDetails_ProductDetail_ID1",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_Order_ID1",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_Customer_ID1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStates_OrderState_ID1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_Product_ID1",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductDetails_ProductDetail_ID1",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Category_ID1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductStates_ProductState_ID1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Category_ID1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductState_ID1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductDetail_ID1",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_Product_ID1",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Customer_ID1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderState_ID1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Order_ID1",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_Customer_ID1",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_ProductDetail_ID1",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Country_ID1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_AdminLogs_Admin_ID1",
                table: "AdminLogs");

            migrationBuilder.DropColumn(
                name: "Category_ID1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductState_ID1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDetail_ID1",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "Product_ID1",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Customer_ID1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderState_ID1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Order_ID1",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Customer_ID1",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "ProductDetail_ID1",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Country_ID1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Admin_ID1",
                table: "AdminLogs");

            migrationBuilder.AlterColumn<int>(
                name: "ProductState_ID",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Category_ID",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetail_ID",
                table: "ProductImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Product_ID",
                table: "ProductDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderState_ID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Customer_ID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetail_ID",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Order_ID",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetail_ID",
                table: "Feedbacks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Customer_ID",
                table: "Feedbacks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Country_ID",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Admin_ID",
                table: "AdminLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "ChangeTime",
                table: "AdminLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_ID",
                table: "Products",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductState_ID",
                table: "Products",
                column: "ProductState_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductDetail_ID",
                table: "ProductImages",
                column: "ProductDetail_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Product_ID",
                table: "ProductDetails",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer_ID",
                table: "Orders",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderState_ID",
                table: "Orders",
                column: "OrderState_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Order_ID",
                table: "OrderDetails",
                column: "Order_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductDetail_ID",
                table: "OrderDetails",
                column: "ProductDetail_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Customer_ID",
                table: "Feedbacks",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ProductDetail_ID",
                table: "Feedbacks",
                column: "ProductDetail_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Country_ID",
                table: "Customers",
                column: "Country_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLogs_Admin_ID",
                table: "AdminLogs",
                column: "Admin_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminLogs_Admins_Admin_ID",
                table: "AdminLogs",
                column: "Admin_ID",
                principalTable: "Admins",
                principalColumn: "Admin_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Countries_Country_ID",
                table: "Customers",
                column: "Country_ID",
                principalTable: "Countries",
                principalColumn: "Country_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Customers_Customer_ID",
                table: "Feedbacks",
                column: "Customer_ID",
                principalTable: "Customers",
                principalColumn: "Customer_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_ProductDetails_ProductDetail_ID",
                table: "Feedbacks",
                column: "ProductDetail_ID",
                principalTable: "ProductDetails",
                principalColumn: "ProductDetail_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_Order_ID",
                table: "OrderDetails",
                column: "Order_ID",
                principalTable: "Orders",
                principalColumn: "Order_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductDetails_ProductDetail_ID",
                table: "OrderDetails",
                column: "ProductDetail_ID",
                principalTable: "ProductDetails",
                principalColumn: "ProductDetail_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_Customer_ID",
                table: "Orders",
                column: "Customer_ID",
                principalTable: "Customers",
                principalColumn: "Customer_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStates_OrderState_ID",
                table: "Orders",
                column: "OrderState_ID",
                principalTable: "OrderStates",
                principalColumn: "OrderState_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_Product_ID",
                table: "ProductDetails",
                column: "Product_ID",
                principalTable: "Products",
                principalColumn: "Product_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductDetails_ProductDetail_ID",
                table: "ProductImages",
                column: "ProductDetail_ID",
                principalTable: "ProductDetails",
                principalColumn: "ProductDetail_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Category_ID",
                table: "Products",
                column: "Category_ID",
                principalTable: "Categories",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductStates_ProductState_ID",
                table: "Products",
                column: "ProductState_ID",
                principalTable: "ProductStates",
                principalColumn: "ProductState_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminLogs_Admins_Admin_ID",
                table: "AdminLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Countries_Country_ID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Customers_Customer_ID",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_ProductDetails_ProductDetail_ID",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_Order_ID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductDetails_ProductDetail_ID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_Customer_ID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStates_OrderState_ID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_Product_ID",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductDetails_ProductDetail_ID",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Category_ID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductStates_ProductState_ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Category_ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductState_ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductDetail_ID",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_Product_ID",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Customer_ID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderState_ID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Order_ID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductDetail_ID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_Customer_ID",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_ProductDetail_ID",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Country_ID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_AdminLogs_Admin_ID",
                table: "AdminLogs");

            migrationBuilder.DropColumn(
                name: "ChangeTime",
                table: "AdminLogs");

            migrationBuilder.AlterColumn<int>(
                name: "ProductState_ID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Category_ID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category_ID1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductState_ID1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetail_ID",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDetail_ID1",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Product_ID",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product_ID1",
                table: "ProductDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderState_ID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Customer_ID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Customer_ID1",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderState_ID1",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetail_ID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Order_ID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order_ID1",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetail_ID",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Customer_ID",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Customer_ID1",
                table: "Feedbacks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDetail_ID1",
                table: "Feedbacks",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Country_ID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Country_ID1",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Admin_ID",
                table: "AdminLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Admin_ID1",
                table: "AdminLogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_ID1",
                table: "Products",
                column: "Category_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductState_ID1",
                table: "Products",
                column: "ProductState_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductDetail_ID1",
                table: "ProductImages",
                column: "ProductDetail_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Product_ID1",
                table: "ProductDetails",
                column: "Product_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer_ID1",
                table: "Orders",
                column: "Customer_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderState_ID1",
                table: "Orders",
                column: "OrderState_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Order_ID1",
                table: "OrderDetails",
                column: "Order_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Customer_ID1",
                table: "Feedbacks",
                column: "Customer_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ProductDetail_ID1",
                table: "Feedbacks",
                column: "ProductDetail_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Country_ID1",
                table: "Customers",
                column: "Country_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_AdminLogs_Admin_ID1",
                table: "AdminLogs",
                column: "Admin_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminLogs_Admins_Admin_ID1",
                table: "AdminLogs",
                column: "Admin_ID1",
                principalTable: "Admins",
                principalColumn: "Admin_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Countries_Country_ID1",
                table: "Customers",
                column: "Country_ID1",
                principalTable: "Countries",
                principalColumn: "Country_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Customers_Customer_ID1",
                table: "Feedbacks",
                column: "Customer_ID1",
                principalTable: "Customers",
                principalColumn: "Customer_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_ProductDetails_ProductDetail_ID1",
                table: "Feedbacks",
                column: "ProductDetail_ID1",
                principalTable: "ProductDetails",
                principalColumn: "ProductDetail_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_Order_ID1",
                table: "OrderDetails",
                column: "Order_ID1",
                principalTable: "Orders",
                principalColumn: "Order_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_Customer_ID1",
                table: "Orders",
                column: "Customer_ID1",
                principalTable: "Customers",
                principalColumn: "Customer_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStates_OrderState_ID1",
                table: "Orders",
                column: "OrderState_ID1",
                principalTable: "OrderStates",
                principalColumn: "OrderState_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_Product_ID1",
                table: "ProductDetails",
                column: "Product_ID1",
                principalTable: "Products",
                principalColumn: "Product_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductDetails_ProductDetail_ID1",
                table: "ProductImages",
                column: "ProductDetail_ID1",
                principalTable: "ProductDetails",
                principalColumn: "ProductDetail_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Category_ID1",
                table: "Products",
                column: "Category_ID1",
                principalTable: "Categories",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductStates_ProductState_ID1",
                table: "Products",
                column: "ProductState_ID1",
                principalTable: "ProductStates",
                principalColumn: "ProductState_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
