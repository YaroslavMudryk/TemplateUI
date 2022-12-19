using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Blazored.LocalStorage;
using Blazored.Toast;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using TemplateUI;
using TemplateUI.Shared;
using TemplateUI.Shared.Common;
using TemplateUI.Pages;
using TemplateUI.Pages.Identity;

namespace TemplateUI.Shared.Common
{
    public partial class Header
    {
        private string _user;

        protected override async Task OnInitializedAsync()
        {
            var authState = await this.AuthState.GetAuthenticationStateAsync();

            if (authState.User.Identity.IsAuthenticated)
                _user = authState.User.FindFirst(s => s.Type == "Data").Value;

            await base.OnInitializedAsync();
        }
    }
}