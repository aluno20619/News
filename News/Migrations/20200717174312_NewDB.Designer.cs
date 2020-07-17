﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using News.Data;

namespace News.Migrations
{
    [DbContext(typeof(NewsDb))]
    [Migration("20200717174312_NewDB")]
    partial class NewDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("News.Models.Imagens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Legenda")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Imagens");
                });

            modelBuilder.Entity("News.Models.NI", b =>
                {
                    b.Property<int>("Imagensid")
                        .HasColumnType("int");

                    b.Property<int>("Noticiasid")
                        .HasColumnType("int");

                    b.HasKey("Imagensid", "Noticiasid");

                    b.HasIndex("Noticiasid");

                    b.ToTable("NI");
                });

            modelBuilder.Entity("News.Models.NT", b =>
                {
                    b.Property<string>("Topicosid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Noticiasid")
                        .HasColumnType("int");

                    b.HasKey("Topicosid", "Noticiasid");

                    b.HasIndex("Noticiasid");

                    b.ToTable("NT");
                });

            modelBuilder.Entity("News.Models.Noticias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Corpo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_De_Publicacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resumo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UtilizadoresidFK")
                        .HasColumnType("int");

                    b.Property<bool>("Visivel")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UtilizadoresidFK");

                    b.ToTable("Noticias");
                });

            modelBuilder.Entity("News.Models.Topicos", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("Topicos");
                });

            modelBuilder.Entity("News.Models.Utilizadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Utilizadores");
                });

            modelBuilder.Entity("News.Models.NI", b =>
                {
                    b.HasOne("News.Models.Imagens", "Imagens")
                        .WithMany("ListaNI")
                        .HasForeignKey("Imagensid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News.Models.Noticias", "Noticias")
                        .WithMany("ListaNI")
                        .HasForeignKey("Noticiasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("News.Models.NT", b =>
                {
                    b.HasOne("News.Models.Noticias", "Noticias")
                        .WithMany("ListaNT")
                        .HasForeignKey("Noticiasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News.Models.Topicos", "Topicos")
                        .WithMany("ListaNT")
                        .HasForeignKey("Topicosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("News.Models.Noticias", b =>
                {
                    b.HasOne("News.Models.Utilizadores", "Utilizadoresid")
                        .WithMany("ListaNoticias")
                        .HasForeignKey("UtilizadoresidFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
