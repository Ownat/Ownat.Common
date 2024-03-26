namespace Ownat.Common.Configs.Identity;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Contains extension methods for configuring JWT Bearer authentication.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Adds JWT Bearer authentication to the specified services.
    /// </summary>
    /// <param name="services">The services to add JWT Bearer authentication to.</param>
    /// <returns>An instance of <see cref="AuthenticationBuilder"/> that can be used to further configure the authentication services.</returns>
    public static AuthenticationBuilder AddJwtBearerAuthentication(this IServiceCollection services)
    {
        return services.ConfigureOptions<JwtBearerOptionsConfig>()
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer();
    }
}