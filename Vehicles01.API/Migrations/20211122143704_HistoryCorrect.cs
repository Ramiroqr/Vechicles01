using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicles01.API.Migrations
{
    public partial class HistoryCorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Histories_HistoryId",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Histories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProcedureId",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HistoryId",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Histories_UserId",
                table: "Histories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Histories_HistoryId",
                table: "Details",
                column: "HistoryId",
                principalTable: "Histories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_AspNetUsers_UserId",
                table: "Histories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Histories_HistoryId",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_AspNetUsers_UserId",
                table: "Histories");

            migrationBuilder.DropIndex(
                name: "IX_Histories_UserId",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Histories");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedureId",
                table: "Details",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HistoryId",
                table: "Details",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Histories_HistoryId",
                table: "Details",
                column: "HistoryId",
                principalTable: "Histories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
