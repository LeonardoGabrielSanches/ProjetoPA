using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfraSql.Migrations
{
    public partial class banco2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCliente = table.Column<string>(maxLength: 4000, nullable: true),
                    TipoDoDocumento = table.Column<string>(maxLength: 4000, nullable: true),
                    Númerododocumento = table.Column<string>(name: "Número do documento", maxLength: 4000, nullable: true),
                    Bairro = table.Column<string>(maxLength: 4000, nullable: true),
                    CEP = table.Column<string>(maxLength: 40000, nullable: true),
                    Município = table.Column<string>(maxLength: 4000, nullable: true),
                    Logradouro = table.Column<string>(maxLength: 4000, nullable: true),
                    Número = table.Column<string>(maxLength: 4000, nullable: true),
                    Email = table.Column<string>(maxLength: 4000, nullable: true),
                    UF = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ClienteID", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    VendedorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("VendedorID", x => x.VendedorID);
                });

            migrationBuilder.CreateTable(
                name: "PedidoDeVenda",
                columns: table => new
                {
                    VendaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrecoFinal = table.Column<double>(maxLength: 100, nullable: false),
                    Desconto = table.Column<double>(maxLength: 100, nullable: false),
                    VendedorID = table.Column<int>(nullable: true),
                    DataDoPedido = table.Column<DateTime>(maxLength: 11, nullable: false),
                    DataDeEntrega = table.Column<DateTime>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("VendaId", x => x.VendaId);
                    table.ForeignKey(
                        name: "FK_PedidoDeVenda_Vendedor_VendedorID",
                        column: x => x.VendedorID,
                        principalTable: "Vendedor",
                        principalColumn: "VendedorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoEstoque = table.Column<int>(maxLength: 4000, nullable: false),
                    Descricao = table.Column<string>(maxLength: 9, nullable: false),
                    Marca = table.Column<string>(maxLength: 4000, nullable: false),
                    ValorCusto = table.Column<double>(maxLength: 4000, nullable: false),
                    ValorVenda = table.Column<double>(maxLength: 4000, nullable: false),
                    MargemMaxima = table.Column<double>(maxLength: 4000, nullable: false),
                    PedidoDeVendaVendaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ItemID", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_Item_PedidoDeVenda_PedidoDeVendaVendaId",
                        column: x => x.PedidoDeVendaVendaId,
                        principalTable: "PedidoDeVenda",
                        principalColumn: "VendaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_PedidoDeVendaVendaId",
                table: "Item",
                column: "PedidoDeVendaVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDeVenda_VendedorID",
                table: "PedidoDeVenda",
                column: "VendedorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "PedidoDeVenda");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
