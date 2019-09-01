using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class CorrectEntityName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelesRecord_Seller_SellerId",
                table: "SelesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SelesRecord",
                table: "SelesRecord");

            migrationBuilder.RenameTable(
                name: "SelesRecord",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SelesRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SelesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SelesRecord",
                newName: "IX_SelesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SelesRecord",
                table: "SelesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SelesRecord_Seller_SellerId",
                table: "SelesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
