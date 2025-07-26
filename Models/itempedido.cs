using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistribuidoraProdutos.Models
{
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }
        public string Quantidade { get; set; } = string.Empty;
        public string SituacaoItem { get; set; } = string.Empty;
        public int PedidoNumero { get; set; }
        [ForeignKey("PedidoNumero")]
        public Pedido Pedido { get; set; }
        public int ProdutoCodigo { get; set; }
        [ForeignKey("ProdutoCodigo")]
        public Produto Produto { get; set; }
    }
}
