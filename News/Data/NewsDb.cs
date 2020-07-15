
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Models;
using Microsoft.Extensions.DependencyInjection;


namespace News.Data
{
    public class NewsDb : DbContext
    {
        public NewsDb(DbContextOptions<NewsDb> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //modelBuilder.Entity<NI>().Ignore(c => c.Noticiasid);
            //modelBuilder.Entity<NI>().Ignore(c => c.Imagensid);
            //modelBuilder.Entity<NT>().Ignore(c => c.Noticiasid);
            //modelBuilder.Entity<NT>().Ignore(c => c.Topicosid);


            //modelBuilder.Entity<NI>()
            //    .HasKey(x => new { x.Imagensid, x.Noticiasid});
            //modelBuilder.Entity<NI>()
            //   .HasOne(x => x.ImagensidFK)
            //   .WithMany()
            //   .HasForeignKey(x => x.Imagensid);
            //modelBuilder.Entity<NI>()
            //    .HasOne(x => x.NoticiasidFK)
            //    .WithMany()
            //    .HasForeignKey(x => x.Noticiasid);


            //modelBuilder.Entity<NT>()
            //    .HasNoKey();
            //    .HasKey(o => new{ o.Topicosid, o.Noticiasid});
            //modelBuilder.Entity<NT>()
            //   .HasOne(x => x.TopicosFK)
            //   .WithMany()
            //   .HasForeignKey(x => x.Topicosid);
            //modelBuilder.Entity<NT>()
            //    .HasOne(x => x.NoticiasidFK)
            //    .WithMany()
            //    .HasForeignKey(x => x.Noticiasid);

        }

        public DbSet<Imagens> Imagens { get; set; }
        public DbSet<NI> NI { get; set; }
        public DbSet<Noticias> Noticias { get; set; }
        public DbSet<NT> NT { get; set; }
        public DbSet<Topicos> Topicos { get; set; }
        public DbSet<Utilizadores> Utilizadores { get; set; }
    }

}
