using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class ArtPieceId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtDatas_ArtPieces_ArtPieceId",
                table: "ArtDatas");

            migrationBuilder.AlterColumn<int>(
                name: "ArtPieceId",
                table: "ArtDatas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtDatas_ArtPieces_ArtPieceId",
                table: "ArtDatas",
                column: "ArtPieceId",
                principalTable: "ArtPieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtDatas_ArtPieces_ArtPieceId",
                table: "ArtDatas");

            migrationBuilder.AlterColumn<int>(
                name: "ArtPieceId",
                table: "ArtDatas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ArtDatas_ArtPieces_ArtPieceId",
                table: "ArtDatas",
                column: "ArtPieceId",
                principalTable: "ArtPieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
