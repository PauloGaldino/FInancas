using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mysql_normal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Bases_IdSistema",
                table: "Categoria");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_Bases_SistemaId",
                table: "UsuarioSistemaFinanceiro");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "AnoCopia",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "DiaFechamento",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "GerarCopiaDespesa",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Mes",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "MesCopia",
                table: "Bases");

            migrationBuilder.CreateTable(
                name: "SistemaFinanceiro",
                columns: table => new
                {
                    SistemaFinanceiroId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mes = table.Column<int>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    DiaFechamento = table.Column<int>(nullable: false),
                    GerarCopiaDespesa = table.Column<bool>(nullable: false),
                    MesCopia = table.Column<int>(nullable: false),
                    AnoCopia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaFinanceiro", x => x.SistemaFinanceiroId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_SistemaFinanceiro_IdSistema",
                table: "Categoria",
                column: "IdSistema",
                principalTable: "SistemaFinanceiro",
                principalColumn: "SistemaFinanceiroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_SistemaFinanceiro_SistemaId",
                table: "UsuarioSistemaFinanceiro",
                column: "SistemaId",
                principalTable: "SistemaFinanceiro",
                principalColumn: "SistemaFinanceiroId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_SistemaFinanceiro_IdSistema",
                table: "Categoria");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_SistemaFinanceiro_SistemaId",
                table: "UsuarioSistemaFinanceiro");

            migrationBuilder.DropTable(
                name: "SistemaFinanceiro");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Bases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnoCopia",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiaFechamento",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "GerarCopiaDespesa",
                table: "Bases",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mes",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MesCopia",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Bases_IdSistema",
                table: "Categoria",
                column: "IdSistema",
                principalTable: "Bases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_Bases_SistemaId",
                table: "UsuarioSistemaFinanceiro",
                column: "SistemaId",
                principalTable: "Bases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
