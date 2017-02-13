using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AllPointsTransport.Models;

namespace AllPointsTransport.Controllers
{
    public class WorkOrdersController : Controller
    {
        private AllPointsTransportEntities db = new AllPointsTransportEntities();

        // GET: WorkOrders
        public ActionResult Index()
        {
            return View(db.WorkOrders.ToList());
        }

        // GET: WorkOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // GET: WorkOrders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkOrderID,Completed,Status,InvoicedDate,DatePaid,Broker,BillTo,Container1,Seal,StreetTurn,EquipmentSize,Chassis,EquipmentProvider,ChassisProvider,Booking,MasterBOL,Reference,Pro,ApptNumber,Release,Weight,PieceCount,Commodity,PO,EquipmentPickup,EquipmentReturn,Origin,Destination,TypeOfMove,Duration,StorageLFD,PerDiemLFD,Cutoff,ApptTime,Container2,LocationHours,OutgateReceipt,IngateReceipt,ReadyNotification,NotesInvoice,NotesPrivate,ETA,LinkedProNum,InfoSymbol,BilledAmount,AcceptedByDispatch,RejectedByDispatch,POD1,POD2,BOL,Uploaded,DateCreated,CreatedBy,DateUpdated,UpdatedBy,WorkOrderNo")] WorkOrder workOrder)
        {
            if (ModelState.IsValid)
            {
                db.WorkOrders.Add(workOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workOrder);
        }

        // GET: WorkOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // POST: WorkOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkOrderID,Completed,Status,InvoicedDate,DatePaid,Broker,BillTo,Container1,Seal,StreetTurn,EquipmentSize,Chassis,EquipmentProvider,ChassisProvider,Booking,MasterBOL,Reference,Pro,ApptNumber,Release,Weight,PieceCount,Commodity,PO,EquipmentPickup,EquipmentReturn,Origin,Destination,TypeOfMove,Duration,StorageLFD,PerDiemLFD,Cutoff,ApptTime,Container2,LocationHours,OutgateReceipt,IngateReceipt,ReadyNotification,NotesInvoice,NotesPrivate,ETA,LinkedProNum,InfoSymbol,BilledAmount,AcceptedByDispatch,RejectedByDispatch,POD1,POD2,BOL,Uploaded,DateCreated,CreatedBy,DateUpdated,UpdatedBy,WorkOrderNo")] WorkOrder workOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workOrder);
        }

        // GET: WorkOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // POST: WorkOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkOrder workOrder = db.WorkOrders.Find(id);
            db.WorkOrders.Remove(workOrder);
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
