﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entitiy;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<Tbliletisim> repo = new GenericRepository<Tbliletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}