using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("hello world");
        }
    }

    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("this is the About controllers index action");
        }

        public IActionResult History()
        {
            return Content("this is the About controllers History action");

        }

        public IActionResult Location()
        {
            return Content("this is the About controllers Location action");
        }
       
    }

    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("this is the Books controller index action");
        }

        public IActionResult New()
        {
            return Content("this is the Books controller new action");
        }
    }

     public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("this is the authors controller index action");
        }

        public IActionResult Featured()
        {
            return Content("this is the Authors controller featured action");
        }
    }

    public class OfferingsController : Controller
    {
        [Route("Products")]
        [Route("Products/Index")]

        public IActionResult Products()
        {
            return Content("This is the products page.");

        }

        [Route("Services")]
        [Route("Services/Index")]

        public IActionResult Services()
        {
            return Content("this is the products page.");

        }
    }

}