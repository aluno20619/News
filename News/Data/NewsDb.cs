
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
            modelBuilder.Entity<NI>()
                .HasKey(o => new { o.Imagensid, o.Noticiasid});
            modelBuilder.Entity<NT>()
                .HasKey(o => new{ o.Topicosid, o.Noticiasid});
        }

        public DbSet<Imagens> Imagens { get; set; }
        public DbSet<NI> NI { get; set; }
        public DbSet<Noticias> Noticias { get; set; }
        public DbSet<NT> NT { get; set; }
        public DbSet<Topicos> Topicos { get; set; }
        public DbSet<Utilizadores> Utilizadores { get; set; }
    }

}
