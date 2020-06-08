using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly ShoeService shoeService;

        public SearchController(ShoeService shoeService)
        {
            this.shoeService = shoeService;
        }

        public IActionResult Index(string query)
        {
            var shoes = shoeService.GetAllByQuery(query);

            return View(shoes);
        }
    }
}