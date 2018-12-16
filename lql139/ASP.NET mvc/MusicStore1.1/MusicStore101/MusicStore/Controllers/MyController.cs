﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MusicStore.ViewModels;
using MusicStoreEntity;
using MusicStoreEntity.UserAndRole;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class MyController : Controller
    {
        private static readonly EntityDbContext _context = new EntityDbContext();
        // GET: My
        public ActionResult Index()
        {
            if (Session["LoginUserSessionModel"] == null)
                return RedirectToAction("login", "Account", new { returnUrl = Url.Action("Index", "My") });

            var person = (Session["LoginUserSessionModel"] as LoginUserSessionModel).Person;

            var upv = new UpdatePersonalViewModel()
            {
                Name = person.Name,
                Address = person.Address,
                MobileNumber = person.MobileNumber,
                Email=person.Email,
            };
            ViewBag.AvardaUrl = person.Avarda;
            return View(upv);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UpdatePersonalViewModel model)
        {
            var person = (Session["LoginUserSessionModel"] as LoginUserSessionModel).Person;

            var oldAvarda = person.Avarda;
            if(ModelState.IsValid)
            {
                if(model.Avarda!=null)
                {
                    var uploadDir = "~/Upload/Avarda/";
                    //取后缀名
                    var fileLastName = model.Avarda.FileName.Substring(model.Avarda.FileName.LastIndexOf(".") + 1,
                        (model.Avarda.FileName.Length - model.Avarda.FileName.LastIndexOf(".") - 1));
                    var imagePath = Path.Combine(Server.MapPath(uploadDir), person.ID + fileLastName);
                    model.Avarda.SaveAs(imagePath);
                    oldAvarda = "/Upload/Avarda/" + person+".jpg";
                }
                person.MobileNumber = model.MobileNumber;
                person.Address = model.Address;
                person.Name = model.Name;
                person.FirstName = person.Name.Substring(0, 1);
                person.LastName = person.LastName.Substring(1, person.Name.Length - 1);
                person.Avarda = oldAvarda;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AvardaUrl = oldAvarda;
            return View();
        }
    }
}