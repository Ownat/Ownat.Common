using System.Reflection;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ownat.Common.Configs.MassTransit;

/// <summary>
/// Contains extension methods for configuring MassTransit with RabbitMQ.
/// </summary>
/// <remarks>
/// This class provides a method to add MassTransit with RabbitMQ to the services collection.
/// It configures the RabbitMQ host using the provided configuration and sets up the endpoints and message retry policy.
/// </remarks>
public static class Extensions
{
    /// <summary>
    /// Adds MassTransit with RabbitMQ to the specified services.
    /// </summary>
    /// <param name="services">The services to add MassTransit with RabbitMQ to.</param>
    /// <returns>The services collection with MassTransit added.</returns>
    /// <remarks>
    /// This method configures MassTransit to use RabbitMQ as the transport.
    /// It retrieves the RabbitMQ configuration from the provided services and uses it to configure the RabbitMQ host.
    /// It also configures the endpoints and sets up a message retry policy.
    /// </remarks>
    public static IServiceCollection AddMassTransitWithRabbitMq(this IServiceCollection services)
    {
        services.AddMassTransit(x =>
        {
            x.AddConsumers(Assembly.GetEntryAssembly());
            x.UsingRabbitMq((context, cfg) =>
            {
                var configuration = context.GetService<IConfiguration>();
                var serviceConfig = configuration?.GetSection(nameof(ServiceConfig)).Get<ServiceConfig>();
                var rabbitMqConfig = configuration?.GetSection(nameof(RabbitMqConfig)).Get<RabbitMqConfig>();
                cfg.Host(rabbitMqConfig?.HostName, "/", h =>
                {
                    h.Username(rabbitMqConfig?.UserName);
                    h.Password(rabbitMqConfig?.Password);
                });
                cfg.ConfigureEndpoints(context, new KebabCaseEndpointNameFormatter(serviceConfig?.ServiceName));
                cfg.UseMessageRetry(retryCfg =>
                {
                    retryCfg.Interval(3, TimeSpan.FromSeconds(10));
                });
            });
        });

        return services;
    }
}