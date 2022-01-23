﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopApp.EntityConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.ClientId);
            builder.Property(p => p.ClientId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.Gender).IsRequired().HasMaxLength(25);
            builder.Property(p => p.OrderDate).HasColumnType("datetime2(7)");

            builder.HasData(new List<Client>()
            {
                new Client()
                {
                    FirstName = "Alex", LastName = "Brown", Age = 29, Gender = "Male", OrderDate = new DateTime(2008, 5, 1, 8, 30, 52)
                },
                new Client()
                {
                    FirstName = "Lily", LastName = "King", Age = 23, Gender = "Female", OrderDate = new DateTime(2008, 5, 1, 8, 30, 52)
                },
                new Client()
                {
                    FirstName = "Isabella", LastName = "Lewis", Age = 18, Gender = "Female", OrderDate = new DateTime(2008, 5, 1, 8, 30, 52)
                },
                new Client()
                {
                    FirstName = "George", LastName = "Wilson", Age = 58, Gender = "Male", OrderDate = new DateTime(2008, 5, 1, 8, 30, 52)
                },
                new Client()
                {
                    FirstName = "Connor", LastName = "Ellington", Age = 67, Gender = "Male", OrderDate = new DateTime(2008, 5, 1, 8, 30, 52)
                },
            });
        }
    }
}
