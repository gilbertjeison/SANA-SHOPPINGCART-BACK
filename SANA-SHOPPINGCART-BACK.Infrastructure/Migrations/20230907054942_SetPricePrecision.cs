using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SANA_SHOPPINGCART_BACK.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SetPricePrecision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 632, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(4496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(4094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(3694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(3319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(6549));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(9452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(9102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 632, DateTimeKind.Local).AddTicks(79),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(9769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(7797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(7412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(8692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(8235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(6974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 45, 34, 631, DateTimeKind.Local).AddTicks(6549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(3319));
        }
    }
}
