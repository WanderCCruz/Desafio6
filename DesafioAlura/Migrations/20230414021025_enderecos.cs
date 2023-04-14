using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioAlura.Migrations
{
    /// <inheritdoc />
    public partial class enderecos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Pet");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Pet",
                type: "varchar",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Numero = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Abrigos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abrigos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abrigos_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EnderecoId",
                table: "Usuarios",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Abrigos_EnderecoId",
                table: "Abrigos",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Enderecos_EnderecoId",
                table: "Usuarios",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Enderecos_EnderecoId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Abrigos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EnderecoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Pet");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Pet",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Pet",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
