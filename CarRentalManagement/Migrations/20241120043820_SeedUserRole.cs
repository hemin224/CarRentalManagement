using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3344), new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3356), new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3534), new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3613), new DateTime(2024, 11, 20, 12, 38, 19, 890, DateTimeKind.Local).AddTicks(3614) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1067), new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1086), new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1352), new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1355), new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1478), new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1480), new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1482), new DateTime(2024, 11, 20, 12, 3, 7, 808, DateTimeKind.Local).AddTicks(1483) });
        }
    }
}
