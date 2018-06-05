using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public class Despesa
    {
        public int DespesaID { get; set; }
        [Required(ErrorMessage = "Por favor itroduza o nome da despesa")]
        public string NomeDespesa { get; set; }
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "O valor do produto é invalido")]
        public double? Valor { get; set; }
        [Required(ErrorMessage = "Categoria invalido, selecione uma categoria")]
        public string Categoria { get; set; }
        public bool Pago { get; set; }

        public Despesa()
        { }
    }
}
