using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistribuidoraProdutos.Models
{
    public class Produto
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Unidade { get; set; } = string.Empty;
        public decimal PrecoVenda { get; set; }
    }
}