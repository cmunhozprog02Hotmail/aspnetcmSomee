using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace aspnetcmSomee.Contextos
{
    [Table("Contato")]
    public class Contato            
    {
        public int ContatoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}