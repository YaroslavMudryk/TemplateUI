using Microsoft.AspNetCore.Components;

namespace TemplateUI.Shared.Common
{
    public partial class ErrorsList
    {
        [Parameter]
        public bool ShowErrors { get; set; }

        [Parameter]
        public IEnumerable<string> Errors { get; set; }

        private void Reset() => this.ShowErrors = !this.ShowErrors;
    }
}