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
            builder.Property(c => c.Phone)
                .HasColumnType("varchar(100)")
                .HasMaxLength(20)
                .IsRequired();

            //处理值对象，否则被视为实体
            builder.OwnsOne(p => p.Address);

            //可以对值对象进行数据库重命名，还有其他的一些操作，请参考官网
            builder.OwnsOne(o => o.Address, sa =>
            {
                sa.Property(p => p.County).HasColumnName("County");
                sa.Property(p => p.Province).HasColumnName("Province");
                sa.Property(p => p.City).HasColumnName("City");
                sa.Property(p => p.Street).HasColumnName("Street");
            });
            //如果想忽略当前值对象，可直接 Ignore
            //builder.Ignore(c => c.Address);
        }
    }
}
