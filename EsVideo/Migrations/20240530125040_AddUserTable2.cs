using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EsVideo.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUSer",
                table: "users",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Name", "Password", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, "Tino", "admin1234567", "Lebonwski", "admin" },
                    { 2, "Name2", "password2", "Surname2", "user2" },
                    { 3, "Name3", "password3", "Surname3", "user3" },
                    { 4, "Name4", "password4", "Surname4", "user4" },
                    { 5, "Name5", "password5", "Surname5", "user5" },
                    { 6, "Name6", "password6", "Surname6", "user6" },
                    { 7, "Name7", "password7", "Surname7", "user7" },
                    { 8, "Name8", "password8", "Surname8", "user8" },
                    { 9, "Name9", "password9", "Surname9", "user9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "IdUSer");
        }
    }
}
