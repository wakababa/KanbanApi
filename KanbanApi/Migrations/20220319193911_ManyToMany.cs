using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KanbanApi.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Column_Project_ProjectId",
                table: "Column");

            migrationBuilder.DropForeignKey(
                name: "FK_Issue_Column_ColumnId",
                table: "Issue");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_User_UserId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Column_ColumnId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ColumnId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ColumnId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Project",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColumnId",
                table: "Issue",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Column",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Project_ProjectId",
                table: "Column",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Issue_Column_ColumnId",
                table: "Issue",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "ColumnId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_User_UserId",
                table: "Project",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Column_Project_ProjectId",
                table: "Column");

            migrationBuilder.DropForeignKey(
                name: "FK_Issue_Column_ColumnId",
                table: "Issue");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_User_UserId",
                table: "Project");

            migrationBuilder.AddColumn<int>(
                name: "ColumnId",
                table: "User",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Project",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ColumnId",
                table: "Issue",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Column",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_User_ColumnId",
                table: "User",
                column: "ColumnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Project_ProjectId",
                table: "Column",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Issue_Column_ColumnId",
                table: "Issue",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "ColumnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_User_UserId",
                table: "Project",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Column_ColumnId",
                table: "User",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "ColumnId");
        }
    }
}
