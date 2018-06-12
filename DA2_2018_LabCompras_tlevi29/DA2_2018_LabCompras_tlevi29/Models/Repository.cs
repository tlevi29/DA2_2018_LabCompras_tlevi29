using System.Collections.Generic;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public static class Repository
    {
        public static List<Despesa> Despesa
        {
            get
            {
                LabComprasDbContext context = new LabComprasDbContext();
                return null;
               // List<Despesa> despesas = context.Despesas.;
                //return despesas;
            }
        }

        public static List<Conta> Contas
        {
            get
            {
                LabComprasDbContext context = new LabComprasDbContext();
                // List<Conta> contas = context.Contas.ToList();
                //return contas;
                return null;
            }
        }

        public static void AddDespesa(Despesa newDespesa)
        {
            LabComprasDbContext context = new LabComprasDbContext();
            context.Despesas.Add(newDespesa);
            context.SaveChanges();

           // int n = despesas.Count + 1; //ApiServer
          //  newDespesa.DespesaID = n;

        }

        public static void AddConta(Conta newContas)
        {
            LabComprasDbContext context = new LabComprasDbContext();
            context.Contas.Add(newContas);
            context.SaveChanges();
        }

        public static void ClearDespesas()
        {
        //    despesas.Clear();
        }

        public static void ClearContas()
        {
           // contas.Clear();
        }

        public static Despesa GetDespesas(int id)
        {
            //foreach (Despesa expense in despesas)
            //{
            //    if (expense.DespesaID == id)
            //        return expense;
            //}
            return null;
        }

        public static Conta GetContas(string name)
        {
            //foreach (Conta accaunt in contas)
            //{
            //    if (accaunt.NomeTitular == name)
            //        return accaunt;
            //}
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