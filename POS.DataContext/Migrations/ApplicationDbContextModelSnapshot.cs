﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POS.Repository;

#nullable disable

namespace POS.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("POS.Repository.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("POS.Repository.CustomerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("company_name");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact_name");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact_title");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("country");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("fax");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int")
                        .HasColumnName("postal_code");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("region");

                    b.HasKey("Id");

                    b.ToTable("tbl_customer");
                });

            modelBuilder.Entity("POS.Repository.EmployeeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birth_date");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("country");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("extension");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("hire_date");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("home_phone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("notes");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("photo_path");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("postal_code");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("region");

                    b.Property<int>("ReportsTo")
                        .HasColumnType("int")
                        .HasColumnName("reports_to");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.Property<string>("TitleOfCourtesy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title_of_courtesy");

                    b.HasKey("Id");

                    b.ToTable("tbl_employee");
                });

            modelBuilder.Entity("POS.Repository.OrderDetailEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<double>("Discount")
                        .HasColumnType("double")
                        .HasColumnName("discount");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double")
                        .HasColumnName("unit_price");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("tbl_order_detail");
                });

            modelBuilder.Entity("POS.Repository.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<int>("Freight")
                        .HasColumnType("int")
                        .HasColumnName("freight");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("order_date");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("required_date");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_address");

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_city");

                    b.Property<string>("ShipCountry")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_country");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_name");

                    b.Property<string>("ShipPostalCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_postal_code");

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_region");

                    b.Property<int>("ShipVia")
                        .HasColumnType("int")
                        .HasColumnName("ship_via");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("shipped_date");

                    b.Property<int>("ShipperId")
                        .HasColumnType("int")
                        .HasColumnName("shipper_id");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ShipperId");

                    b.ToTable("tbl_order");
                });

            modelBuilder.Entity("POS.Repository.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("discontinued");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("product_name");

                    b.Property<int>("QuantityPerUnit")
                        .HasColumnType("int")
                        .HasColumnName("quantity_per_unit");

                    b.Property<long>("ReorderLevel")
                        .HasColumnType("bigint")
                        .HasColumnName("reorder_level");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("supplier_id");

                    b.Property<long>("UnitInStock")
                        .HasColumnType("bigint")
                        .HasColumnName("unit_in_stock");

                    b.Property<long>("UnitOnOrder")
                        .HasColumnType("bigint")
                        .HasColumnName("unit_on_order");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double")
                        .HasColumnName("unit_price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("tbl_product");
                });

            modelBuilder.Entity("POS.Repository.ShipperEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("company_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("tbl_shipper");
                });

            modelBuilder.Entity("POS.Repository.SupplierEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("company_name");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact_name");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact_title");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("country");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("fax");

                    b.Property<string>("HomePage")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("home_page");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("postal_code");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("region");

                    b.HasKey("Id");

                    b.ToTable("tbl_supplier");
                });

            modelBuilder.Entity("POS.Repository.OrderDetailEntity", b =>
                {
                    b.HasOne("POS.Repository.OrderEntity", "Order")
                        .WithMany("orderDetailsEntities")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("POS.Repository.ProductEntity", "Product")
                        .WithMany("orderDetailsEntities")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("POS.Repository.OrderEntity", b =>
                {
                    b.HasOne("POS.Repository.CustomerEntity", "Customer")
                        .WithMany("ordersEntities")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("POS.Repository.EmployeeEntity", "Employee")
                        .WithMany("ordersEntities")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("POS.Repository.ShipperEntity", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("POS.Repository.ProductEntity", b =>
                {
                    b.HasOne("POS.Repository.CategoryEntity", "Category")
                        .WithMany("productEntities")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("POS.Repository.SupplierEntity", "Supplier")
                        .WithMany("productEntities")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("POS.Repository.CategoryEntity", b =>
                {
                    b.Navigation("productEntities");
                });

            modelBuilder.Entity("POS.Repository.CustomerEntity", b =>
                {
                    b.Navigation("ordersEntities");
                });

            modelBuilder.Entity("POS.Repository.EmployeeEntity", b =>
                {
                    b.Navigation("ordersEntities");
                });

            modelBuilder.Entity("POS.Repository.OrderEntity", b =>
                {
                    b.Navigation("orderDetailsEntities");
                });

            modelBuilder.Entity("POS.Repository.ProductEntity", b =>
                {
                    b.Navigation("orderDetailsEntities");
                });

            modelBuilder.Entity("POS.Repository.ShipperEntity", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("POS.Repository.SupplierEntity", b =>
                {
                    b.Navigation("productEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
