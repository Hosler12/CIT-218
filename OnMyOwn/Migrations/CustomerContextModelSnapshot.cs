﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnMyOwn.Models;

namespace OnMyOwn.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnMyOwn.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("PhoneId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "01 Fictional Road",
                            City = "Traverse City",
                            CustomerName = "Amanda Apple",
                            CustomerPhone = "231-499-5412",
                            PhoneId = 3,
                            State = "Michigan"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "23 Almost Real Drive",
                            City = "Traverse City",
                            CustomerName = "Barry Burro",
                            CustomerPhone = "231-454-4545",
                            PhoneId = 3,
                            State = "Mich"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "45 Kind of Fake Street",
                            City = "Traverse City",
                            CustomerName = "Cindy Cavendish",
                            CustomerPhone = "231-489-8474",
                            PhoneId = 5,
                            State = "Panic"
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "67 Entirely False Boulevard",
                            City = "Traverse City",
                            CustomerName = "Danny Dacca",
                            CustomerPhone = "231-458-5454",
                            PhoneId = 4,
                            State = "MI"
                        },
                        new
                        {
                            CustomerId = 5,
                            Address = "89 Something Witty Avenue",
                            City = "Traverse City",
                            CustomerName = "Emily ",
                            CustomerPhone = "231-848-6842",
                            PhoneId = 4,
                            State = "MI"
                        });
                });

            modelBuilder.Entity("OnMyOwn.Models.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhoneName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneId");

                    b.ToTable("Phone");

                    b.HasData(
                        new
                        {
                            PhoneId = 1,
                            PhoneName = "Mini-Phone",
                            PhoneType = "Mobile"
                        },
                        new
                        {
                            PhoneId = 2,
                            PhoneName = "Super-Phone",
                            PhoneType = "Mobile"
                        },
                        new
                        {
                            PhoneId = 3,
                            PhoneName = "Mega-Phone",
                            PhoneType = "Lanline"
                        },
                        new
                        {
                            PhoneId = 4,
                            PhoneName = "Multi-Phone",
                            PhoneType = "Landline"
                        },
                        new
                        {
                            PhoneId = 5,
                            PhoneName = "Classic-Phone",
                            PhoneType = "Mobile"
                        });
                });

            modelBuilder.Entity("OnMyOwn.Models.Customer", b =>
                {
                    b.HasOne("OnMyOwn.Models.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
