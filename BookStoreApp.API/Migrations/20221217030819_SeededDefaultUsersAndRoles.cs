using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06836fe7-4858-4972-b5e8-6ed92a768262", "d138360d-e10f-4b39-a56e-7d477c384853", "Administrator", "ADMINISTRATOR" },
                    { "eb9b500f-9ca8-481d-87af-3a8b8304805f", "f7e21e52-bd3a-43c3-a79e-fecb6622d726", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f555948-6eec-4c52-aaee-3b8cca367b78", 0, "54aabf39-5459-4736-b9cf-c8436d016918", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEFi+4M2ztoeYbDwJVhzqTxkgklW9f/QvlQivstSd/ESQSK1mwXK8jkr7+PH6yKJqfg==", null, false, "ddd91a84-691a-42e4-925a-3d29587f10fa", false, "admin@bookstore.com" },
                    { "bd2c7fa0-bed6-416f-aa54-f4eac00ad48e", 0, "60c57854-850d-441d-ad1d-759e1502a39f", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEE+nMsap1a3k/8wXyaSrTEtDAJzVupSMa3nMLPckgybF5EyMpyqKQGwaDpJMVfQ13w==", null, false, "d0b13d54-6d0a-439e-ae2a-7477ec831de1", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "06836fe7-4858-4972-b5e8-6ed92a768262", "0f555948-6eec-4c52-aaee-3b8cca367b78" },
                    { "eb9b500f-9ca8-481d-87af-3a8b8304805f", "bd2c7fa0-bed6-416f-aa54-f4eac00ad48e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06836fe7-4858-4972-b5e8-6ed92a768262", "0f555948-6eec-4c52-aaee-3b8cca367b78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eb9b500f-9ca8-481d-87af-3a8b8304805f", "bd2c7fa0-bed6-416f-aa54-f4eac00ad48e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06836fe7-4858-4972-b5e8-6ed92a768262");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9b500f-9ca8-481d-87af-3a8b8304805f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f555948-6eec-4c52-aaee-3b8cca367b78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd2c7fa0-bed6-416f-aa54-f4eac00ad48e");
        }
    }
}
