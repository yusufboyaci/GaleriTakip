﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220502161337_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Araba", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Birim")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD Username");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<Guid>("GaleriId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<string>("ResimYolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Stok")
                        .HasColumnType("int");

                    b.Property<decimal?>("Ucret")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("GaleriId");

                    b.ToTable("Arabalar");
                });

            modelBuilder.Entity("Entities.Galeri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adres")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD Username");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Galeriler");
                });

            modelBuilder.Entity("Entities.Musteri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Ad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adres")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD Username");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<DateTime?>("DogumGunu")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ResimYolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TelefonNumarasi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("Entities.Siparis", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD Username");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<Guid>("MusteriId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("OnaylandiMi")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("Entities.SiparisDetay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("ArabaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created AD Username");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created By");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created Computer Name");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created Date");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Created IP");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Miktar")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified AD User Name");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Modified By");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified Computer Name");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modified IP");

                    b.Property<Guid?>("SiparisId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArabaId");

                    b.HasIndex("SiparisId");

                    b.ToTable("SiparisDetaylar");
                });

            modelBuilder.Entity("Entities.Araba", b =>
                {
                    b.HasOne("Entities.Galeri", "Galeri")
                        .WithMany("Arabalar")
                        .HasForeignKey("GaleriId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Galeri");
                });

            modelBuilder.Entity("Entities.Siparis", b =>
                {
                    b.HasOne("Entities.Musteri", "Musteri")
                        .WithMany("Siparisler")
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("Entities.SiparisDetay", b =>
                {
                    b.HasOne("Entities.Araba", "Araba")
                        .WithMany("SiparisDetaylar")
                        .HasForeignKey("ArabaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Siparis", "Siparis")
                        .WithMany("SiparisDetaylar")
                        .HasForeignKey("SiparisId");

                    b.Navigation("Araba");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("Entities.Araba", b =>
                {
                    b.Navigation("SiparisDetaylar");
                });

            modelBuilder.Entity("Entities.Galeri", b =>
                {
                    b.Navigation("Arabalar");
                });

            modelBuilder.Entity("Entities.Musteri", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("Entities.Siparis", b =>
                {
                    b.Navigation("SiparisDetaylar");
                });
#pragma warning restore 612, 618
        }
    }
}
