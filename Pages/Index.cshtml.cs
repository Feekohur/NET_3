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

namespace NET_3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Address Address { get; set; }


        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
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

                HttpContext.Session.SetString("Ostatnio szukane", JsonConvert.SerializeObject(Address));
                //return RedirectToPage("./Address");
                return Page();
            }
            return Page();
        }


    }
}
