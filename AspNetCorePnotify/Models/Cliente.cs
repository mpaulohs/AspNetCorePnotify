using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
