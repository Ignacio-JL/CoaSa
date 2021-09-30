using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Model;

namespace DatabaseAPI.Data
{
    public class DatabaseAPIContext : DbContext
    {
        public DatabaseAPIContext (DbContextOptions<DatabaseAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DatabaseAPI.Model.Usuarios> Usuarios { get; set; }
    }
}
