using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SANA_SHOPPINGCART_BACK.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeImagesExtension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 156, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(8340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(39),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(9060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(6897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(6897), new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(6897), new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(9060), new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(9060), new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2074), new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2074), new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1076), "smartphone.webp", new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1076), "laptop.webp", new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1076), "clock.webp", new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1076), "headphones.webp", new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1680) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 156, DateTimeKind.Local).AddTicks(447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(6499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(6499), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(6499), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 9, 12, 1, 23, 8, 156, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 9, 12, 1, 23, 8, 156, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935), "smartphone.png", new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935), "laptop.png", new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935), "clock.png", new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "Image", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935), "headphones.png", new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475) });
        }
    }
}
