using System.ComponentModel.DataAnnotations;

namespace DistribuidoraProdutos.Models
{
    public class Cliente
    {
        [Key]
        public int Matricula { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf_cgc { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string NomeContato { get; set; } = string.Empty;
        public string CartaoCredito { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}