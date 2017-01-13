using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.Entity;
using System.Net;

using AceAdmin.Web.DAL;
using AceAdmin.Web.Models;

namespace AceAdmin.Web.Controllers
{
    public class WorkerController : Controller
    {
        private DBConection db = new DBConection();
        // GET: Worker
        public ActionResult Index()
        {
           // return View();
           // return View(db.Workers.ToList());
            var model = db.Workers.ToList();
            if (Request.IsAjaxRequest())
            {
                return PartialView("ViewData", model);
            }
            return View(model);
        }

        public ActionResult Loaddata()
        {
            return PartialView("ViewData", db.Workers.ToList());
        }

        //Fetch Worker from database
        private List<WorkerModel> GetWorker(int myID)
        {
            using (DBConection db = new DBConection())
            {
                return db.Workers.Where(a => a.nWorkID.Equals(myID)).ToList();
            }
        }
        //EditData Worker from database
        public JsonResult editData(int myID)
        {
            using (DBConection db = new DBConection())
            {
                return new JsonResult { Data = GetWorker(myID), JsonRequestBehavior = JsonRequestBehavior.AllowGet};
            }
        }
        //Inserdata Worker from database
       
        [HttpPost]
        public ActionResult saveData(WorkerModel workerModel)
        {
            DBConection WorkerModel = new DBConection();
            using (DBConection db = new DBConection())
            {
                WorkerModel objWorker = new WorkerModel();
                objWorker.nWorkID = workerModel.nWorkID;
                objWorker.cWorkName = workerModel.cWorkName;
                objWorker.cICnumber = workerModel.cICnumber;
                objWorker.cPhoneNum = workerModel.cPhoneNum;
                objWorker.nSalary = workerModel.nSalary;
                db.Workers.Add(objWorker);
                db.SaveChanges();
                return Json(workerModel, JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult DeleteConf(int myID)
        {
            WorkerModel workerModel = db.Workers.Find(myID);
            db.Workers.Remove(workerModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}