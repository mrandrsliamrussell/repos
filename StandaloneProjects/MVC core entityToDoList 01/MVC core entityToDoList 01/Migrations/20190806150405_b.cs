using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_core_entityToDoList_01.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryID",
                table: "Task",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Task_categoryID",
                table: "Task",
                column: "categoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Category_categoryID",
                table: "Task",
                column: "categoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Category_categoryID",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_categoryID",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "categoryID",
                table: "Task");
        }
    }
}
