using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;

namespace EntityFramework.Data
{
    public class EFClientsContext : DbContext
    {
        public EFClientsContext (DbContextOptions<EFClientsContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFramework.Models.Producto> Products { get; set; }
    }
}
