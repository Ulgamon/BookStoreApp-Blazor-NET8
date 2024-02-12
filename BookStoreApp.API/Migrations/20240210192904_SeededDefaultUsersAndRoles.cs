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
                    { "5424f84e-ebad-491f-bf86-96903dbaf476", null, "Administrator", "ADMINISTRATOR" },
                    { "f2a04be0-60e2-4835-b0ea-4ac09e8449c5", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2770f6fa-26ed-4b6d-86f1-d0ebfe93af86", 0, "bf545d18-6fa1-45be-8639-e27222df42ca", "justin@bookstore.com", false, "Justin", "Ilic", false, null, "JUSTIN@BOOKSTORE.COM", "JUSTIN", "AQAAAAIAAYagAAAAEDwW384J3jI5diHH+OQCQtsCb2X+0Du8V/XQcjlMNtqxpiWy/76Mm40uXUCJTXc0HA==", null, false, "fa58b0e6-bbc8-49ba-8d6b-321d57d532bf", false, "Justin" },
                    { "c6296e64-501b-42b8-a8d8-cfb1bd7c6485", 0, "4e6710f0-3c3a-4f30-9313-1dff90736f61", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN", "AQAAAAIAAYagAAAAEN6Fpb0s15yUwyW7KDi1n+JoC5B6YPuMebA3N6Iy10goJchXIfS3WqNUs4Dmxu8oCQ==", null, false, "268b08c3-20bf-4fbd-bd87-10e5e5ba6547", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f2a04be0-60e2-4835-b0ea-4ac09e8449c5", "2770f6fa-26ed-4b6d-86f1-d0ebfe93af86" },
                    { "5424f84e-ebad-491f-bf86-96903dbaf476", "c6296e64-501b-42b8-a8d8-cfb1bd7c6485" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2a04be0-60e2-4835-b0ea-4ac09e8449c5", "2770f6fa-26ed-4b6d-86f1-d0ebfe93af86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5424f84e-ebad-491f-bf86-96903dbaf476", "c6296e64-501b-42b8-a8d8-cfb1bd7c6485" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5424f84e-ebad-491f-bf86-96903dbaf476");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2a04be0-60e2-4835-b0ea-4ac09e8449c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2770f6fa-26ed-4b6d-86f1-d0ebfe93af86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6296e64-501b-42b8-a8d8-cfb1bd7c6485");
        }
    }
}
