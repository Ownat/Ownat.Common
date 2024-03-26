// <copyright file="JwtBearerOptionsConfig.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ownat.Common.Configs.Identity;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

/// <summary>
/// Configures the options for JWT Bearer authentication.
/// </summary>
/// <remarks>
/// This class is responsible for configuring the JWT Bearer authentication options based on the provided configuration.
/// It implements the IConfigureNamedOptions interface which allows it to configure named options.
/// </remarks>
public class JwtBearerOptionsConfig(IConfiguration configuration) : IConfigureNamedOptions<JwtBearerOptions>
{
    /// <summary>
    /// Configures the JWT Bearer options.
    /// </summary>
    /// <param name="options">The options to configure.</param>
    public void Configure(JwtBearerOptions options)
    {
        this.Configure(JwtBearerDefaults.AuthenticationScheme, options);
    }

    /// <summary>
    /// Configures the JWT Bearer options for a specific authentication scheme.
    /// </summary>
    /// <param name="name">The name of the authentication scheme.</param>
    /// <param name="options">The options to configure.</param>
    /// <remarks>
    /// This method only configures the options for the default JWT Bearer authentication scheme.
    /// </remarks>
    public void Configure(string? name, JwtBearerOptions options)
    {
        if (name != JwtBearerDefaults.AuthenticationScheme)
        {
            return;
        }

        var serviceConfig = configuration.GetSection(nameof(ServiceConfig)).Get<ServiceConfig>();
        options.RequireHttpsMetadata = false;
        options.Authority = serviceConfig?.Authority;
        options.Audience = serviceConfig?.ServiceName;
        options.MapInboundClaims = false;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            NameClaimType = "name",
            RoleClaimType = "role",
        };
    }
}