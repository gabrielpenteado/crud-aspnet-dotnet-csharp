using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using api_aspnet_dotnet_csharp.Data;
using api_aspnet_dotnet_csharp.Models;

namespace api_aspnet_dotnet_csharp.Pages_Subscriptions
{
    public class DetailsModel : PageModel
    {
        private readonly api_aspnet_dotnet_csharp.Data.ApplicationDbContext _context;

        public DetailsModel(api_aspnet_dotnet_csharp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Subscription Subscription { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscriptions.FirstOrDefaultAsync(m => m.ID == id);
            if (subscription == null)
            {
                return NotFound();
            }
            else
            {
                Subscription = subscription;
            }
            return Page();
        }
    }
}
