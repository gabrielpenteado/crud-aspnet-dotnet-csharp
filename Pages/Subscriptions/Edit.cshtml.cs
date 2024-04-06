using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using api_aspnet_dotnet_csharp.Data;
using api_aspnet_dotnet_csharp.Models;

namespace api_aspnet_dotnet_csharp.Pages_Subscriptions
{
    public class EditModel : PageModel
    {
        private readonly api_aspnet_dotnet_csharp.Data.ApplicationDbContext _context;

        public EditModel(api_aspnet_dotnet_csharp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Subscription Subscription { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription =  await _context.Subscriptions.FirstOrDefaultAsync(m => m.ID == id);
            if (subscription == null)
            {
                return NotFound();
            }
            Subscription = subscription;
           ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Email");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Subscription).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubscriptionExists(Subscription.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SubscriptionExists(int id)
        {
            return _context.Subscriptions.Any(e => e.ID == id);
        }
    }
}
