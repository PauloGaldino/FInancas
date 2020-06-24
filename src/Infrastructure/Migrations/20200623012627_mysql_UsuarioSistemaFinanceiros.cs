using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mysql_UsuarioSistemaFinanceiros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescricaoSugestao",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailUsuario",
                table: "Bases",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UsuarioSistemaFinanceiro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmailUsuario = table.Column<string>(nullable: true),
                    Administrador = table.Column<bool>(nullable: false),
                    SistemaAtual = table.Column<bool>(nullable: false),
                    IdSistema = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioSistemaFinanceiro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioSistemaFinanceiro_Bases_IdSistema",
                        column: x => x.IdSistema,
                        principalTable: "Bases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSistemaFinanceiro_IdSistema",
                table: "UsuarioSistemaFinanceiro",
                column: "IdSistema");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioSistemaFinanceiro");

            migrationBuilder.DropColumn(
                name: "DescricaoSugestao",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "EmailUsuario",
                table: "Bases");
        }
    }
}
