using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public static class Repository
    {
        private static List<Despesa> despesas = new List<Despesa>();
        private static List<Conta> contas = new List<Conta>();

        public static List<Despesa> Despesa
        {
            get { return despesas; }
        }

        public static void AddDespesa(Despesa newDespesa)
        {
            despesas.Add(newDespesa);
        }
        
        public static List<Conta> Contas
        {
           get { return contas; }
        }

        public static void AddConta(Conta newContas)
        {
            contas.Add(newContas);
        }

        public static void ClearDespesas()
        {
            despesas.Clear();
        }

        public static void ClearContas()
        {
            contas.Clear();
        }

    }
}
