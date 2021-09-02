using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace TestApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string FullName { get; set; }
        public string LinkedInUserName { get; set; }
        public int experience { get; set; }
        public List<string> skills { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Quentin Sims";
            LinkedInUserName = "Quentin Sims";
            experience = 4;
            skills = new List<string>
            {
                "C#",
                "Python",
                "Javascript",
                "SQL",
                ".Net"
            };
        }
    }
}
