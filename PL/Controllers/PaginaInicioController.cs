﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class PaginaInicioController : Controller
    {
        // GET: PaginaInicio
        public ActionResult Index()
        {
            
            return View();
        }

 
    }
}