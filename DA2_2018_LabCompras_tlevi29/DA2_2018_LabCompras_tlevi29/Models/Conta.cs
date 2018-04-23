using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public class Conta
    {
        [Required(ErrorMessage = "Indique o nome da conta")]
        public string NomeTitular { get; set; }
        [Required(ErrorMessage = "Introduzir o valor do saldo é obrigatório")]
        public int? Saldo { get; set; }
        public bool Ativa { get; set; }

        public Conta()
        { }
    }
}
