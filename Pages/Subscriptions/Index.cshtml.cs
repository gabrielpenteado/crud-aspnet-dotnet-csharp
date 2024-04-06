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
    public class IndexModel : PageModel
    {
        private readonly api_aspnet_dotnet_csharp.Data.ApplicationDbContext _context;

        public IndexModel(api_aspnet_dotnet_csharp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Subscription> Subscription { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Subscription = await _context.Subscriptions
                .Include(s => s.Student).ToListAsync();
        }
    }
}
