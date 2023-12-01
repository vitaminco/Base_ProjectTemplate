using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCategories",
                table: "AppCategories");

            migrationBuilder.RenameTable(
                name: "AppCategories",
                newName: "AppCategory");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppCategory",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AppCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Laptop", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AppCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Điện thoại di động", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AppCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3, null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sách", null, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory");

            migrationBuilder.DeleteData(
                table: "AppCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "AppCategory",
                newName: "AppCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCategories",
                table: "AppCategories",
                column: "Id");
        }
    }
}
