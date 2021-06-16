using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using T10_App.Models;

namespace T10_App.Data
{
    public class TransactionContext : DbContext
    {
        public TransactionContext (DbContextOptions<TransactionContext> options)
            : base(options)
        {
        }

        public DbSet<T10_App.Models.Transaction> Transaction { get; set; }
    }
}
