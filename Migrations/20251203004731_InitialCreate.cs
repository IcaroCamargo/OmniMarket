using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OmniMarket.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_PRODUTOS",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuarioVendedor = table.Column<int>(type: "int", nullable: false),
                    txtNome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    idCategoria = table.Column<int>(type: "int", nullable: false),
                    vlProduto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    qtdEstoque = table.Column<int>(type: "int", nullable: false),
                    txtDescricao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    dtRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    stAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PRODUTOS", x => x.idProduto);
                });

            migrationBuilder.InsertData(
                table: "TBL_PRODUTOS",
                columns: new[] { "idProduto", "dtRegistro", "idCategoria", "idUsuarioVendedor", "qtdEstoque", "stAtivo", "txtDescricao", "txtNome", "vlProduto" },
                values: new object[] { 1, new DateTime(2025, 12, 2, 21, 47, 29, 495, DateTimeKind.Local).AddTicks(220), 1, 1, 3, true, "Produto n", "Icaro", 200m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_PRODUTOS");
        }
    }
}
