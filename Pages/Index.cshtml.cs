using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;

namespace TaskManagement
{
    public class IndexModel : PageModel
    {
        public List<TaskModel> Tasks { get; set; } 
        public void OnGet()
        {
            Tasks = new()
            {
                new()
                {
                    Title = "Code",
                    Description = "Do it in razor pages",
                    Category = "Programming",
                    DueDate = DateTime.Now.AddDays(2)
                },
                new()
                {
                    Title = "Study",
                    Description = "Logical circuits",
                    Category = "KNTU",
                    DueDate = DateTime.Now.AddDays(1)
                }
            };
        }
    }
}
