using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using api_aspnet_dotnet_csharp.Data;
using api_aspnet_dotnet_csharp.Models;

namespace api_aspnet_dotnet_csharp.Pages_Students
{
    public class DetailsModel : PageModel
    {
        private readonly api_aspnet_dotnet_csharp.Data.ApplicationDbContext _context;

        public DetailsModel(api_aspnet_dotnet_csharp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Student Student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FirstOrDefaultAsync(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                Student = student;
            }
            return Page();
        }
    }
}
