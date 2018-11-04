using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Seirin.Domain.Entities;

namespace Seirin.Persistence
{
    class DbContextSeirin : DbContext
    {
        public virtual DbSet<mst_user> Mst_Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-144G9FR;Database=Seirin;Trusted_Connection=True;User Id=sa;Password=123123");
        }
    }
}
