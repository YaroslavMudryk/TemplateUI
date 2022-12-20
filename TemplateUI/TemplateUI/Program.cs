using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TemplateUI;
using TemplateUI.Extensions;

namespace TemplateUI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.AddRootComponents();

            builder.AddClientServices();

            await builder.Build().RunAsync();
        }
    }
}