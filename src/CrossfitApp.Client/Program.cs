using CrossfitApp.Client;
using CrossfitApp.Client.Infrastructure.Extensions;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<_Imports>());
builder.Services.AddSecurity();

builder.Services.AddAuthorizationCore();

builder.Services
    .AddScoped(sp => sp
        .GetRequiredService<IHttpClientFactory>()
        .CreateClient("API"))
    .AddHttpClient("API", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

await builder.Build().RunAsync();
