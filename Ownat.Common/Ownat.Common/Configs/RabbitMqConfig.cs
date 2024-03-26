namespace Ownat.Common.Configs;

/// <summary>
/// Represents the configuration settings for a RabbitMQ server.
/// </summary>
public class RabbitMqConfig
{
    /// <summary>
    /// Gets the host name of the RabbitMQ server.
    /// </summary>
    public string HostName { get; init; } = string.Empty;

    /// <summary>
    /// Gets the username for the RabbitMQ server.
    /// </summary>
    public string UserName { get; init; } = string.Empty;

    /// <summary>
    /// Gets the password for the RabbitMQ server.
    /// </summary>
    public string Password { get; init; } = string.Empty;
}