namespace Ownat.Common.Configs;

public class PostgreSqlConfig
{
    public string ConnectionString { get; init; } = string.Empty;

    public string Database { get; init; } = string.Empty;

    public string Host { get; init; } = string.Empty;

    public string Password { get; init; } = string.Empty;

    public int Port { get; init; }
}