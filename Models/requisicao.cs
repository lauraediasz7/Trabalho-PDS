using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistribuidoraProdutos.Models
{
    public class Requisicao
    {
        [Key]
        public int Numero { get; set; }
        public string Data { get; set; } = string.Empty;
        public string Situacao { get; set; } = string.Empty;
        public int FornecedorMatricula { get; set; }
        [ForeignKey("FornecedorMatricula")]
        public Fornecedor Fornecedor { get; set; }
    }
}
