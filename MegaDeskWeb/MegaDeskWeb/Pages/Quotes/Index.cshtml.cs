﻿using System;
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

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
