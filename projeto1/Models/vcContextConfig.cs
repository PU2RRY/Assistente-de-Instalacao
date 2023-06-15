using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistente_de_Instalação.Models
{
    public partial class vcContext : DbContext
    {
        public vcContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=vc;Persist Security Info=True;User ID=sqlvirtualnet;Password=n14e5t20; TrustServerCertificate=true ");
    }

}
