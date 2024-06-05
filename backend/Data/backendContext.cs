using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.models;
using backend.Models;

namespace backend.Data
{
    public class backendContext : DbContext
    {
        public backendContext (DbContextOptions<backendContext> options)
            : base(options)
        {
        }

        public DbSet<backend.models.User> User { get; set; } = default!;
        public DbSet<backend.models.Transaction> Transaction { get; set; } = default!;
        public DbSet<backend.models.Item> Item { get; set; } = default!;
        public DbSet<backend.models.Image> Image { get; set; } = default!;
        public DbSet<backend.Models.Category> Category { get; set; } = default!;
    }
}
