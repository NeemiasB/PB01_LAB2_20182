using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGE.Infraestructure.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GruposTematicos",
                columns: table => new
                {
                    GrupoTematicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposTematicos", x => x.GrupoTematicoId);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    ParticipanteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", nullable: true),
                    Email = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.ParticipanteId);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(type: "varchar(100)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: true),
                    CEP = table.Column<string>(type: "varchar(9)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(4)", nullable: true),
                    ParticipanteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                    table.ForeignKey(
                        name: "FK_Enderecos_Participantes_ParticipanteId",
                        column: x => x.ParticipanteId,
                        principalTable: "Participantes",
                        principalColumn: "ParticipanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inscricaos",
                columns: table => new
                {
                    InscricaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    ParticipanteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscricaos", x => x.InscricaoId);
                    table.ForeignKey(
                        name: "FK_Inscricaos_Participantes_ParticipanteId",
                        column: x => x.ParticipanteId,
                        principalTable: "Participantes",
                        principalColumn: "ParticipanteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: true),
                    InscricaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoId);
                    table.ForeignKey(
                        name: "FK_Eventos_Inscricaos_InscricaoId",
                        column: x => x.InscricaoId,
                        principalTable: "Inscricaos",
                        principalColumn: "InscricaoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InscricaoGrupoTematicos",
                columns: table => new
                {
                    InscricaoGrupoTematicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InscricaoId = table.Column<int>(nullable: false),
                    GrupoTematicoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscricaoGrupoTematicos", x => x.InscricaoGrupoTematicoId);
                    table.ForeignKey(
                        name: "FK_InscricaoGrupoTematicos_GruposTematicos_GrupoTematicoId",
                        column: x => x.GrupoTematicoId,
                        principalTable: "GruposTematicos",
                        principalColumn: "GrupoTematicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InscricaoGrupoTematicos_Inscricaos_InscricaoId",
                        column: x => x.InscricaoId,
                        principalTable: "Inscricaos",
                        principalColumn: "InscricaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ParticipanteId",
                table: "Enderecos",
                column: "ParticipanteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_InscricaoId",
                table: "Eventos",
                column: "InscricaoId");

            migrationBuilder.CreateIndex(
                name: "IX_InscricaoGrupoTematicos_GrupoTematicoId",
                table: "InscricaoGrupoTematicos",
                column: "GrupoTematicoId");

            migrationBuilder.CreateIndex(
                name: "IX_InscricaoGrupoTematicos_InscricaoId",
                table: "InscricaoGrupoTematicos",
                column: "InscricaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricaos_ParticipanteId",
                table: "Inscricaos",
                column: "ParticipanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "InscricaoGrupoTematicos");

            migrationBuilder.DropTable(
                name: "GruposTematicos");

            migrationBuilder.DropTable(
                name: "Inscricaos");

            migrationBuilder.DropTable(
                name: "Participantes");
        }
    }
}
