using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IShoeRepository shoeRepository;

        public SearchController(IShoeRepository shoeRepository)
        {
            this.shoeRepository = shoeRepository;
        }

        public IActionResult Index(string query)
        {
            var shoes = shoeRepository.GetAllByTitle(query);

            return View(shoes);
        }
    }
}