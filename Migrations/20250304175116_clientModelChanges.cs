using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class clientModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_itemClients_Clients_ClientId1",
                table: "itemClients");

            migrationBuilder.DropForeignKey(
                name: "FK_itemClients_Items_ClientId",
                table: "itemClients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_itemClients",
                table: "itemClients");

            migrationBuilder.RenameTable(
                name: "itemClients",
                newName: "ItemClients");

            migrationBuilder.RenameIndex(
                name: "IX_itemClients_ClientId1",
                table: "ItemClients",
                newName: "IX_ItemClients_ClientId1");

            migrationBuilder.RenameIndex(
                name: "IX_itemClients_ClientId",
                table: "ItemClients",
                newName: "IX_ItemClients_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemClients",
                table: "ItemClients",
                columns: new[] { "ItemId", "ClientId" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemClients_Clients_ClientId1",
                table: "ItemClients");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemClients_Items_ClientId",
                table: "ItemClients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemClients",
                table: "ItemClients");

            migrationBuilder.RenameTable(
                name: "ItemClients",
                newName: "itemClients");

            migrationBuilder.RenameIndex(
                name: "IX_ItemClients_ClientId1",
                table: "itemClients",
                newName: "IX_itemClients_ClientId1");

            migrationBuilder.RenameIndex(
                name: "IX_ItemClients_ClientId",
                table: "itemClients",
                newName: "IX_itemClients_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_itemClients",
                table: "itemClients",
                columns: new[] { "ItemId", "ClientId" });

            migrationBuilder.AddForeignKey(
                name: "FK_itemClients_Clients_ClientId1",
                table: "itemClients",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_itemClients_Items_ClientId",
                table: "itemClients",
                column: "ClientId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
