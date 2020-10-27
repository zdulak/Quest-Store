﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuestStore.Infrastructure.Data;

namespace QuestStore.Infrastructure.Data.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20201022143424_SeedFakeData")]
    partial class SeedFakeData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuestStore.Core.Entities.Artifact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Artifact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 502,
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Rustic Rubber Soap"
                        },
                        new
                        {
                            Id = 2,
                            Cost = 279,
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Rustic Frozen Salad",
                            Quantity = 4
                        },
                        new
                        {
                            Id = 3,
                            Cost = 398,
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Fantastic Concrete Hat",
                            Quantity = 9
                        },
                        new
                        {
                            Id = 4,
                            Cost = 755,
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Ergonomic Soft Tuna"
                        },
                        new
                        {
                            Id = 5,
                            Cost = 293,
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Handmade Fresh Chips",
                            Quantity = 6
                        },
                        new
                        {
                            Id = 6,
                            Cost = 752,
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Awesome Metal Cheese"
                        },
                        new
                        {
                            Id = 7,
                            Cost = 584,
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Awesome Plastic Ball"
                        },
                        new
                        {
                            Id = 8,
                            Cost = 192,
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Practical Fresh Pants"
                        },
                        new
                        {
                            Id = 9,
                            Cost = 239,
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Name = "Refined Frozen Cheese"
                        },
                        new
                        {
                            Id = 10,
                            Cost = 866,
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Ergonomic Fresh Pants",
                            Quantity = 7
                        });
                });

            modelBuilder.Entity("QuestStore.Core.Entities.Classroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classroom");
                });

            modelBuilder.Entity("QuestStore.Core.Entities.MentorClassroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassroomId")
                        .HasColumnType("int");

                    b.Property<int>("MentorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("MentorId");

                    b.ToTable("MentorClassroom");
                });

            modelBuilder.Entity("QuestStore.Core.Entities.Quest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reward")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Generic Wooden Ball",
                            Reward = 147,
                            Type = "Extra"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Awesome Soft Sausages",
                            Reward = 467,
                            Type = "Basic"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Awesome Concrete Chicken",
                            Reward = 629,
                            Type = "Basic"
                        },
                        new
                        {
                            Id = 4,
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Sleek Granite Towels",
                            Reward = 274,
                            Type = "Extra"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Handmade Steel Tuna",
                            Reward = 172,
                            Type = "Basic"
                        },
                        new
                        {
                            Id = 6,
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Licensed Rubber Fish",
                            Reward = 294,
                            Type = "Extra"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Intelligent Plastic Tuna",
                            Reward = 168,
                            Type = "Basic"
                        },
                        new
                        {
                            Id = 8,
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Handcrafted Soft Soap",
                            Reward = 325,
                            Type = "Extra"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Rustic Granite Sausages",
                            Reward = 19,
                            Type = "Extra"
                        },
                        new
                        {
                            Id = 10,
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Handcrafted Cotton Bacon",
                            Reward = 56,
                            Type = "Basic"
                        });
                });

            modelBuilder.Entity("QuestStore.Core.Entities.StudentArtifact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtifactId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtifactId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentArtifact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtifactId = 7,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 2,
                            ArtifactId = 9,
                            StudentId = 8
                        },
                        new
                        {
                            Id = 3,
                            ArtifactId = 10,
                            StudentId = 9
                        },
                        new
                        {
                            Id = 4,
                            ArtifactId = 4,
                            StudentId = 7
                        },
                        new
                        {
                            Id = 5,
                            ArtifactId = 1,
                            StudentId = 4
                        },
                        new
                        {
                            Id = 6,
                            ArtifactId = 1,
                            StudentId = 9
                        },
                        new
                        {
                            Id = 7,
                            ArtifactId = 8,
                            StudentId = 8
                        },
                        new
                        {
                            Id = 8,
                            ArtifactId = 4,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 9,
                            ArtifactId = 3,
                            StudentId = 7
                        },
                        new
                        {
                            Id = 10,
                            ArtifactId = 1,
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("QuestStore.Core.Entities.StudentClassroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassroomId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentClassroom");
                });

            modelBuilder.Entity("QuestStore.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasDiscriminator<string>("Role").HasValue("Admin");
                });

            modelBuilder.Entity("QuestStore.Core.Entities.Mentor", b =>
                {
                    b.HasBaseType("QuestStore.Core.Entities.User");

                    b.HasDiscriminator().HasValue("Mentor");
                });

            modelBuilder.Entity("QuestStore.Core.Entities.Student", b =>
                {
                    b.HasBaseType("QuestStore.Core.Entities.User");

                    b.Property<int>("Coins")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Try to transmit the COM system, maybe it will transmit the redundant system!",
                            Email = "Karla.Corwin@yahoo.com",
                            Name = "Karla",
                            Surname = "Corwin",
                            Coins = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "If we override the feed, we can get to the FTP feed through the digital FTP feed!",
                            Email = "Floyd.Gleason77@hotmail.com",
                            Name = "Floyd",
                            Surname = "Gleason",
                            Coins = 0
                        },
                        new
                        {
                            Id = 3,
                            Description = "You can't synthesize the circuit without synthesizing the redundant IB circuit!",
                            Email = "Lawrence90@hotmail.com",
                            Name = "Lawrence",
                            Surname = "Kilback",
                            Coins = 0
                        },
                        new
                        {
                            Id = 4,
                            Description = "You can't override the array without calculating the optical JSON array!",
                            Email = "Judith_Herzog3@yahoo.com",
                            Name = "Judith",
                            Surname = "Herzog",
                            Coins = 0
                        },
                        new
                        {
                            Id = 5,
                            Description = "The GB array is down, navigate the multi-byte array so we can navigate the GB array!",
                            Email = "Daryl_Kshlerin@hotmail.com",
                            Name = "Daryl",
                            Surname = "Kshlerin",
                            Coins = 0
                        },
                        new
                        {
                            Id = 6,
                            Description = "If we navigate the monitor, we can get to the JBOD monitor through the virtual JBOD monitor!",
                            Email = "Barbara.VonRueden0@gmail.com",
                            Name = "Barbara",
                            Surname = "VonRueden",
                            Coins = 0
                        },
                        new
                        {
                            Id = 7,
                            Description = "We need to program the bluetooth XML transmitter!",
                            Email = "Saul.Tillman34@yahoo.com",
                            Name = "Saul",
                            Surname = "Tillman",
                            Coins = 0
                        },
                        new
                        {
                            Id = 8,
                            Description = "The AI hard drive is down, connect the back-end hard drive so we can connect the AI hard drive!",
                            Email = "Preston.Padberg70@hotmail.com",
                            Name = "Preston",
                            Surname = "Padberg",
                            Coins = 0
                        },
                        new
                        {
                            Id = 9,
                            Description = "I'll transmit the open-source IB monitor, that should monitor the IB monitor!",
                            Email = "Maggie7@hotmail.com",
                            Name = "Maggie",
                            Surname = "Denesik",
                            Coins = 0
                        },
                        new
                        {
                            Id = 10,
                            Description = "Use the optical SAS bandwidth, then you can compress the optical bandwidth!",
                            Email = "Abraham1@hotmail.com",
                            Name = "Abraham",
                            Surname = "Kuphal",
                            Coins = 0
                        });
                });

            modelBuilder.Entity("QuestStore.Core.Entities.MentorClassroom", b =>
                {
                    b.HasOne("QuestStore.Core.Entities.Classroom", "Classroom")
                        .WithMany("Mentors")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestStore.Core.Entities.Mentor", "Mentor")
                        .WithMany("Classrooms")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuestStore.Core.Entities.StudentArtifact", b =>
                {
                    b.HasOne("QuestStore.Core.Entities.Artifact", "Artifact")
                        .WithMany("Students")
                        .HasForeignKey("ArtifactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestStore.Core.Entities.Student", "Student")
                        .WithMany("Artifacts")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuestStore.Core.Entities.StudentClassroom", b =>
                {
                    b.HasOne("QuestStore.Core.Entities.Classroom", "Classroom")
                        .WithMany("Students")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestStore.Core.Entities.Student", "Student")
                        .WithMany("Classrooms")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}