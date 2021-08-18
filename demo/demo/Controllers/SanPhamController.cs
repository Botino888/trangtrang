using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using demo.Models.ModelsView;
using demo.Models.repos;

namespace demo.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult Index()
        {
            var SPV = new SanPhamRepository();
            var Model = SPV.GetSanPham();
            return View(Model);
        }

        public ActionResult Sua(string id)
        {
            var SP = new SanPhamRepository();
            var model = SP.SpEdit(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Sua(SanPhamViewEdit Sp)
        {
            var SP = new SanPhamRepository();
            if (SP.SuaSP(Sp))
                return RedirectToAction("Index");
            else return View();
        }
        public ActionResult Delete(string id)
        {
            var SP = new SanPhamRepository();
            if (SP.DeleteSp(id)) return RedirectToAction("Index");
            return View("Index");
        }
        // GET: SanPham/Edit

        // GET: SanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SanPham/Create
        public ActionResult Create()
        {
            var SP = new DanhMucRepository();
            return View(SP.DMofSP().ToList());
        }

        // POST: SanPham/Create
        [HttpPost]
        public ActionResult Create(SanPhamViewEdit SpAdd)
        {
            var DM = new DanhMucRepository();
            try
            {
                var SP = new SanPhamRepository();
                if ( SP.AddSp(SpAdd))
                    return RedirectToAction("Index");
                else
                {
                    if(SpAdd.MaSP==null) ModelState.AddModelError("MaSP", "Bạn chưa nhập mã sản phẩm!");
                    return View(DM.DMofSP().ToList());
                }     
            }
            catch
            {
                return View(DM.DMofSP().ToList());
            }
        }

        public ActionResult Search(string Search)
        {
            var SPV = new SanPhamRepository();
            var Model = SPV.GetSanPham().Where(x=> x.TenSP.Contains(Search)).ToList();
            return View("Index",Model);
        }
        // GET: SanPham/Edit/5
         public ActionResult Edit(int id)
        {
            return View();
        }
        
        // POST: SanPham/Edit/5
        
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
        [HttpPost]
        public JsonResult addRowSP(string MaSP)
        {
            var result = new SanPhamRepository().addRowSP(MaSP);
            return Json(new
            {
                status = result
            });
        }
        // GET: SanPham/Delete/5
        /*public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SanPham/Delete/5
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
        }*/
    }
}
