﻿// <auto-generated />
using System;
using Dvinci.VYAY.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Dvinci.VYAY.DataAccess.Migrations
{
    [DbContext(typeof(VyayDataContext))]
    partial class VyayDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Dvinci.VYAY.DataModel.Subscription.SubscriptionItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Category")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("category")
                        .HasAnnotation("Relational:JsonPropertyName", "category");

                    b.Property<DateTimeOffset>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2024, 3, 23, 13, 47, 3, 747, DateTimeKind.Unspecified).AddTicks(4401), new TimeSpan(0, 0, 0, 0, 0)))
                        .HasColumnName("creation_date");

                    b.Property<string>("Cycle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cycle")
                        .HasAnnotation("Relational:JsonPropertyName", "cycle");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date")
                        .HasAnnotation("Relational:JsonPropertyName", "date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("notes")
                        .HasAnnotation("Relational:JsonPropertyName", "notes");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("price")
                        .HasAnnotation("Relational:JsonPropertyName", "price");

                    b.Property<DateTimeOffset>("UpdationDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2024, 3, 23, 13, 47, 3, 747, DateTimeKind.Unspecified).AddTicks(4745), new TimeSpan(0, 0, 0, 0, 0)))
                        .HasColumnName("updation_date");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("url")
                        .HasAnnotation("Relational:JsonPropertyName", "url");

                    b.HasKey("Id");

                    b.ToTable("subscriptions", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
