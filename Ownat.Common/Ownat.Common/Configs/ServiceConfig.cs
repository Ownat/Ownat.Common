namespace Ownat.Common.Configs;

/// <summary>
/// Represents the configuration settings for a service.
/// </summary>
public class ServiceConfig
{
    /// <summary>
    /// Gets the name of the service.
    /// </summary>
    public string ServiceName { get; init; } = string.Empty;

    /// <summary>
    /// Gets the authority for the service.
    /// </summary>
    public string Authority { get; init; } = string.Empty;
}