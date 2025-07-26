using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistribuidoraProdutos.Models
{
    public class Pedido
    {
        [Key]
        public int NumSequencial { get; set; }
        public string Data { get; set; } = string.Empty;
        public string Situacao { get; set; } = string.Empty;
        public int ClienteMatricula { get; set; }
        [ForeignKey("ClienteMatricula")]
        public Cliente Cliente { get; set; }
    }
}
