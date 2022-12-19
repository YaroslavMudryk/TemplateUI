namespace TemplateUI.Pages.Identity
{
    public partial class Logout
    {
        private async Task Submit()
        {
            this.ToastService.ShowSuccess("You have successfully logged out.");
            //Logout
        }
    }
}