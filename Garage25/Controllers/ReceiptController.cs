using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Garage25.Models;

namespace Garage25.Controllers
{
    public class ReceiptController : Controller
    {
        // GET: Receipt
        public ActionResult Index()
        {
           

            return View();
        }
        // GET: Vehicles/Delete/5
    //    public ActionResult CheckOut(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Vehicle vehicle = db.Vehicles.Find(id);
    //        if (vehicle == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        //var query = (from r in db.Vehicles where r.Id == id select r.CheckOutTime) ;
    //        var query1 = db.Vehicles.FirstOrDefault(x => x.Id == id);
    //        if (query1 != null)
    //        {
    //            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sv-SE");
    //            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("sv-SE");
    //            Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-SE");
    //            Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");
    //            query1.CheckOutTime = DateTime.Now;
    //            var parkingDuration = query1.CheckOutTime.Subtract(query1.CheckInTime).TotalMinutes;
    //            var parkingCost = (Int32)(parkingDuration * 60);
    //            db.Vehicles.AddOrUpdate();
    //        }
    //        return View(vehicle);
    //    }
    }
}