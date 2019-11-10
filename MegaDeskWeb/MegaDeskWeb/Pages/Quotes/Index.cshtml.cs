using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Models;

namespace MegaDeskWeb.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        public IndexModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public string NameSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {

            NameSort = String.IsNullOrEmpty(sortOrder) ? "Name" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<DeskQuote> deskQuotes = from s in _context.DeskQuote
                                             select s;

            switch (sortOrder)
            {
                case "Name":
                    deskQuotes = deskQuotes.OrderBy(s => s.CustomerName);
                    break;
                case "Date":
                    deskQuotes = deskQuotes.OrderBy(s => s.QuoteDate);
                    break;
                default:
                    deskQuotes = deskQuotes.OrderBy(s => s.QuotePrice);
                    break;
            }
  
            if (!string.IsNullOrEmpty(SearchString))
            {
                deskQuotes = deskQuotes.Where(s => s.CustomerName.Contains(SearchString));
            }

            //DeskQuote = await quotes.ToListAsync();
            DeskQuote = await deskQuotes.AsNoTracking().ToListAsync();
        }
    }
}
