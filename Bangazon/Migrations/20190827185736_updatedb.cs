using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "StreetAddress" },
                values: new object[] { "a08252ca-eaa2-48c2-b7b4-7107ad4348bb", "AQAAAAEAACcQAAAAEG33Peh0o/ulDQO62ztcViX6jOzRQGDDXr7q9RRkilXTzfZ0wpMWxXZZVRTHTaOeQQ==", "123 Infinity Way" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54d774ac-5fda-4df6-95be-8720e6d76ab8", "AQAAAAEAACcQAAAAEODIZA5p6UlFucTKlXK9kUxHyzHenqhJSuTnIsTz+EH2wlZUi72XmPV9cUJbjURlWA==" });
        }
    }
}
