﻿// <auto-generated />
using System;
using Bludata.Teste.CSharp.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bludata.Teste.CSharp.Infra.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200501025626_Bludata Tese")]
    partial class BludataTese
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bludata.Teste.CSharp.Domain.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CNPJ")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Fantasy")
                        .IsRequired()
                        .HasColumnName("Fantasy");

                    b.Property<int>("StateId")
                        .HasColumnName("StateId");

                    b.Property<DateTime>("Update_At");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Bludata.Teste.CSharp.Domain.Entities.Provider", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<bool>("Active");

                    b.Property<string>("CNPJProvider")
                        .IsRequired()
                        .HasColumnName("CNPJProvider");

                    b.Property<string>("CPF")
                        .HasColumnName("CPF");

                    b.Property<Guid>("CompanyId");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnName("ContactNumber");

                    b.Property<DateTime>("Create_At")
                        .HasColumnName("Create_At");

                    b.Property<DateTime>("DateBirth");

                    b.Property<string>("Name")
                        .HasColumnName("Name");

                    b.Property<int>("PersonType")
                        .HasColumnName("PersonType");

                    b.Property<string>("RG")
                        .HasColumnName("RG");

                    b.Property<int>("State");

                    b.Property<DateTime>("Update_At");

                    b.HasKey("Id");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("Bludata.Teste.CSharp.Domain.Entities.Provider", b =>
                {
                    b.HasOne("Bludata.Teste.CSharp.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
