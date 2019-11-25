using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfraSql.Migrations
{
    public partial class EstruturaFinalTodas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Cliente",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "TipoDocumento",
                table: "Cliente",
                newName: "TipoDoDocumento");

            migrationBuilder.RenameColumn(
                name: "NumeroDocumento",
                table: "Cliente",
                newName: "Número do documento");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Cliente",
                newName: "Número");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cliente",
                newName: "NomeCliente");

            migrationBuilder.RenameColumn(
                name: "Municipio",
                table: "Cliente",
                newName: "Município");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Item",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Item",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoDeVendaVendaId",
                table: "Item",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Cliente",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Cliente",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Cliente",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TipoDoDocumento",
                table: "Cliente",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Número do documento",
                table: "Cliente",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Número",
                table: "Cliente",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCliente",
                table: "Cliente",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Município",
                table: "Cliente",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "ItemID",
                table: "Item",
                column: "ItemID");

            migrationBuilder.AddPrimaryKey(
                name: "ClienteID",
                table: "Cliente",
                column: "ClienteID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Item_PedidoDeVendaVendaId",
                table: "Item",
                column: "PedidoDeVendaVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDeVenda_VendedorID",
                table: "PedidoDeVenda",
                column: "VendedorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_PedidoDeVenda_PedidoDeVendaVendaId",
                table: "Item",
                column: "PedidoDeVendaVendaId",
                principalTable: "PedidoDeVenda",
                principalColumn: "VendaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_PedidoDeVenda_PedidoDeVendaVendaId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "PedidoDeVenda");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "ItemID",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_PedidoDeVendaVendaId",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "ClienteID",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "PedidoDeVendaVendaId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Cliente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "TipoDoDocumento",
                table: "Cliente",
                newName: "TipoDocumento");

            migrationBuilder.RenameColumn(
                name: "Número do documento",
                table: "Cliente",
                newName: "NumeroDocumento");

            migrationBuilder.RenameColumn(
                name: "Número",
                table: "Cliente",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "NomeCliente",
                table: "Cliente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Município",
                table: "Cliente",
                newName: "Municipio");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Item",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Item",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TipoDocumento",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumeroDocumento",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Municipio",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteID");
        }
    }
}
