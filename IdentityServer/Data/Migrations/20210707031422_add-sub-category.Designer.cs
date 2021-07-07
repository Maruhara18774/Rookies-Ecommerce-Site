﻿// <auto-generated />
using System;
using IdentityServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentityServer.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210707031422_add-sub-category")]
    partial class addsubcategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer.Data.Models.Admin", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.AdminLog", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.Category", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.Country", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Country_ID");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Feedback", b =>
                {
                    b.Property<int>("Feedback_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductDetail_ID");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Order", b =>
                {
                    b.Property<int>("Order_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("OrderState_ID")
                        .HasColumnType("int");

                    b.Property<double>("Order_Total")
                        .HasColumnType("float");

                    b.HasKey("Order_ID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderState_ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.OrderDetail", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.OrderState", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.Product", b =>
                {
                    b.Property<int>("Product_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductState_ID")
                        .HasColumnType("int");

                    b.Property<string>("Product_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Product_Price")
                        .HasColumnType("float");

                    b.Property<int?>("SubCategory_ID")
                        .HasColumnType("int");

                    b.HasKey("Product_ID");

                    b.HasIndex("ProductState_ID");

                    b.HasIndex("SubCategory_ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.ProductDetail", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.ProductImage", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.ProductState", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.Size", b =>
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

            modelBuilder.Entity("IdentityServer.Data.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategory_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Category_ID")
                        .HasColumnType("int");

                    b.Property<string>("SubCategory_Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SubCategory_ID");

                    b.HasIndex("Category_ID");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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

            modelBuilder.Entity("IdentityServer.Data.Models.AdminLog", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Admin", "Admin")
                        .WithMany("AdminLogs")
                        .HasForeignKey("Admin_ID");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Customer", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Country", "Country")
                        .WithMany("Customers")
                        .HasForeignKey("Country_ID");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Feedback", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Customer", "Customer")
                        .WithMany("Feedbacks")
                        .HasForeignKey("CustomerId");

                    b.HasOne("IdentityServer.Data.Models.ProductDetail", "ProductDetail")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductDetail_ID");

                    b.Navigation("Customer");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Order", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("IdentityServer.Data.Models.OrderState", "OrderState")
                        .WithMany("Orders")
                        .HasForeignKey("OrderState_ID");

                    b.Navigation("Customer");

                    b.Navigation("OrderState");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Order_ID");

                    b.HasOne("IdentityServer.Data.Models.ProductDetail", "ProductDetail")
                        .WithMany()
                        .HasForeignKey("ProductDetail_ID");

                    b.Navigation("Order");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Product", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.ProductState", "ProductState")
                        .WithMany("Products")
                        .HasForeignKey("ProductState_ID");

                    b.HasOne("IdentityServer.Data.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategory_ID");

                    b.Navigation("ProductState");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.ProductDetail", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Product_ID");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.ProductImage", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.ProductDetail", "ProductDetail")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductDetail_ID");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.SubCategory", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("Category_ID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IdentityServer.Data.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductSize", b =>
                {
                    b.HasOne("IdentityServer.Data.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProduct_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IdentityServer.Data.Models.Size", null)
                        .WithMany()
                        .HasForeignKey("SizesSize_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Admin", b =>
                {
                    b.Navigation("AdminLogs");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Country", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Customer", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.OrderState", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.ProductDetail", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.ProductState", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("IdentityServer.Data.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}