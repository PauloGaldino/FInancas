using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mysql_Despeza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemCompra");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "SistemaFinanceiro");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Bases",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "IdSistema",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Despesa_DataAlteracao",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Despesa_DataCadastro",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPagamento",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVencimento",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Despesa_IdCategoria",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mes",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Pago",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoDespesa",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Comprado",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ItemCompra_DataAlteracao",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ItemCompra_DataCadastro",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCompra",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCompra",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ItemCompra_Valor",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SistemaFinanceiro_Ano",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnoCopia",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiaFechamento",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "GerarCopiaDespesa",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SistemaFinanceiro_Mes",
                table: "Bases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MesCopia",
                table: "Bases",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bases_IdSistema",
                table: "Bases",
                column: "IdSistema");

            migrationBuilder.CreateIndex(
                name: "IX_Bases_IdCategoria",
                table: "Bases",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Bases_Despesa_IdCategoria",
                table: "Bases",
                column: "Despesa_IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Bases_IdCompra",
                table: "Bases",
                column: "IdCompra");

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_IdSistema",
                table: "Bases",
                column: "IdSistema",
                principalTable: "Bases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_IdCategoria",
                table: "Bases",
                column: "IdCategoria",
                principalTable: "Bases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_Despesa_IdCategoria",
                table: "Bases",
                column: "Despesa_IdCategoria",
                principalTable: "Bases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_IdCompra",
                table: "Bases",
                column: "IdCompra",
                principalTable: "Bases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_IdSistema",
                table: "Bases");

            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_IdCategoria",
                table: "Bases");

            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_Despesa_IdCategoria",
                table: "Bases");

            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_IdCompra",
                table: "Bases");

            migrationBuilder.DropIndex(
                name: "IX_Bases_IdSistema",
                table: "Bases");

            migrationBuilder.DropIndex(
                name: "IX_Bases_IdCategoria",
                table: "Bases");

            migrationBuilder.DropIndex(
                name: "IX_Bases_Despesa_IdCategoria",
                table: "Bases");

            migrationBuilder.DropIndex(
                name: "IX_Bases_IdCompra",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "IdSistema",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "IdCategoria",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Despesa_DataAlteracao",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Despesa_DataCadastro",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "DataPagamento",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "DataVencimento",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Despesa_IdCategoria",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Mes",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Pago",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "TipoDespesa",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Comprado",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "ItemCompra_DataAlteracao",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "ItemCompra_DataCadastro",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "DataCompra",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "IdCompra",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "ItemCompra_Valor",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "SistemaFinanceiro_Ano",
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
                name: "SistemaFinanceiro_Mes",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "MesCopia",
                table: "Bases");

            migrationBuilder.CreateTable(
                name: "SistemaFinanceiro",
                columns: table => new
                {
                    SistemaFinanceiroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    AnoCopia = table.Column<int>(type: "int", nullable: false),
                    DiaFechamento = table.Column<int>(type: "int", nullable: false),
                    GerarCopiaDespesa = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    MesCopia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaFinanceiro", x => x.SistemaFinanceiroId);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SistemaFinanceiroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                    table.ForeignKey(
                        name: "FK_Categoria_SistemaFinanceiro_SistemaFinanceiroId",
                        column: x => x.SistemaFinanceiroId,
                        principalTable: "SistemaFinanceiro",
                        principalColumn: "SistemaFinanceiroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Compra_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCompra",
                columns: table => new
                {
                    ItemCompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    Comprado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataCompra = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCompra", x => x.ItemCompraId);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Compra_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compra",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_SistemaFinanceiroId",
                table: "Categoria",
                column: "SistemaFinanceiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_CategoriaId",
                table: "Compra",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_CompraId",
                table: "ItemCompra",
                column: "CompraId");
        }
    }
}
