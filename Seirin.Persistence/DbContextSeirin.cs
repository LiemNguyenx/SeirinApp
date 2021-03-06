﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Seirin.Domain.Entities;

namespace Seirin.Persistence
{
    public class DbContextSeirin : DbContext
    {
        public DbContextSeirin(DbContextOptions<DbContextSeirin> options) 
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NB02KAV;Database=SeirinDemo;Trusted_Connection=True;User Id=sa;Password=123123");
        }
        public virtual DbSet<mst_user> Mst_Users { get; set; }

    }
}
