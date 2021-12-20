 using System.ComponentModel.DataAnnotations;

namespace Drake_Travel_Light.Models
{
    public class Voo
    {
        [Key]
        public int Id_Voo { get; set; }
        public string? Destino { get; set; }
        public string? Assento { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MM yyyy}")]
        [Display(Name = "Dia de Viagem")]
        [DataType(DataType.Date)]
        public DateTime Data_ida { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MM yyyy}")]
        [Display(Name = "Dia de Viagem")]
        [DataType(DataType.Date)]
        public DateTime Data_volta { get; set; }

        public virtual List<Cliente>? Clientes { get; set; }
    }
}
