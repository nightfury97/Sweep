using SweepCake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweepCake.Controllers
{
    public class DelController : Controller
    {
        // GET: Del
        IList<banh> banhList = new List<banh>() {
                    new banh(){ ID=1, Name="socola", Price = 18 },
                    new banh(){ ID=2, Name="vani", Price = 21 },
                    new banh(){ ID=3, Name="kem", Price = 25 },
                    new banh(){ ID=4, Name="caramen", Price = 20 },
                    new banh(){ ID=5, Name="tiramisu", Price = 31 },
                    new banh(){ ID=6, Name="mặn", Price = 17 },
                    new banh(){ ID=7, Name="su kem", Price = 19 }
                };
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult danhsach()
        {
            return View("danhsach",banhList);
        }
        public ActionResult Add()
        {
            return View("Add");
        }
        [HttpPost]
        public ActionResult Add(banh st)
        {
            banhList.Insert(banhList.Count,st);
            
            return View("danhsach", banhList);
        }
        
        public ActionResult Edit(int ID)
        {
            var st = banhList.Where(s => s.ID == ID).FirstOrDefault();
            return View(st);
        }
        [HttpPost]
        public ActionResult Edit(banh st)
        {
            var name = st.Name;
            var gia = st.Price;
            foreach(banh e in banhList)
            {
                if (e.ID == st.ID)
                {
                    e.Name = name;
                    e.Price = gia;
                }
            }
            return View("danhsach", banhList);
            
            //return RedirectToAction("danhsach");
        }
        public ActionResult Xoa(int ID)
        {
            var st = banhList.Where(s => s.ID == ID).FirstOrDefault();
            return View(st);
        }
        [HttpPost]
        
        public ActionResult Xoa(banh st)
        {
            var itemToRemove = banhList.Single(r => r.ID ==st.ID);
            banhList.Remove(itemToRemove);
            return View("danhsach", banhList);
           // return RedirectToAction("danhsach",banhList);
        }
        public ActionResult ChiTiet(int ID)
        {
            var st = banhList.Where(s => s.ID == ID).FirstOrDefault();
            return View(st);
        }
    }
}