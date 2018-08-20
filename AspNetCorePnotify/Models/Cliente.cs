using System.ComponentModel.DataAnnotations;

namespace AspNetCorePnotify.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        public string Nome { get; set; }
        public bool SimularException { get; set; }
    }
}
