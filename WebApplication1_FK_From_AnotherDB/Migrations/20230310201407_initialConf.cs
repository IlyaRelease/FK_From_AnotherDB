using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1FKFromAnotherDB.Migrations
{
    /// <inheritdoc />
    public partial class initialConf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Signals_DeviceEntity_DeviceId",
                table: "Signals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeviceEntity",
                table: "DeviceEntity");

            migrationBuilder.RenameTable(
                name: "DeviceEntity",
                newName: "Devices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Devices",
                table: "Devices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Signals_Devices_DeviceId",
                table: "Signals",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Signals_Devices_DeviceId",
                table: "Signals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Devices",
                table: "Devices");

            migrationBuilder.RenameTable(
                name: "Devices",
                newName: "DeviceEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeviceEntity",
                table: "DeviceEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Signals_DeviceEntity_DeviceId",
                table: "Signals",
                column: "DeviceId",
                principalTable: "DeviceEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
