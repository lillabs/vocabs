﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Configuration;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(VocabsDbContext))]
    [Migration("20221226190022_initialcommit6")]
    partial class initialcommit6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Model.Entities.ELanguage", b =>
                {
                    b.Property<string>("Value")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("VALUE");

                    b.HasKey("Value");

                    b.ToTable("E_LANGUAGES");
                });

            modelBuilder.Entity("Model.Entities.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FOLDER_ID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.Property<int?>("ParentFolderId")
                        .HasColumnType("int")
                        .HasColumnName("PARENT_FOLDER_ID");

                    b.HasKey("Id");

                    b.HasIndex("ParentFolderId");

                    b.ToTable("FOLDERS");
                });

            modelBuilder.Entity("Model.Entities.StudySet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("STUDY_SET_ID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRIPTION");

                    b.Property<int?>("FolderId")
                        .HasColumnType("int")
                        .HasColumnName("FOLDER_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("STUDY_SETS");
                });

            modelBuilder.Entity("Model.Entities.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WORD_ID");

                    b.Property<string>("LanguageId")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("LANGUAGE_ID");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("VALUE");

                    b.Property<string>("WORD_TYPE")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("WORDS_ST");

                    b.HasDiscriminator<string>("WORD_TYPE").HasValue("Word");
                });

            modelBuilder.Entity("Model.Entities.Wordpair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WORDPAIR_ID");

                    b.Property<int>("KnownWordId")
                        .HasColumnType("int")
                        .HasColumnName("KNOWN_WORD_ID");

                    b.Property<int>("LearningWordId")
                        .HasColumnType("int")
                        .HasColumnName("LEARNING_WORD_ID");

                    b.Property<int>("StudySetId")
                        .HasColumnType("int")
                        .HasColumnName("STUDY_SET_ID");

                    b.HasKey("Id");

                    b.HasIndex("KnownWordId");

                    b.HasIndex("LearningWordId");

                    b.HasIndex("StudySetId");

                    b.ToTable("WORDPAIRS");
                });

            modelBuilder.Entity("Model.Entities.WordTypes.Adjective", b =>
                {
                    b.HasBaseType("Model.Entities.Word");

                    b.ToTable("WORDS_ST");

                    b.HasDiscriminator().HasValue("ADJECTIVE");
                });

            modelBuilder.Entity("Model.Entities.WordTypes.Adverb", b =>
                {
                    b.HasBaseType("Model.Entities.Word");

                    b.ToTable("WORDS_ST");

                    b.HasDiscriminator().HasValue("ADVERB");
                });

            modelBuilder.Entity("Model.Entities.WordTypes.Conjunction", b =>
                {
                    b.HasBaseType("Model.Entities.Word");

                    b.ToTable("WORDS_ST");

                    b.HasDiscriminator().HasValue("CONJUNCTION");
                });

            modelBuilder.Entity("Model.Entities.WordTypes.Interjection", b =>
                {
                    b.HasBaseType("Model.Entities.Word");

                    b.ToTable("WORDS_ST");

                    b.HasDiscriminator().HasValue("INTERJECTION");
                });

            modelBuilder.Entity("Model.Entities.WordTypes.Noun", b =>
                {
                    b.HasBaseType("Model.Entities.Word");

                    b.ToTable("WORDS_ST");

                    b.HasDiscriminator().HasValue("NOUN");
                });

            modelBuilder.Entity("Model.Entities.WordTypes.Preposition", b =>
                {
                    b.HasBaseType("Model.Entities.Word");

                    b.ToTable("WORDS_ST");

                    b.HasDiscriminator().HasValue("PREPOSITION");
                });

            modelBuilder.Entity("Model.Entities.WordTypes.Pronoun", b =>
                {
                    b.HasBaseType("Model.Entities.Word");

                    b.ToTable("WORDS_ST");

                    b.HasDiscriminator().HasValue("PRONOUN");
                });

            modelBuilder.Entity("Model.Entities.WordTypes.Verb", b =>
                {
                    b.HasBaseType("Model.Entities.Word");

                    b.ToTable("WORDS_ST");

                    b.HasDiscriminator().HasValue("VERB");
                });

            modelBuilder.Entity("Model.Entities.Folder", b =>
                {
                    b.HasOne("Model.Entities.Folder", "ParentFolder")
                        .WithMany()
                        .HasForeignKey("ParentFolderId");

                    b.Navigation("ParentFolder");
                });

            modelBuilder.Entity("Model.Entities.StudySet", b =>
                {
                    b.HasOne("Model.Entities.Folder", "Folder")
                        .WithMany()
                        .HasForeignKey("FolderId");

                    b.Navigation("Folder");
                });

            modelBuilder.Entity("Model.Entities.Word", b =>
                {
                    b.HasOne("Model.Entities.ELanguage", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Model.Entities.Wordpair", b =>
                {
                    b.HasOne("Model.Entities.Word", "KnownWord")
                        .WithMany()
                        .HasForeignKey("KnownWordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Word", "LearningWord")
                        .WithMany()
                        .HasForeignKey("LearningWordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.StudySet", "StudySet")
                        .WithMany()
                        .HasForeignKey("StudySetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KnownWord");

                    b.Navigation("LearningWord");

                    b.Navigation("StudySet");
                });
#pragma warning restore 612, 618
        }
    }
}
