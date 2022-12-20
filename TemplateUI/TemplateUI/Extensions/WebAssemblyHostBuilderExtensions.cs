using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;
using TemplateUI.Infrastructure;

namespace TemplateUI.Extensions
{
    public static class WebAssemblyHostBuilderExtensions
    {
        private const string ClientName = "ServerAPI";
        public static WebAssemblyHostBuilder AddRootComponents(this WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            return builder;
        }

        public static WebAssemblyHostBuilder AddClientServices(this WebAssemblyHostBuilder builder)
        {
            builder
                .Services
                .AddAuthorizationCore()
                .AddBlazoredToast()
                .AddBlazoredLocalStorage()
                .AddScoped<ApiAuthenticationStateProvider>()
                .AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>()
                .AddScoped(sp => sp
                    .GetRequiredService<IHttpClientFactory>()
                    .CreateClient(ClientName))
                //ToDo: here add services
                .AddTransient<AuthenticationHeaderHandler>()
                .AddHttpClient(
                    ClientName,
                    client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<AuthenticationHeaderHandler>();

            return builder;
        }
    }
}
