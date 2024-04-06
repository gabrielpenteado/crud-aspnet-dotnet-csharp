using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using api_aspnet_dotnet_csharp.Data;
using api_aspnet_dotnet_csharp.Models;

namespace api_aspnet_dotnet_csharp.Pages_Subscriptions
{
    public class CreateModel : PageModel
    {
        private readonly api_aspnet_dotnet_csharp.Data.ApplicationDbContext _context;

        public CreateModel(api_aspnet_dotnet_csharp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Email");
            return Page();
        }

        [BindProperty]
        public Subscription Subscription { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Subscriptions.Add(Subscription);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
