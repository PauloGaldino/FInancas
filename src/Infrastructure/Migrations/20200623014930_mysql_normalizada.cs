using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mysql_normalizada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_Bases_IdSistema",
                table: "UsuarioSistemaFinanceiro");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioSistemaFinanceiro_IdSistema",
                table: "UsuarioSistemaFinanceiro");

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
                name: "IdSistema",
                table: "UsuarioSistemaFinanceiro");

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
                name: "SistemaFinanceiro_Mes",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "DescricaoSugestao",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "EmailUsuario",
                table: "Bases");

            migrationBuilder.AddColumn<int>(
                name: "SistemaId",
                table: "UsuarioSistemaFinanceiro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdSistema = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                    table.ForeignKey(
                        name: "FK_Categoria_Bases_IdSistema",
                        column: x => x.IdSistema,
                        principalTable: "Bases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sugestao",
                columns: table => new
                {
                    SugestaoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DescricaoSugestao = table.Column<string>(nullable: true),
                    EmailUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sugestao", x => x.SugestaoId);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    CompraId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
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
                name: "Despesa",
                columns: table => new
                {
                    DespesaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<decimal>(nullable: false),
                    Mes = table.Column<int>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    TipoDespesa = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    DataPagamento = table.Column<DateTime>(nullable: false),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    Pago = table.Column<bool>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesa", x => x.DespesaId);
                    table.ForeignKey(
                        name: "FK_Despesa_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCompra",
                columns: table => new
                {
                    ItemCoompraId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<decimal>(nullable: false),
                    Comprado = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    DataCompra = table.Column<DateTime>(nullable: false),
                    CompraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCompra", x => x.ItemCoompraId);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Compra_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compra",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSistemaFinanceiro_SistemaId",
                table: "UsuarioSistemaFinanceiro",
                column: "SistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_IdSistema",
                table: "Categoria",
                column: "IdSistema");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_CategoriaId",
                table: "Compra",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_CategoriaId",
                table: "Despesa",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_CompraId",
                table: "ItemCompra",
                column: "CompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_Bases_SistemaId",
                table: "UsuarioSistemaFinanceiro",
                column: "SistemaId",
                principalTable: "Bases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_Bases_SistemaId",
                table: "UsuarioSistemaFinanceiro");

            migrationBuilder.DropTable(
                name: "Despesa");

            migrationBuilder.DropTable(
                name: "ItemCompra");

            migrationBuilder.DropTable(
                name: "Sugestao");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioSistemaFinanceiro_SistemaId",
                table: "UsuarioSistemaFinanceiro");

            migrationBuilder.DropColumn(
                name: "SistemaId",
                table: "UsuarioSistemaFinanceiro");

            migrationBuilder.AddColumn<int>(
                name: "IdSistema",
                table: "UsuarioSistemaFinanceiro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSistema",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "Bases",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Bases",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Despesa_DataAlteracao",
                table: "Bases",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Despesa_DataCadastro",
                table: "Bases",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPagamento",
                table: "Bases",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVencimento",
                table: "Bases",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Despesa_IdCategoria",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Pago",
                table: "Bases",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoDespesa",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Bases",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Comprado",
                table: "Bases",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ItemCompra_DataAlteracao",
                table: "Bases",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ItemCompra_DataCadastro",
                table: "Bases",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCompra",
                table: "Bases",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCompra",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ItemCompra_Valor",
                table: "Bases",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SistemaFinanceiro_Ano",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SistemaFinanceiro_Mes",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoSugestao",
                table: "Bases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailUsuario",
                table: "Bases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSistemaFinanceiro_IdSistema",
                table: "UsuarioSistemaFinanceiro",
                column: "IdSistema");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_Bases_IdSistema",
                table: "UsuarioSistemaFinanceiro",
                column: "IdSistema",
                principalTable: "Bases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
