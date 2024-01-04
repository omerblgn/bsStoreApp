using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14854c61-f5b7-4dfe-8039-9f73bcce7ab0", null, "Editor", "EDITOR" },
                    { "275c7de1-45cd-46a5-972d-dc8ad3e9250e", null, "User", "USER" },
                    { "d81311e2-4a0c-4f50-841d-ec07cd997341", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14854c61-f5b7-4dfe-8039-9f73bcce7ab0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "275c7de1-45cd-46a5-972d-dc8ad3e9250e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d81311e2-4a0c-4f50-841d-ec07cd997341");
        }
    }
}
