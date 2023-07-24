using Entidade.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Cotext
{

    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=containers-us-west-174.railway.app;Port=5973;Database=railway;Uid=root;Pwd=jksJHjq0XAozHNciiLyz;";
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 33)));
        }

    }
}
