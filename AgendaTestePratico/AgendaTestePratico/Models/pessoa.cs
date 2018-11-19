using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AgendaTestePratico.Models
{
    public class pessoa
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Nascimento { get; set; }

    }
}