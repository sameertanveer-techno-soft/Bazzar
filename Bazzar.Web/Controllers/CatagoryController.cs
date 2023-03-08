﻿using Bazzar.Entities;
using Bazzar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bazzar.Web.Controllers
{
    public class CatagoryController : Controller
    {
        CatagoriesService catagoriesService = new CatagoriesService();

        // GET: Catagory
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public  ActionResult Create(Catagory catagory)
        {
            catagoriesService.SaveCatagory(catagory);
            return View();
        }
    }
}