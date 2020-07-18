using System;
using System.Collections.Generic;
using System.Text;
using News.Data.Migrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using News.Models;
using Microsoft.AspNetCore.Identity;

namespace News.Data
{
    public class NewsDb : IdentityDbContext
    {
        public NewsDb(DbContextOptions<NewsDb> options)
            : base(options)
        {}
      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<IdentityRole<string>>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");

            //modelBuilder.Entity<IdentityUserLogin>().HasKey(l => l.UserId);
            //modelBuilder.Entity<IdentityRole>().HasKey(r => r.Id);
            //modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            modelBuilder.Entity<NI>()
               .HasKey(x => new { x.Imagensid, x.Noticiasid });

            modelBuilder.Entity<NI>()
               .HasOne<Imagens>(x => x.Imagens)
               .WithMany(c => c.ListaNI)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey(x => x.Imagensid);
            modelBuilder.Entity<NI>()
                .HasOne<Noticias>(x => x.Noticias)
                .WithMany(c => c.ListaNI)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.Noticiasid);


            modelBuilder.Entity<NT>()
                .HasKey(o => new { o.Topicosid, o.Noticiasid });


            modelBuilder.Entity<NT>()
               .HasOne<Topicos>(x => x.Topicos)
               .WithMany(c => c.ListaNT)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey(x => x.Topicosid);
            modelBuilder.Entity<NT>()
                .HasOne<Noticias>(x => x.Noticias)
                .WithMany(c => c.ListaNT)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.Noticiasid);

        }

        public virtual DbSet<Imagens> Imagens { get; set; }
        public virtual DbSet<Noticias> Noticias { get; set; }
        public virtual DbSet<Topicos> Topicos { get; set; }
        public virtual DbSet<Utilizadores> Utilizadores { get; set; }
        public virtual DbSet<NI> NI { get; set; }
        public virtual DbSet<NT> NT { get; set; }
    }
}

