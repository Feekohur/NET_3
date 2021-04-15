using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using NET_3.Models;
using NET_3.Data;

namespace NET_3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AddressContext _context;

        private readonly ILogger<IndexModel> _logger;

        public IList<Address> Addresses { get; set; }


        [BindProperty]
        public Address Address { get; set; }


        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger, AddressContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Addresses = _context.Address.Where(p => p.Number == 10).ToList();
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

                Address.MakesValues(Address.Number);
                _context.Add(Address);
                _context.SaveChanges();

                HttpContext.Session.SetString("Ostatnio szukane", JsonConvert.SerializeObject(Address));
                //return RedirectToPage("./Address");
                return Page();
            }
            return Page();
        }


    }
}
