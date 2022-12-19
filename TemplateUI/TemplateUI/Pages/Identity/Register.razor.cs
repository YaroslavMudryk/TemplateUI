using TemplateUI.Models;

namespace TemplateUI.Pages.Identity
{
    public partial class Register
    {
        private readonly RegisterModel model = new RegisterModel();

        public bool ShowErrors { get; set; }

        public IEnumerable<string> Errors { get; set; }

        private async Task SubmitAsync()
        {

        }
    }
}