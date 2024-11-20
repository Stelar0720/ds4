using System.Data.Entity; // Necesario para DbContext
using Proyecto2.Models;

namespace Proyecto2.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() : base("DefaultConnection") { }

        public DbSet<Calculo> Calculos { get; set; }
    }
}

