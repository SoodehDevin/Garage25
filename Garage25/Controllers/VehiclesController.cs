﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage25.DataAccessLayer;
using Garage25.Models;
using System.Globalization;
using System.Threading;

namespace Garage25.Controllers
{
    public class VehiclesController : Controller
    {
        private VehiclesContext db = new VehiclesContext();



        // GET: Vehicles
        public ActionResult Index(Vehicle model, string reg)
        {
            if (reg == null)
            {
                var vehicles = db.Vehicles.Include(v => v.Member).Include(v => v.VehicleType);
                return View(vehicles.ToList());
            }
            var query = from r in db.Vehicles.Include(v => v.Member).Include(v => v.VehicleType) where r.RegNr == reg select r;
            return View(query);

        }
       

        // GET: Vehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }
  
        // GET: Vehicles/Create
        //public ActionResult Park()
        //{
        //    return View();
        //}
        public ActionResult Park()
        {
            ViewBag.MemberId = new SelectList(db.Members, "Id", "Id");
            ViewBag.VehicleTypeId = new SelectList(db.VehicleType, "Id", "Name");
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Park([Bind(Include = "Id,MemberId,VehicleTypeId,RegNr,Color,Make,VName,CheckInTime,CheckOutTime")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                //setting time to swedish locale
                
                CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sv-SE");
                CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("sv-SE");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-SE");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");
                //            DateTime.ParseExact("12/02/21 10:56:09", "yy/MM/dd HH:mm:ss",
                //CultureInfo.InvariantCulture
                //).ToString("MMM. dd, yyyy HH:mm:ss")

                vehicle.RegNr = vehicle.RegNr.ToUpper();
                vehicle.CheckInTime = DateTime.Now;
                vehicle.CheckOutTime = DateTime.Now;
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", vehicle.MemberId);
            ViewBag.VehicleTypeId = new SelectList(db.VehicleType, "Id", "Name", vehicle.VehicleTypeId);
            return View(vehicle);
        }
        //public ActionResult Create([Bind(Include = "Id,MemberId,VehicleTypeId,RegNr,Color,Make,VName,CheckInTime,CheckOutTime")] Vehicle vehicle)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Vehicles.Add(vehicle);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", vehicle.MemberId);
        //    ViewBag.VehicleTypeId = new SelectList(db.VehicleType, "Id", "Name", vehicle.VehicleTypeId);
        //    return View(vehicle);
        //}

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", vehicle.MemberId);
            ViewBag.VehicleTypeId = new SelectList(db.VehicleType, "Id", "Name", vehicle.VehicleTypeId);
            return View(vehicle);
        }
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Vehicle vehicle = db.Vehicles.Find(id);
        //    if (vehicle == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", vehicle.MemberId);
        //    ViewBag.VehicleTypeId = new SelectList(db.VehicleType, "Id", "Name", vehicle.VehicleTypeId);
        //    return View(vehicle);
        //}

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MemberId,VehicleTypeId,RegNr,Color,Make,VName,CheckInTime,CheckOutTime")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sv-SE");
                CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("sv-SE");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-SE");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");
                vehicle.RegNr = vehicle.RegNr.ToUpper();
                var V = db.Vehicles.AsNoTracking().First(x => x.Id == vehicle.Id);
                vehicle.MemberId = V.MemberId;
                vehicle.CheckInTime = V.CheckInTime;
                vehicle.CheckOutTime = V.CheckOutTime;
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", vehicle.MemberId);
            ViewBag.VehicleTypeId = new SelectList(db.VehicleType, "Id", "Name", vehicle.VehicleTypeId);
            return View(vehicle);
        }
        //public ActionResult Edit([Bind(Include = "Id,MemberId,VehicleTypeId,RegNr,Color,Make,VName,CheckInTime,CheckOutTime")] Vehicle vehicle)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(vehicle).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", vehicle.MemberId);
        //    ViewBag.VehicleTypeId = new SelectList(db.VehicleType, "Id", "Name", vehicle.VehicleTypeId);
        //    return View(vehicle);
        //}

        // GET: Vehicles/Delete/5
        public ActionResult CheckOut(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            //var query = (from r in db.Vehicles where r.Id == id select r.CheckOutTime) ;
            var query1 = db.Vehicles.FirstOrDefault(x => x.Id == id);
            if (query1 != null)
            {
                CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sv-SE");
                CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("sv-SE");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-SE");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");
                query1.CheckOutTime = DateTime.Now;
                query1.ParkingDuration = query1.CheckOutTime.Subtract(query1.CheckInTime).TotalMinutes;
                query1.ParkingCost = (Int32)(query1.ParkingDuration * 60);
                db.Vehicles.AddOrUpdate();
            }
            return View(vehicle);
        }




        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("CheckOut")]
        [ValidateAntiForgeryToken]
        public ActionResult CheckOutConfirmed(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);


            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
