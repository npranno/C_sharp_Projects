﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsuranceAssignment.Models;

namespace CarInsuranceAssignment.Controllers
{
    public class InsureeController : Controller
    {
        private CarInsuranceEntities db = new CarInsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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

        //public ActionResult Admin()
        //{
        //    List<Insuree> listInsuree = new List<Insuree>();
        //    foreach (var insuree in db.Insurees.ToList())
        //    {
        //        Insuree theInsured = new Insuree();
        //        theInsured.FirstName = insuree.FirstName;
        //        theInsured.LastName = insuree.LastName;
        //        theInsured.EmailAddress = insuree.EmailAddress;
        //        theInsured.Quote = insuree.Quote;

        //        listInsuree.Add(theInsured);
        //    }

        //    return View(listInsuree);
        //}

        private double quoteLogic(Insuree insuree)
        {
            double quote = 50;
            int age = new DateTime(DateTime.Now.Subtract(Convert.ToDateTime(insuree.DateOfBirth)).Ticks).Year - 1;

            if (age < 18)
            {
                quote += 100;
            }
            else if (age > 18 && age < 25)
            {
                quote += 50;
            }
            else if (age > 25)
            {
                quote += 25;
            }

            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                quote += 25;
            }

            if (insuree.CarMake == "Porsche")
            {
                quote += 25;
            }

            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                quote += 25;
            }

            quote += Convert.ToInt32(insuree.SpeedingTickets) * 10;

            if (Convert.ToBoolean(insuree.DUI))
            {
                quote += quote * .25;
            }

            if (Convert.ToBoolean(insuree.CovrageType))
            {
                quote += quote * .5;
            }

            return quote;
        }
    }
}

