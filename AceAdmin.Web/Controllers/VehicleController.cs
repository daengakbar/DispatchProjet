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
    public class VehicleController : Controller
    {
        private DBConection db = new DBConection();
        // GET: Vehicle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Loaddata()
        {
            return PartialView("VData", db.Vehicles.ToList());
        }

        // GET: Vehicle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult saveData(VehicleModel vehicleModel)
        {
            DBConection VehicleModel = new DBConection();
            using (DBConection db = new DBConection())
            {
                VehicleModel objVehicle = new VehicleModel();
                objVehicle.nVehiID = vehicleModel.nVehiID;
                objVehicle.cLicensePNum = vehicleModel.cLicensePNum;
                objVehicle.cType = vehicleModel.cType;
                objVehicle.cStaAdd = vehicleModel.cStaAdd;
                objVehicle.cEndAdd = vehicleModel.cEndAdd;
                objVehicle.cDriver = vehicleModel.cDriver;
                db.Vehicles.Add(objVehicle);
                db.SaveChanges();
                return Json(vehicleModel, JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult DeleteConf(int myID)
        {
            VehicleModel vehicleModel = db.Vehicles.Find(myID);
            db.Vehicles.Remove(vehicleModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
