using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTask1.Migrations
{
    /// <inheritdoc />
    public partial class TaskModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Taasks",
                table: "Taasks");

            migrationBuilder.RenameTable(
                name: "Taasks",
                newName: "NewTask");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "NewTask",
                newName: "Deadline");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "NewTask",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewTask",
                table: "NewTask",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewTask",
                table: "NewTask");

            migrationBuilder.RenameTable(
                name: "NewTask",
                newName: "Taasks");

            migrationBuilder.RenameColumn(
                name: "Deadline",
                table: "Taasks",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Taasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Taasks",
                table: "Taasks",
                column: "Id");
        }
    }
}
