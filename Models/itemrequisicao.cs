using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistribuidoraProdutos.Models
{
    public class ItemRequisicao
    {
        [Key]
        public int ID { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUltimoFornecimento { get; set; }
        public int RequisicaoNumero { get; set; }
        [ForeignKey("RequisicaoNumero")]
        public Requisicao Requisicao { get; set; }
        public int ProdutoCodigo { get; set; }
        [ForeignKey("ProdutoCodigo")]
        public Produto Produto { get; set; }
    }
}
