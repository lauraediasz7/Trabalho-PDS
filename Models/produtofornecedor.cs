using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistribuidoraProdutos.Models
{
    public class ProdutoFornecedor
    {
        [Key]
        public int ProdutoCodigo { get; set; }
        [ForeignKey("ProdutoCodigo")]
        public Produto Produto { get; set; }
        public int FornecedorMatricula { get; set; }
        [ForeignKey("FornecedorMatricula")]
        public Fornecedor Fornecedor { get; set; }
    }
}