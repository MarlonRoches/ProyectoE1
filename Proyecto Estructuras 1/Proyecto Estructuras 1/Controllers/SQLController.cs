﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Estructuras_1.Controllers
{
    public class SQLController : Controller
    {
        // GET: SQL
        public ActionResult Index()
        {

            return View();
        }

        // GET: SQL/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SQL/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SQL/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SQL/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SQL/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SQL/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SQL/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
