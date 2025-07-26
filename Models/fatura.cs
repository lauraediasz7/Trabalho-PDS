using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistribuidoraProdutos.Models
{
    public class Fatura
    {
        [Key]
        public int NumeroFatura { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; } = string.Empty;
        public int RequisicaoNumero { get; set; }
        [ForeignKey("RequisicaoNumero")]
        public Requisicao Requisicao { get; set; }
        public int FornecedorMatricula { get; set; }
        [ForeignKey("FornecedorMatricula")]
        public Fornecedor Fornecedor { get; set; }
    }
}