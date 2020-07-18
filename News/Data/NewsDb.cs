using News.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace News.Data
{
    public class NewsDb : IdentityDbContext
        {
        public NewsDb(DbContextOptions<NewsDb> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<NI>()
               .HasKey(x => new { x.Imagensid, x.Noticiasid });

            modelBuilder.Entity<NI>()
               .HasOne<Imagens>(x => x.Imagens)
               .WithMany(c => c.ListaNI)
               .HasForeignKey(x => x.Imagensid);
            modelBuilder.Entity<NI>()
                .HasOne<Noticias>(x => x.Noticias)
                .WithMany(c => c.ListaNI)
                .HasForeignKey(x => x.Noticiasid);


            modelBuilder.Entity<NT>()
                .HasKey(o => new { o.Topicosid, o.Noticiasid });

            
            modelBuilder.Entity<NT>()
               .HasOne<Topicos>(x => x.Topicos)
               .WithMany(c => c.ListaNT)
               .HasForeignKey(x => x.Topicosid);
            modelBuilder.Entity<NT>()
                .HasOne<Noticias>(x => x.Noticias)
                .WithMany(c => c.ListaNT)
                .HasForeignKey(x => x.Noticiasid);

        }

        public virtual DbSet<Imagens> Imagens { get; set; }
        public virtual DbSet<NI> NI { get; set; }
        public virtual DbSet<Noticias> Noticias { get; set; }
        public virtual DbSet<NT> NT { get; set; }
        public virtual DbSet<Topicos> Topicos { get; set; }
        public virtual DbSet<Utilizadores> Utilizadores { get; set; }
    }

}
