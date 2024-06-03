﻿// <auto-generated />
using System;
using Look_For_It.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Look_For_It.Db.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Look_For_It.Db.Models.Phrase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Phrase_os")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phrase_ru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Phrases");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Phrase_os = "Дæ ном куыд у?",
                            Phrase_ru = "Как тебя зовут?",
                            Theme = "Без темы"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Phrase_os = "Дæ(Уæ) рáйсом хорз",
                            Phrase_ru = "Доброе утро",
                            Theme = "Без темы"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            Phrase_os = "Дæ и́зæр хорз",
                            Phrase_ru = "Добрый вечер",
                            Theme = "Без темы"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            Phrase_os = "Дæ бон хорз",
                            Phrase_ru = "Добрый день",
                            Theme = "Без темы"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            Phrase_os = "Хæрхǽхсæв",
                            Phrase_ru = "Спокойной ночи",
                            Theme = "Без темы"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            Phrase_os = "О",
                            Phrase_ru = "Да",
                            Theme = "Без темы"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000007"),
                            Phrase_os = "Нæ",
                            Phrase_ru = "Нет",
                            Theme = "Без темы"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000008"),
                            Phrase_os = "Хорз",
                            Phrase_ru = "Хорошо",
                            Theme = "Без темы"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000009"),
                            Phrase_os = "Бузныг",
                            Phrase_ru = "Спасибо",
                            Theme = "Без темы"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000010"),
                            Phrase_os = "Стыр Бузныг",
                            Phrase_ru = "Большое спасибо",
                            Theme = "Без темы"
                        });
                });

            modelBuilder.Entity("Look_For_It.Db.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-aaaa-aaaa-aaaa-000000000000"),
                            Email = "admin@admin.ru",
                            Name = "admin",
                            Password = "aDMiN"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
