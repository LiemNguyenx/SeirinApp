using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seirin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seirin.Persistence.Configuarations
{
    class UserConfiguaration : IEntityTypeConfiguration<mst_user>
    {
        public void Configure(EntityTypeBuilder<mst_user> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.mail)
                .IsRequired();
                
        }
    }
}
