using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistribuidoraProdutos.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Matricula = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf_cgc = table.Column<string>(type: "TEXT", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    NomeContato = table.Column<string>(type: "TEXT", nullable: false),
                    CartaoCredito = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Matricula);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Matricula = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cgc = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Matricula);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Unidade = table.Column<string>(type: "TEXT", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    NumSequencial = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<string>(type: "TEXT", nullable: false),
                    Situacao = table.Column<string>(type: "TEXT", nullable: false),
                    ClienteMatricula = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.NumSequencial);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteMatricula",
                        column: x => x.ClienteMatricula,
                        principalTable: "Cliente",
                        principalColumn: "Matricula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requisicao",
                columns: table => new
                {
                    Numero = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<string>(type: "TEXT", nullable: false),
                    Situacao = table.Column<string>(type: "TEXT", nullable: false),
                    FornecedorMatricula = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requisicao", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_Requisicao_Fornecedor_FornecedorMatricula",
                        column: x => x.FornecedorMatricula,
                        principalTable: "Fornecedor",
                        principalColumn: "Matricula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoFornecedor",
                columns: table => new
                {
                    ProdutoCodigo = table.Column<int>(type: "INTEGER", nullable: false),
                    FornecedorMatricula = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoFornecedor", x => x.ProdutoCodigo);
                    table.ForeignKey(
                        name: "FK_ProdutoFornecedor_Fornecedor_FornecedorMatricula",
                        column: x => x.FornecedorMatricula,
                        principalTable: "Fornecedor",
                        principalColumn: "Matricula",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoFornecedor_Produto_ProdutoCodigo",
                        column: x => x.ProdutoCodigo,
                        principalTable: "Produto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantidade = table.Column<string>(type: "TEXT", nullable: false),
                    SituacaoItem = table.Column<string>(type: "TEXT", nullable: false),
                    PedidoNumero = table.Column<int>(type: "INTEGER", nullable: false),
                    ProdutoCodigo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPedidos_Pedido_PedidoNumero",
                        column: x => x.PedidoNumero,
                        principalTable: "Pedido",
                        principalColumn: "NumSequencial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPedidos_Produto_ProdutoCodigo",
                        column: x => x.ProdutoCodigo,
                        principalTable: "Produto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fatura",
                columns: table => new
                {
                    NumeroFatura = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    Situacao = table.Column<string>(type: "TEXT", nullable: false),
                    RequisicaoNumero = table.Column<int>(type: "INTEGER", nullable: false),
                    FornecedorMatricula = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatura", x => x.NumeroFatura);
                    table.ForeignKey(
                        name: "FK_Fatura_Fornecedor_FornecedorMatricula",
                        column: x => x.FornecedorMatricula,
                        principalTable: "Fornecedor",
                        principalColumn: "Matricula",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fatura_Requisicao_RequisicaoNumero",
                        column: x => x.RequisicaoNumero,
                        principalTable: "Requisicao",
                        principalColumn: "Numero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemRequisicao",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorUltimoFornecimento = table.Column<decimal>(type: "TEXT", nullable: false),
                    RequisicaoNumero = table.Column<int>(type: "INTEGER", nullable: false),
                    ProdutoCodigo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRequisicao", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemRequisicao_Produto_ProdutoCodigo",
                        column: x => x.ProdutoCodigo,
                        principalTable: "Produto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemRequisicao_Requisicao_RequisicaoNumero",
                        column: x => x.RequisicaoNumero,
                        principalTable: "Requisicao",
                        principalColumn: "Numero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_FornecedorMatricula",
                table: "Fatura",
                column: "FornecedorMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_RequisicaoNumero",
                table: "Fatura",
                column: "RequisicaoNumero");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedidos_PedidoNumero",
                table: "ItemPedidos",
                column: "PedidoNumero");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedidos_ProdutoCodigo",
                table: "ItemPedidos",
                column: "ProdutoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRequisicao_ProdutoCodigo",
                table: "ItemRequisicao",
                column: "ProdutoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRequisicao_RequisicaoNumero",
                table: "ItemRequisicao",
                column: "RequisicaoNumero");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteMatricula",
                table: "Pedido",
                column: "ClienteMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoFornecedor_FornecedorMatricula",
                table: "ProdutoFornecedor",
                column: "FornecedorMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Requisicao_FornecedorMatricula",
                table: "Requisicao",
                column: "FornecedorMatricula");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fatura");

            migrationBuilder.DropTable(
                name: "ItemPedidos");

            migrationBuilder.DropTable(
                name: "ItemRequisicao");

            migrationBuilder.DropTable(
                name: "ProdutoFornecedor");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Requisicao");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
