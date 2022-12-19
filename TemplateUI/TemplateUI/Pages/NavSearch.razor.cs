using TemplateUI.Models;
namespace TemplateUI.Pages
{
    public partial class NavSearch
    {
        private readonly SearchModel model = new SearchModel();

        private void Search() => this.NavigationManager.NavigateTo($"/search/{this.model.Query}?page=1");
    }
}