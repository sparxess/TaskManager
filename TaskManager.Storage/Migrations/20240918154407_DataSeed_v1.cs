using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.Storage.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "Date", "Description", "Status" },
                values: new object[,]
                {
                    { new Guid("184b6c49-0c88-4c5b-87ff-e7401d5774a7"), new DateTimeOffset(new DateTime(2024, 9, 18, 18, 44, 5, 171, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 3, 0, 0, 0)), "Task2", "Created" },
                    { new Guid("256e975c-8f5b-4146-8504-25ebc2904dd8"), new DateTimeOffset(new DateTime(2024, 9, 18, 18, 44, 5, 171, DateTimeKind.Unspecified).AddTicks(841), new TimeSpan(0, 3, 0, 0, 0)), "Task3", "Created" },
                    { new Guid("652a5ab2-f53b-4e0e-8429-d285153be8ca"), new DateTimeOffset(new DateTime(2024, 9, 18, 18, 44, 5, 171, DateTimeKind.Unspecified).AddTicks(812), new TimeSpan(0, 3, 0, 0, 0)), "Task1", "Created" }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "Content", "ContentType", "DateCreated", "FileName", "TaskId" },
                values: new object[,]
                {
                    { new Guid("29a6da1c-b725-48f4-a3be-95238646bc58"), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "text/plain", new DateTimeOffset(new DateTime(2024, 9, 18, 18, 44, 5, 171, DateTimeKind.Unspecified).AddTicks(966), new TimeSpan(0, 3, 0, 0, 0)), "file3.txt", new Guid("652a5ab2-f53b-4e0e-8429-d285153be8ca") },
                    { new Guid("7a662d83-3696-44c6-bcf0-98a2b80ba17d"), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "image/png", new DateTimeOffset(new DateTime(2024, 9, 18, 18, 44, 5, 171, DateTimeKind.Unspecified).AddTicks(971), new TimeSpan(0, 3, 0, 0, 0)), "file5.png", new Guid("184b6c49-0c88-4c5b-87ff-e7401d5774a7") },
                    { new Guid("8b61ab77-722e-4abb-a9c7-f872e545321b"), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "text/plain", new DateTimeOffset(new DateTime(2024, 9, 18, 18, 44, 5, 171, DateTimeKind.Unspecified).AddTicks(968), new TimeSpan(0, 3, 0, 0, 0)), "file4.txt", new Guid("184b6c49-0c88-4c5b-87ff-e7401d5774a7") },
                    { new Guid("997e2aa4-0248-4a02-9732-ae875dba0382"), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "image/png", new DateTimeOffset(new DateTime(2024, 9, 18, 18, 44, 5, 171, DateTimeKind.Unspecified).AddTicks(973), new TimeSpan(0, 3, 0, 0, 0)), "file6.png", new Guid("256e975c-8f5b-4146-8504-25ebc2904dd8") },
                    { new Guid("ac5b2c0d-a115-4ae5-bda5-c7dfdf1074b2"), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "image/png", new DateTimeOffset(new DateTime(2024, 9, 18, 18, 44, 5, 171, DateTimeKind.Unspecified).AddTicks(956), new TimeSpan(0, 3, 0, 0, 0)), "file2.png", new Guid("652a5ab2-f53b-4e0e-8429-d285153be8ca") },
                    { new Guid("ded7ad22-1715-45bc-baf7-ea4dc6545707"), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "text/plain", new DateTimeOffset(new DateTime(2024, 9, 18, 18, 44, 5, 171, DateTimeKind.Unspecified).AddTicks(950), new TimeSpan(0, 3, 0, 0, 0)), "file1.txt", new Guid("652a5ab2-f53b-4e0e-8429-d285153be8ca") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("29a6da1c-b725-48f4-a3be-95238646bc58"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("7a662d83-3696-44c6-bcf0-98a2b80ba17d"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("8b61ab77-722e-4abb-a9c7-f872e545321b"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("997e2aa4-0248-4a02-9732-ae875dba0382"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("ac5b2c0d-a115-4ae5-bda5-c7dfdf1074b2"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("ded7ad22-1715-45bc-baf7-ea4dc6545707"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: new Guid("184b6c49-0c88-4c5b-87ff-e7401d5774a7"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: new Guid("256e975c-8f5b-4146-8504-25ebc2904dd8"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: new Guid("652a5ab2-f53b-4e0e-8429-d285153be8ca"));
        }
    }
}
