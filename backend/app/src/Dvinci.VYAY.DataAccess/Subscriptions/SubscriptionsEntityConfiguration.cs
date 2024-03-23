using Dvinci.VYAY.DataModel.Subscription;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvinci.VYAY.DataAccess.Subscriptions;

public class SubscriptionsEntityConfiguration : IEntityTypeConfiguration<SubscriptionItem>
{
    public void Configure(EntityTypeBuilder<SubscriptionItem> builder)
    {
        // Table name
        builder.ToTable("subscriptions");

        // Primary key
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
              .ValueGeneratedOnAdd();

        builder.Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(100);
        builder.Property(x => x.Url).HasColumnName("url").IsRequired().HasMaxLength(255);
        builder.Property(x => x.Price).HasColumnName("price").IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(x => x.Category).HasColumnName("category").HasMaxLength(50);
        builder.Property(x => x.Notes).HasColumnName("notes").HasMaxLength(500);
        builder.Property(x => x.Date).HasColumnName("date").IsRequired();
        builder.Property(x => x.Cycle).HasColumnName("cycle").IsRequired()
            .HasConversion(
                v => v.ToString(),
                v => (SubscriptionCycle)Enum.Parse(typeof(SubscriptionCycle), v!)
            );
        builder.Property(x => x.CreationDate).HasColumnName("creation_date")
            .HasDefaultValue(DateTimeOffset.UtcNow).ValueGeneratedOnAdd();
        builder.Property(x => x.UpdationDate).HasColumnName("updation_date")
            .HasDefaultValue(DateTimeOffset.UtcNow).ValueGeneratedOnAddOrUpdate()
            .IsConcurrencyToken();
    }
}
