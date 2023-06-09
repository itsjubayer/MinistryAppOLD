﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlatManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using FlatManagement.ViewModel;

namespace FlatManagement.Models
{
    public class MinistryDBContext:IdentityDbContext<ApplicationUser>
    {
        public MinistryDBContext(DbContextOptions<MinistryDBContext> options) : base(options)
        {

        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        //    {
        //        foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        //    }
        //}

        public DbSet<EnumModel> EnumValues { get; set; }
        
        public DbSet<FAQVM> Faqs { get; set; }
        
        /**
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyVM>(entity => {
                entity.HasIndex(e => e.CodeName).IsUnique();
            });

            
            modelBuilder.Entity<CompanyVM>()
                .HasIndex(p => new { p.CompanyShortName, p.LastName })
                .IsUnique(true);
            
           
        }
    */

    }
}
