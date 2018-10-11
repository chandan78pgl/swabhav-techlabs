using MVCApp.Models.Color;
using MVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Index()
        {
            ColorService colorService = new ColorService();
            ColorVM colorVM = new ColorVM { Count=colorService.Count,Colors=colorService.Colors};
            return View(colorVM);
        }

        [HttpPost]
        public ActionResult Index(ColorVM vm)
        {
            ColorService colorService = new ColorService();

            vm.Count = colorService.Count;
            vm.Colors = colorService.Colors;

            return View(vm);
        }
    }
}