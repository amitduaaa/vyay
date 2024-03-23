using Dvinci.VYAY.DataAccess.Subscriptions;
using Dvinci.VYAY.DataModel.Subscription;
using Microsoft.EntityFrameworkCore;

namespace Dvinci.VYAY.DataAccess;

public class VyayDataContext : DbContext
{
    
    public virtual DbSet<SubscriptionItem> Subscriptions { get; set; }


    public VyayDataContext(DbContextOptions<VyayDataContext> options) : base(options) { }

    public void EnsureCreated()
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SubscriptionsEntityConfiguration());
    }
}
