using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using testes.Models;

namespace testes.Models
{
    public class Mensagem
    {
        [Key]
        public int MensagemID { get; set; }

        public string MensagemConteudo { get; set; }
    }
}