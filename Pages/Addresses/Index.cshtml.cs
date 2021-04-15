using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NET_3.Data;
using NET_3.Models;

namespace NET_3.Pages.Addresses
{
    public class IndexModel : PageModel
    {
        private readonly NET_3.Data.AddressContext _context;

        public IndexModel(NET_3.Data.AddressContext context)
        {
            _context = context;
        }

        public IList<Address> Address { get;set; }

        public async Task OnGetAsync()
        {
            Address = await _context.Address.ToListAsync();
        }
    }
}
