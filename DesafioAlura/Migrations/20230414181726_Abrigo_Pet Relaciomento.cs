using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioAlura.Migrations
{
    /// <inheritdoc />
    public partial class Abrigo_PetRelaciomento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AbrigoId",
                table: "Pet",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pet_AbrigoId",
                table: "Pet",
                column: "AbrigoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Abrigos_AbrigoId",
                table: "Pet",
                column: "AbrigoId",
                principalTable: "Abrigos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Abrigos_AbrigoId",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Pet_AbrigoId",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "AbrigoId",
                table: "Pet");
        }
    }
}
