namespace Ownat.Common.Configs;

/// <summary>
/// Represents the configuration settings for a PostgreSQL database.
/// </summary>
public class PostgreSqlConfig
{
    /// <summary>
    /// Gets the connection string for the PostgreSQL database.
    /// </summary>
    public string ConnectionString { get; init; } = string.Empty;

    /// <summary>
    /// Gets the name of the PostgreSQL database.
    /// </summary>
    public string Database { get; init; } = string.Empty;

    /// <summary>
    /// Gets the host of the PostgreSQL database.
    /// </summary>
    public string Host { get; init; } = string.Empty;

    /// <summary>
    /// Gets the password for the PostgreSQL database.
    /// </summary>
    public string Password { get; init; } = string.Empty;

    /// <summary>
    /// Gets the port number for the PostgreSQL database.
    /// </summary>
    public int Port { get; init; }
}