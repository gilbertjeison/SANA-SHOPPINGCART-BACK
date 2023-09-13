using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SANA_SHOPPINGCART_BACK.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddImageField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(3120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1900), null, new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1900), null, new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2349) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4084), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4084), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7000), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7000), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6686) });
        }
    }
}
