namespace Dvinci.VYAY.Common.Configs;

public interface IDvinciConfig
{
    public static string SectionName { get; }
    public void SetDefaults();
    public bool ValidateConfig();
}
