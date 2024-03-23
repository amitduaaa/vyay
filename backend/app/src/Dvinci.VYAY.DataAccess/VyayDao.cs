using Dvinci.VYAY.Common.Configs;
using Microsoft.Extensions.Options;

namespace Dvinci.VYAY.DataAccess;

public interface IVyayDao
{
    public void EnsureCreated();
    public VyayDataContext GetContext();
}

public class VyayDao : IVyayDao
{
    private readonly VyayDataContext _context;
    public VyayDao(VyayDataContext context)
    {
        _context = context;
    }

    public void EnsureCreated()
    {
        _context.Database.EnsureCreated();
    }

    public VyayDataContext GetContext()
    {
        return _context;
    }
}

public struct VyayDaoContainers
{
    public static string Subscriptions => "subscriptions";
}