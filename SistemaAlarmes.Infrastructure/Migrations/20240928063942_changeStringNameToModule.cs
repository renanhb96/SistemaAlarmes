using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAlarmes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeStringNameToModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Strings_ModuleId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Strings_Inverters_InverterId",
                table: "Strings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Strings",
                table: "Strings");

            migrationBuilder.RenameTable(
                name: "Strings",
                newName: "Modules");

            migrationBuilder.RenameIndex(
                name: "IX_Strings_InverterId",
                table: "Modules",
                newName: "IX_Modules_InverterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modules",
                table: "Modules",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Modules_ModuleId",
                table: "Events",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Inverters_InverterId",
                table: "Modules",
                column: "InverterId",
                principalTable: "Inverters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Modules_ModuleId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Inverters_InverterId",
                table: "Modules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modules",
                table: "Modules");

            migrationBuilder.RenameTable(
                name: "Modules",
                newName: "Strings");

            migrationBuilder.RenameIndex(
                name: "IX_Modules_InverterId",
                table: "Strings",
                newName: "IX_Strings_InverterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Strings",
                table: "Strings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Strings_ModuleId",
                table: "Events",
                column: "ModuleId",
                principalTable: "Strings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Strings_Inverters_InverterId",
                table: "Strings",
                column: "InverterId",
                principalTable: "Inverters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
