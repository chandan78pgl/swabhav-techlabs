﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingMVCApp.Controllers
{
    public class PassbookController : Controller
    {
        // GET: Passbook
        public ActionResult Index()
        {
            return View();
        }
    }
}