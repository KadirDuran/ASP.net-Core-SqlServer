using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SqlServer_ASP.net_Core.Models;

    public class _CoreContext : DbContext
    {
        public _CoreContext (DbContextOptions<_CoreContext> options)
            : base(options)
        {
        }

        public DbSet<SqlServer_ASP.net_Core.Models.Product> TestModel { get; set; } = default!;
    }
