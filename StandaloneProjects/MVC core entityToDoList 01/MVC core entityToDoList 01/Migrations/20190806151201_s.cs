using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_core_entityToDoList_01.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaskName",
                table: "Task",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TaskName",
                table: "Task",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
