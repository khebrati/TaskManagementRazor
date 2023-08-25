using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TaskManagement
{
    public class TaskModel : PageModel
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string Category { get; set; }
        
        public DateTime DueDate {get; set; }
        public void OnGet()
        {
        }
    }
}
