using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tA_Caes.Data.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Criadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nomeComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    morada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telemovel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criadores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Racas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numLOP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    criadorFK = table.Column<int>(type: "int", nullable: false),
                    racaFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.id);
                    table.ForeignKey(
                        name: "FK_Animais_Criadores_criadorFK",
                        column: x => x.criadorFK,
                        principalTable: "Criadores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animais_Racas_racaFK",
                        column: x => x.racaFK,
                        principalTable: "Racas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriadoresRacas",
                columns: table => new
                {
                    listaCriadoresid = table.Column<int>(type: "int", nullable: false),
                    listaRacasid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriadoresRacas", x => new { x.listaCriadoresid, x.listaRacasid });
                    table.ForeignKey(
                        name: "FK_CriadoresRacas_Criadores_listaCriadoresid",
                        column: x => x.listaCriadoresid,
                        principalTable: "Criadores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriadoresRacas_Racas_listaRacasid",
                        column: x => x.listaRacasid,
                        principalTable: "Racas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotografias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeFicheiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataFotografia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    animalFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotografias", x => x.id);
                    table.ForeignKey(
                        name: "FK_Fotografias_Animais_animalFK",
                        column: x => x.animalFK,
                        principalTable: "Animais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animais_criadorFK",
                table: "Animais",
                column: "criadorFK");

            migrationBuilder.CreateIndex(
                name: "IX_Animais_racaFK",
                table: "Animais",
                column: "racaFK");

            migrationBuilder.CreateIndex(
                name: "IX_CriadoresRacas_listaRacasid",
                table: "CriadoresRacas",
                column: "listaRacasid");

            migrationBuilder.CreateIndex(
                name: "IX_Fotografias_animalFK",
                table: "Fotografias",
                column: "animalFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CriadoresRacas");

            migrationBuilder.DropTable(
                name: "Fotografias");

            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Criadores");

            migrationBuilder.DropTable(
                name: "Racas");
        }
    }
}
