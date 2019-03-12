using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class ChangeTypeOfData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtPieces_ArtDatas_ArtDataId",
                table: "ArtPieces");

            migrationBuilder.DropIndex(
                name: "IX_ArtPieces_ArtDataId",
                table: "ArtPieces");

            migrationBuilder.DropColumn(
                name: "ArtDataId",
                table: "ArtPieces");

            migrationBuilder.AddColumn<int>(
                name: "ArtPieceId",
                table: "ArtDatas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArtDatas_ArtPieceId",
                table: "ArtDatas",
                column: "ArtPieceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtDatas_ArtPieces_ArtPieceId",
                table: "ArtDatas",
                column: "ArtPieceId",
                principalTable: "ArtPieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtDatas_ArtPieces_ArtPieceId",
                table: "ArtDatas");

            migrationBuilder.DropIndex(
                name: "IX_ArtDatas_ArtPieceId",
                table: "ArtDatas");

            migrationBuilder.DropColumn(
                name: "ArtPieceId",
                table: "ArtDatas");

            migrationBuilder.AddColumn<int>(
                name: "ArtDataId",
                table: "ArtPieces",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArtPieces_ArtDataId",
                table: "ArtPieces",
                column: "ArtDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtPieces_ArtDatas_ArtDataId",
                table: "ArtPieces",
                column: "ArtDataId",
                principalTable: "ArtDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
