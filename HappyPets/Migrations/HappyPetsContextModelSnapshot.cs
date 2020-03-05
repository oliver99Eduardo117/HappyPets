﻿// <auto-generated />
using HappyPets.Models.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HappyPets.Migrations
{
    [DbContext(typeof(HappyPetsContext))]
    partial class HappyPetsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HappyPets.Models.DataBase.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("HappyPets.Models.DataBase.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<int>("PeopleId");

                    b.HasKey("Id");

                    b.HasIndex("PeopleId");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("HappyPets.Models.DataBase.Pet", b =>
                {
                    b.HasOne("HappyPets.Models.DataBase.People", "People")
                        .WithMany("Pets")
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
