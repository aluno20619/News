
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
            //modelBuilder.Entity<NI>().HasNoKey();
            //modelBuilder.Entity<NT>().HasNoKey();



            modelBuilder.Entity<NI>()
               .HasKey(x => new { x.Imagensid, x.Noticiasid });

            //modelBuilder.Entity<NI>()
            //   .HasKey(x => x.Noticiasid );
            //modelBuilder.Entity<NI>()
            //   .HasAlternateKey(x => x.Imagensid);



            //modelBuilder.Entity<NI>()
            //   .HasOne<Imagens>(x => x.Imagensid)
            //   .WithMany(c => c.ListaNI)
            //   .HasForeignKey(x => x.ImagensidFK);
            //modelBuilder.Entity<NI>()
            //    .HasOne<Noticias>(x => x.Noticiasid)
            //    .WithMany(c => c.ListaNI)
            //    .HasForeignKey(x => x.NoticiasidFK);


            modelBuilder.Entity<NT>()
                .HasKey(o => new { o.Topicosid, o.Noticiasid });

            //modelBuilder.Entity<NT>()
            //   .HasKey(x => x.Noticiasid);
            //modelBuilder.Entity<NT>()
            //   .HasAlternateKey(x => x.Topicosid);
            //modelBuilder.Entity<NT>()
            //   .HasOne<Topicos>(x => x.Topicosid)
            //   .WithMany(c => c.ListaNT)
            //   .HasForeignKey(x => x.TopicosFK);
            //modelBuilder.Entity<NT>()
            //    .HasOne<Noticias>(x => x.Noticiasid)
            //    .WithMany(c => c.ListaNT)
            //    .HasForeignKey(x => x.NoticiasidFK);

        }

        public DbSet<Imagens> Imagens { get; set; }
        public DbSet<NI> NI { get; set; }
        public DbSet<Noticias> Noticias { get; set; }
        public DbSet<NT> NT { get; set; }
        public DbSet<Topicos> Topicos { get; set; }
        public DbSet<Utilizadores> Utilizadores { get; set; }
    }

}
