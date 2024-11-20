using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(2770), new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(2782), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(2786), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(2983), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(2985), new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(2986), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(3068), new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(3069), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(3071), new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(3071), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(3073), new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(3073), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 11, 20, 11, 19, 12, 165, DateTimeKind.Local).AddTicks(3075), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
