using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarSplitterMVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MesaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<double>(type: "double", nullable: true),
                    MesaId = table.Column<int>(type: "int", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PrendaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogo_Item_PrendaId",
                        column: x => x.PrendaId,
                        principalTable: "Item",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mesa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorTotal = table.Column<double>(type: "double", nullable: false),
                    UsuarioAdminId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesa", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Admin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Conta = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    GrupoId = table.Column<int>(type: "int", nullable: true),
                    JogoId = table.Column<int>(type: "int", nullable: true),
                    MesaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usuario_Jogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usuario_Mesa_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesa",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Grupo_MesaId",
                table: "Grupo",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_MesaId",
                table: "Item",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_UsuarioId",
                table: "Item",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_PrendaId",
                table: "Jogo",
                column: "PrendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesa_UsuarioAdminId",
                table: "Mesa",
                column: "UsuarioAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_GrupoId",
                table: "Usuario",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_JogoId",
                table: "Usuario",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_MesaId",
                table: "Usuario",
                column: "MesaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_Mesa_MesaId",
                table: "Grupo",
                column: "MesaId",
                principalTable: "Mesa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Mesa_MesaId",
                table: "Item",
                column: "MesaId",
                principalTable: "Mesa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Usuario_UsuarioId",
                table: "Item",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mesa_Usuario_UsuarioAdminId",
                table: "Mesa",
                column: "UsuarioAdminId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_Mesa_MesaId",
                table: "Grupo");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Mesa_MesaId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Mesa_MesaId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Usuario_UsuarioId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Mesa");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Jogo");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
