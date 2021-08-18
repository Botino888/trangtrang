using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Views.Home
{
    public class DanhMucController : Controller
    {
        // GET: DanhMuc
        public ActionResult Index()
        {
            return View();
        }

        // GET: DanhMuc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DanhMuc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DanhMuc/Create
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

        // GET: DanhMuc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DanhMuc/Edit/5
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

        // GET: DanhMuc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DanhMuc/Delete/5
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
