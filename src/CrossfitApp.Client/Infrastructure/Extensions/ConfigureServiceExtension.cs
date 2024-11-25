using CrossfitApp.Client.Infrastructure.Authentication;
using Microsoft.AspNetCore.Components.Authorization;

namespace CrossfitApp.Client.Infrastructure.Extensions;

public static class ConfigureServiceExtension
{
    /// <summary>
    /// Configures security-related services in the application.
    /// This includes authorization setup, cascading authentication state,
    /// and implementation of a persistent authentication state provider.
    /// </summary>
    /// <param name="services">The application's service collection.</param>
    /// <returns>The service collection configured with security services.</returns>
    public static IServiceCollection AddSecurity(this IServiceCollection services)
    {
        services.AddAuthorizationCore();
        services.AddCascadingAuthenticationState();
        services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

        return services;
    }
}