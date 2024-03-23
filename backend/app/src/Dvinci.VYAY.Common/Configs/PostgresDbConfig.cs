namespace Dvinci.VYAY.Common.Configs;

public class PostgresDbConfig : IDvinciConfig
{
    public string? ConnectionString { get; set; }

    public static string SectionName => "PostgresDbSettings";

    public void SetDefaults() { }

    public bool ValidateConfig()
    {
        SetDefaults();

        if (string.IsNullOrWhiteSpace(ConnectionString))
            throw new ArgumentNullException($"Please add {nameof(ConnectionString)} in {SectionName}");
        return true;
    }

}
