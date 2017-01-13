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
    public class JobsController : Controller
    {
        private DBConection db = new DBConection();
        // GET: Jobs
        public ActionResult Index()
        {
            //ViewBag.WorkersList = new SelectList(db.Workers, "nWorkID", "cWorkName");
            // puth in view : @Html.DropDownList("WorkersList") 
            var jobModel = db.Jobs.ToList();
            if (Request.IsAjaxRequest())
            {
                return PartialView("ViewData", jobModel);
            }
            return View(jobModel);

            //ViewBag.VBMobileList = new SelectList(db.Workers, "nWorkID", "cWorkName");
            //var query = db.Workers.Select(c => new { c.nWorkID, c.cWorkName });
            //ViewBag.WorkersList = new SelectList(query.AsEnumerable(), "CategoryID", "CategoryName", 3);

           // return View();
        }

        // GET: Jobs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Loaddata()
        {
            return PartialView("VData", db.Jobs.ToList());
        }
        // GET: Jobs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jobs/Create
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

        // GET: Jobs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jobs/Edit/5
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
        public ActionResult saveData(JobsModel jobsModel)
        {
            DBConection JobsModel = new DBConection();
            using (DBConection db = new DBConection())
            {
                
                JobsModel objJobs = new JobsModel();
                objJobs.cJobNum = jobsModel.cJobNum;
                objJobs.nWorkID = jobsModel.nWorkID;
                objJobs.cDuration = jobsModel.cDuration;
                objJobs.clocation = jobsModel.clocation;
                db.Jobs.Add(objJobs);
                db.SaveChanges();
                return Json(jobsModel, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
