using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using TemplateUI;
using TemplateUI.Shared;
using TemplateUI.Models;

namespace TemplateUI.Pages.Identity
{
    public partial class Login
    {
        private readonly LoginModel model = new LoginModel();
        public bool ShowErrors { get; set; }

        public IEnumerable<string> Errors { get; set; }

        private async Task SubmitAsync()
        {

        }
    }
}