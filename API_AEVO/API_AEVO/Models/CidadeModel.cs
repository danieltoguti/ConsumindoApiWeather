using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_AEVO.Models
{
    public class CidadeModel
    {
        public int  Id { get; set; }

        [Display(Name = "Nome", Prompt = "Digite o nome aqui")]
        public string Nome { get; set; }
    }
}
