﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AceAdmin.Web.Controllers
{
    public class OtherPagesController : BaseController
    {
        // GET: OtherPage
        public ActionResult Blank()
        {
            return View();
        }

        public ActionResult Error404()
        {
            return View();
        }

        public ActionResult Error500()
        {
            return View();
        }

        public ActionResult Grid()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}