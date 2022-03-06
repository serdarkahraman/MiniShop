using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniShop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    CustomerType = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IsRatePercentage = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "TEXT", maxLength: 20, nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Created", "CustomerType", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, "1", new DateTime(1989, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1435), "Employee", "serdar@kahraman.com", "Serdar", "Kahraman", "05324480153" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Created", "CustomerType", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2, "1", new DateTime(2019, 11, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1440), "Affiliate", "sevgi@kahraman.com", "Sevgi", "Kahraman", "05324480154" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Created", "CustomerType", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 3, "1", new DateTime(2018, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1443), "Customer", "alya@kahraman.com", "Alya", "Kahraman", "05324480155" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Created", "CustomerType", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 4, "1", new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1445), "Customer", "alparslan@kahraman.com", "Alparslan", "Kahraman", "05324480156" });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "IsRatePercentage", "Name", "Rate", "Type" },
                values: new object[] { 1, true, "Affiliate Discount", 10m, "Affiliate" });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "IsRatePercentage", "Name", "Rate", "Type" },
                values: new object[] { 2, true, "Employee Discount", 30m, "Employee" });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "IsRatePercentage", "Name", "Rate", "Type" },
                values: new object[] { 3, true, "Customer Discount", 5m, "Customer" });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "IsRatePercentage", "Name", "Rate", "Type" },
                values: new object[] { 4, false, "Price Discount", 5m, "Price" });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "Created", "CustomerId", "InvoiceNumber", "OrderId", "OrderTotal", "Total" },
                values: new object[] { 1, new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1861), 1, "Ms01", 1, 0m, 100m });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "Created", "CustomerId", "InvoiceNumber", "OrderId", "OrderTotal", "Total" },
                values: new object[] { 2, new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1863), 2, "Ms02", 2, 0m, 200m });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "Created", "CustomerId", "InvoiceNumber", "OrderId", "OrderTotal", "Total" },
                values: new object[] { 3, new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1864), 3, "Ms03", 3, 0m, 300m });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "Created", "CustomerId", "InvoiceNumber", "OrderId", "OrderTotal", "Total" },
                values: new object[] { 4, new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1865), 4, "Ms04", 4, 0m, 400m });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "Quantity" },
                values: new object[] { 1, 1m, 1, 1, "Ürün 1", 10m, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "Quantity" },
                values: new object[] { 2, 2m, 1, 2, "Ürün 2", 20m, 2 });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "Quantity" },
                values: new object[] { 3, 3m, 2, 3, "Ürün 3", 30m, 3 });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "Quantity" },
                values: new object[] { 4, 4m, 3, 4, "Ürün 4", 40m, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_InvoiceId",
                table: "InvoiceDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountType");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
