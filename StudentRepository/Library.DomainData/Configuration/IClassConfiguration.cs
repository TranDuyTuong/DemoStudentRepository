using Library.TableData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.Configuration
{
    public class IClassConfiguration : IEntityTypeConfiguration<T_Class>
    {
        public void Configure(EntityTypeBuilder<T_Class> builder)
        {
            builder.ToTable("Classes");
            builder.HasKey(x => x.IDClass);
            builder.Property(x => x.IDClass).ValueGeneratedOnAdd();
            builder.Property(x => x.NameClass).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
