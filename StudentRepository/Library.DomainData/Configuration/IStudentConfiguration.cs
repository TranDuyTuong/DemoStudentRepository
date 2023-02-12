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
    public class IStudentConfiguration : IEntityTypeConfiguration<T_Student>
    {
        public void Configure(EntityTypeBuilder<T_Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(x => x.IDStudent);
            builder.Property(x => x.IDStudent).ValueGeneratedOnAdd();
            builder.Property(x => x.NameStudent).HasColumnType("nvarchar(100)").IsRequired();

            builder.HasOne<T_Class>().WithMany().HasPrincipalKey(x=>x.IDClass)
                                                    .HasForeignKey(x => x.IDClassStudent).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
