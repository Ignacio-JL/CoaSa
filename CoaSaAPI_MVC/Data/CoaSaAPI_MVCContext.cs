using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Model;

namespace CoaSaAPI_MVC.Data
{
    public class CoaSaAPI_MVCContext : DbContext
    {
        public CoaSaAPI_MVCContext (DbContextOptions<CoaSaAPI_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<DatabaseAPI.Model.Usuarios> Usuarios { get; set; }
    }
}
