﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paup_2023.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi
        public ActionResult Index()
        {
            ViewBag.Lokacija = "Međimursko Veleučilište u Čakovcu";
            return View();
        }

        public ActionResult Druga()
        {
            ViewBag.Ustanova = "Međimursko Veleučilište";
            ViewData["Lokacija"] = "Čakovec";
            return View();
        }

        public ActionResult Treca(string poruka, int broj=1)
        {
            ViewBag.Poruka = poruka;
            ViewBag.Broj = broj;
            return View();
        }

        public ActionResult Student()
        {
            ViewBag.Ime = "Florijan";
            ViewBag.Prezime = "Kos";
            ViewBag.GodinaRodenja = "2002";
            return View();
        }
    }
}