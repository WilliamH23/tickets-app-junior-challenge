using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TicketManager.Domian;

using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
namespace TicketManager.Context
{
    //Configurando o gerenciador de Banco de dados do Sistema.
    public class TicketManagerContext : DbContext
    {
        public DbSet<Domian.Employee> Employees { get; set; }
        public DbSet<Ticket> Tickets{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ticketmanager.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

    }
}
