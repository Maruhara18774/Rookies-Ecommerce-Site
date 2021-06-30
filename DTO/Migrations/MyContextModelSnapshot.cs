﻿// <auto-generated />
using System;
using DTO.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DTO.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DTO.Model.Admin", b =>
                {
                    b.Property<int>("Admin_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Admin_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Admin_Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Admin_ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DTO.Model.AdminLog", b =>
                {
                    b.Property<int>("Log_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Admin_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ChangeTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Log_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Log_ID");

                    b.HasIndex("Admin_ID");

                    b.ToTable("AdminLogs");
                });

            modelBuilder.Entity("DTO.Model.Category", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category_Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Category_ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DTO.Model.Country", b =>
                {
                    b.Property<int>("Country_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country_Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Country_ID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DTO.Model.Customer", b =>
                {
                    b.Property<int>("Customer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Country_ID")
                        .HasColumnType("int");

                    b.Property<string>("Customer_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Customer_LastName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Customer_PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_ID");

                    b.HasIndex("Country_ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DTO.Model.Feedback", b =>
                {
                    b.Property<int>("Feedback_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<string>("Feedback_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Feedback_Rating")
                        .HasColumnType("int");

                    b.Property<string>("Feedback_Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProductDetail_ID")
                        .HasColumnType("int");

                    b.HasKey("Feedback_ID");

                    b.HasIndex("Customer_ID");

                    b.HasIndex("ProductDetail_ID");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("DTO.Model.Order", b =>
                {
                    b.Property<int>("Order_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderState_ID")
                        .HasColumnType("int");

                    b.Property<double>("Order_Total")
                        .HasColumnType("float");

                    b.HasKey("Order_ID");

                    b.HasIndex("Customer_ID");

                    b.HasIndex("OrderState_ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DTO.Model.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetail_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderDetail_Quantity")
                        .HasColumnType("int");

                    b.Property<double>("OrderDetail_Total")
                        .HasColumnType("float");

                    b.Property<int?>("Order_ID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductDetail_ID")
                        .HasColumnType("int");

                    b.HasKey("OrderDetail_ID");

                    b.HasIndex("Order_ID");

                    b.HasIndex("ProductDetail_ID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DTO.Model.OrderState", b =>
                {
                    b.Property<int>("OrderState_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderState_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderState_ID");

                    b.ToTable("OrderStates");
                });

            modelBuilder.Entity("DTO.Model.Product", b =>
                {
                    b.Property<int>("Product_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Category_ID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductState_ID")
                        .HasColumnType("int");

                    b.Property<string>("Product_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Product_Price")
                        .HasColumnType("float");

                    b.HasKey("Product_ID");

                    b.HasIndex("Category_ID");

                    b.HasIndex("ProductState_ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DTO.Model.ProductDetail", b =>
                {
                    b.Property<int>("ProductDetail_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ProductDetail_CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductDetail_Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductDetail_UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Product_ID")
                        .HasColumnType("int");

                    b.Property<string>("Texture_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Texture_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductDetail_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("DTO.Model.ProductImage", b =>
                {
                    b.Property<int>("ProductImage_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductDetail_ID")
                        .HasColumnType("int");

                    b.Property<string>("ProductImage_Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductImage_ID");

                    b.HasIndex("ProductDetail_ID");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("DTO.Model.ProductState", b =>
                {
                    b.Property<int>("ProductState_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductState_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductState_ID");

                    b.ToTable("ProductStates");
                });

            modelBuilder.Entity("DTO.Model.Size", b =>
                {
                    b.Property<int>("Size_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Size_Key")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Size_ID");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("ProductSize", b =>
                {
                    b.Property<int>("ProductsProduct_ID")
                        .HasColumnType("int");

                    b.Property<int>("SizesSize_ID")
                        .HasColumnType("int");

                    b.HasKey("ProductsProduct_ID", "SizesSize_ID");

                    b.HasIndex("SizesSize_ID");

                    b.ToTable("ProductSize");
                });

            modelBuilder.Entity("DTO.Model.AdminLog", b =>
                {
                    b.HasOne("DTO.Model.Admin", "Admin")
                        .WithMany("AdminLogs")
                        .HasForeignKey("Admin_ID");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("DTO.Model.Customer", b =>
                {
                    b.HasOne("DTO.Model.Country", "Country")
                        .WithMany("Customers")
                        .HasForeignKey("Country_ID");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DTO.Model.Feedback", b =>
                {
                    b.HasOne("DTO.Model.Customer", "Customer")
                        .WithMany("Feedbacks")
                        .HasForeignKey("Customer_ID");

                    b.HasOne("DTO.Model.ProductDetail", "ProductDetail")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductDetail_ID");

                    b.Navigation("Customer");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("DTO.Model.Order", b =>
                {
                    b.HasOne("DTO.Model.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_ID");

                    b.HasOne("DTO.Model.OrderState", "OrderState")
                        .WithMany("Orders")
                        .HasForeignKey("OrderState_ID");

                    b.Navigation("Customer");

                    b.Navigation("OrderState");
                });

            modelBuilder.Entity("DTO.Model.OrderDetail", b =>
                {
                    b.HasOne("DTO.Model.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Order_ID");

                    b.HasOne("DTO.Model.ProductDetail", "ProductDetail")
                        .WithMany()
                        .HasForeignKey("ProductDetail_ID");

                    b.Navigation("Order");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("DTO.Model.Product", b =>
                {
                    b.HasOne("DTO.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_ID");

                    b.HasOne("DTO.Model.ProductState", "ProductState")
                        .WithMany("Products")
                        .HasForeignKey("ProductState_ID");

                    b.Navigation("Category");

                    b.Navigation("ProductState");
                });

            modelBuilder.Entity("DTO.Model.ProductDetail", b =>
                {
                    b.HasOne("DTO.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Product_ID");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DTO.Model.ProductImage", b =>
                {
                    b.HasOne("DTO.Model.ProductDetail", "ProductDetail")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductDetail_ID");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("ProductSize", b =>
                {
                    b.HasOne("DTO.Model.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProduct_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.Model.Size", null)
                        .WithMany()
                        .HasForeignKey("SizesSize_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DTO.Model.Admin", b =>
                {
                    b.Navigation("AdminLogs");
                });

            modelBuilder.Entity("DTO.Model.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DTO.Model.Country", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("DTO.Model.Customer", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("DTO.Model.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("DTO.Model.OrderState", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DTO.Model.ProductDetail", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("DTO.Model.ProductState", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
