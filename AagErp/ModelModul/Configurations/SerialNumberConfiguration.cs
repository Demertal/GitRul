﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelModul.Models;

namespace ModelModul.Configurations
{
    class SerialNumberConfiguration : IEntityTypeConfiguration<SerialNumber>
    {
        public void Configure(EntityTypeBuilder<SerialNumber> builder)
        {
            builder.ToTable("serialNumbers");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Value).IsRequired().HasMaxLength(20).IsUnicode(false);
            builder.Property(s => s.DateCreated).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.HasMany(s => s.SerialNumberLogsCollection).WithOne(s => s.SerialNumber).HasForeignKey(s => s.IdSerialNumber)
                .IsRequired();
            builder.HasMany(s => s.WarrantiesCollection).WithOne(w => w.SerialNumber).HasForeignKey(w => w.IdSerialNumber)
                .IsRequired();
            builder.HasMany(s => s.ChangesCollection).WithOne(w => w.SerialNumberСhange)
                .HasForeignKey(w => w.IdSerialNumberСhange);
        }
    }
}
