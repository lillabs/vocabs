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
    [Migration("20221231143720_initialcommit")]
    partial class initialcommit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Model.Entities.Auth.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ROLE_ID");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("IDENTIFIER");

                    b.HasKey("Id");

                    b.HasIndex("Identifier")
                        .IsUnique();

                    b.ToTable("ROLES");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Administrator",
                            Identifier = "Admin"
                        });
                });

            modelBuilder.Entity("Model.Entities.Auth.RoleClaim", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("ROLE_ID");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("USER_HAS_ROLES_JT");
                });

            modelBuilder.Entity("Model.Entities.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("PASSWORD_HASH");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)")
                        .HasColumnName("USERNAME");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("USERS");
                });

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

                    b.UseTphMappingStrategy();
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

            modelBuilder.Entity("Model.Entities.Auth.RoleClaim", b =>
                {
                    b.HasOne("Model.Entities.Auth.Role", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Auth.User", "User")
                        .WithMany("RoleClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
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

            modelBuilder.Entity("Model.Entities.Auth.Role", b =>
                {
                    b.Navigation("RoleClaims");
                });

            modelBuilder.Entity("Model.Entities.Auth.User", b =>
                {
                    b.Navigation("RoleClaims");
                });
#pragma warning restore 612, 618
        }
    }
}