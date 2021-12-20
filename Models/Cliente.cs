using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Drake_Travel_Light.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id_Voo")]
        public int Numero_voo { get; set; }
        public virtual Voo? Voo { get; set; }
        public string? Nome { get; set; }
        [StringLength(11)]
        public string? CPF { get; set; }
    }
}
