using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public static class Repository
    {
        public static List<Despesa> Despesa
        {
            get
            {
                LabComprasDbContext context = new LabComprasDbContext();
                List<Despesa> despesas = context.Despesas.ToList();
                return despesas;
            }
        }

        public static List<Conta> Contas
        {
            get
            {
                LabComprasDbContext context = new LabComprasDbContext();
                List<Conta> contas = context.Contas.ToList();
                return contas;
            }
        }

        public static void AddDespesa(Despesa newDespesa)
        {
            LabComprasDbContext context = new LabComprasDbContext();
            context.Despesas.Add(newDespesa);
            context.SaveChanges();

            int n = Despesa.Count + 1; //ApiServer
            newDespesa.DespesaID = n;

        }

        public static void AddConta(Conta newContas)
        {
            LabComprasDbContext context = new LabComprasDbContext();
            context.Contas.Add(newContas);
            context.SaveChanges();
        }

        public static void ClearDespesas()
        {
            Despesa.Clear();
        }

        public static void ClearContas()
        {
            Contas.Clear();
        }

        public static Despesa GetDespesas(int id)
        {
            foreach (Despesa expense in Despesa)
            {
                if (expense.DespesaID == id)
                    return expense;
            }
            return null;
        }

        public static Conta GetContas(string name)
        {
            foreach (Conta accaunt in Contas)
            {
                if (accaunt.NomeTitular == name)
                    return accaunt;
            }
            return null;
        }
    }
}


//public static List<Product> Products
//{
//    get
//    {
//        AppProdutosDbContext context = new AppProdutosDbContext();
//        List<Product> products = context.Products.ToList();
//        return products;
//    }
//}
//public static void AddProduct(Product newProduct)
//{
//    AppProdutosDbContext context = new AppProdutosDbContext();
//    context.Products.Add(newProduct);
//    context.SaveChanges();
//}