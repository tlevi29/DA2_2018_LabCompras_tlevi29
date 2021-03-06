﻿using System.Collections.Generic;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public static class MemoryRepository
    {
        private static List<Despesa> despesas = new List<Despesa>();
        private static List<Conta> contas = new List<Conta>();

        public static List<Despesa> Despesa
        {
            get { return despesas; }
        }

        public static void AddDespesa(Despesa newDespesa)
        {
            int n = despesas.Count + 1;
            newDespesa.DespesaID = n;

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

        public static Despesa GetDespesas(int id)
        {
            foreach (Despesa expense in despesas)
            {
                if (expense.DespesaID == id)
                    return expense;
            }
            return null;
        }

        public static Conta GetContas(string name)
        {
            foreach (Conta accaunt in contas)
            {
                if (accaunt.NomeTitular == name)
                    return accaunt;
            }
            return null;
        }
    }
}
