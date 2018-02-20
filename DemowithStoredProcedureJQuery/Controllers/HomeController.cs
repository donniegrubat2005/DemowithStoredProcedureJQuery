using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DemowithStoredProcedureJQuery.Models;

namespace DemowithStoredProcedureJQuery.Controllers
{
    public class HomeController : Controller
    {
        private Table1Context dbemp = new Table1Context();

        public ActionResult Index()
        {
            //List<selectsp_Result> list = dbemp.selectsp().ToList();
            return View(dbemp.selectsp().ToList());        
               
        }

        public ActionResult Create()
        {
            
            return View();
           
        }

        [HttpPost]
        public ActionResult Create(Table_1 tbl1)
        {
            try { 
            dbemp.Table_1.Add(tbl1);
            dbemp.SaveChanges();
                //return RedirectToAction("Index");
                return Json(new { success = true},JsonRequestBehavior.AllowGet);
            }
            catch
            {
             return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var query = dbemp.Table_1.Where(x => x.EmployeeNumber == id).SingleOrDefault();
            return View(query);
        }

        [HttpPost]
        public ActionResult Edit(int id, Table_1 tbl1)
        {
            dbemp.Entry(tbl1).State = EntityState.Modified;
            dbemp.SaveChanges();
            //return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try { 
            Table_1 employee = dbemp.Table_1.Where(x => x.EmployeeNumber == id).SingleOrDefault();
                dbemp.Table_1.Remove(employee);
                dbemp.SaveChanges();
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            } catch
            {
                return View();
            }
          
        }
    }
}