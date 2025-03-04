using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class FixItemClientRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemClients_Clients_ClientId1",
                table: "ItemClients");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemClients_Items_ClientId",
                table: "ItemClients");

            migrationBuilder.DropIndex(
                name: "IX_ItemClients_ClientId1",
                table: "ItemClients");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "ItemClients");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemClients_Clients_ClientId",
                table: "ItemClients",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemClients_Items_ItemId",
                table: "ItemClients",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemClients_Clients_ClientId",
                table: "ItemClients");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemClients_Items_ItemId",
                table: "ItemClients");

            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "ItemClients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemClients_ClientId1",
                table: "ItemClients",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemClients_Clients_ClientId1",
                table: "ItemClients",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemClients_Items_ClientId",
                table: "ItemClients",
                column: "ClientId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
