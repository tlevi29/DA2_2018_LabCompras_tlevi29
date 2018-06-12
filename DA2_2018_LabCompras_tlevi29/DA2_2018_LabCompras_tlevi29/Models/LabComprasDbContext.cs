using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public class LabComprasDbContext : DbContext
    {
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Conta> Contas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection =
            @"Server=(localdb)\mssqllocaldb;Database=LABCOMPRAS_BD_2018; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);



        }
    }
}
