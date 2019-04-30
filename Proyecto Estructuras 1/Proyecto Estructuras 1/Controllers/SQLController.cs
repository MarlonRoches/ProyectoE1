using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Proyecto_Estructuras_1.Models;
using Proyecto_Estructuras_1.Data;


namespace Proyecto_Estructuras_1.Controllers
{
    public class SQLController : Controller
    {
        // GET: SQL
        // Recordatorio comoner el index ayuda lab 4  -...\--
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile)
        {
           // Data.Data.Instance.Palabras_Reservadas();

           // {
                string filePath = string.Empty;
                if (postedFile != null)
                {
                    string path = Server.MapPath("~/archivo/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);
                string csvData = System.IO.File.ReadAllText(filePath);
                if (Data.Data.Instance.Ini == true)
                {

                    Data.Data.Instance.CustomSplit(filePath);
                    Data.Data.Instance.Ini = false;
                }
            }
                
                return View();
            //}

        }
    
       
        //public ActionResult pantalla1()
        //{
        //    return View();
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param coleccion de la vista ="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult pantalla1(FormCollection collection)
        {
            
            try
            {
                var operacion = collection["Texto"];
                Data.Data.Instance.split_linea(operacion);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

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
        public ActionResult ListaVehiculo()
        {
            var Pruema = new Vehiculo();
            Pruema.Id = 0;
            
            return View(Data.Data.Instance.ListaVehiculos);
        }

        // POST: SQL/Delete/5
        [HttpPost]
        public ActionResult ListaVehiculo(FormCollection collection)
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
