using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5._0.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbar()
        {
            return PartialView();
        }
         [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

    }
}
