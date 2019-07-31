using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Infrastruct.Data.Mappings
{
  public  class StudentMap: IEntityTypeConfiguration<Student>
    {

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Email)
                .HasColumnType("vahchar(100)")
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnName("Email");

            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Name");

        }
    }
}
