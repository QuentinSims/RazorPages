using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestApp
{
    public class ProjectsModel : PageModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Technologies { get; set; }

        public string GithubUsername { get; set; }

        public void OnGet()
        {
            GithubUsername = "QuentinSims";
            Title = "1";
            Description = "Html";
            Technologies = "Html";
        }

    }
}
