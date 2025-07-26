using Microsoft.EntityFrameworkCore;
using DistribuidoraProdutos.Models;

namespace DistribuidoraProdutos.Data
{
    public class DistribuidoraDBContext : DbContext
    {
        public DistribuidoraDBContext(DbContextOptions<DistribuidoraDBContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<ItemRequisicao> ItemRequisicao { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ProdutoFornecedor> ProdutoFornecedor { get; set; }
        public DbSet<Requisicao> Requisicao { get; set; }
    }
}