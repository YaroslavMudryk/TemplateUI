using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TemplateUI.Extensions;

namespace TemplateUI
{
    public class Program
    {
        public static async Task Main(string[] args) =>
            await WebAssemblyHostBuilder
                .CreateDefault(args)
                .AddRootComponents()
                .AddClientServices()
                .Build()
                .RunAsync();
    }
}