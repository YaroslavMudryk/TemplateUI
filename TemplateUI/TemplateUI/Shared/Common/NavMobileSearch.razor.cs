using TemplateUI.Models;

namespace TemplateUI.Shared.Common
{
    public partial class NavMobileSearch
    {
        private readonly SearchModel model = new SearchModel();

        private void Search()
            => this.NavigationManager.NavigateTo($"/search/{this.model.Query}?page=1");
    }
}