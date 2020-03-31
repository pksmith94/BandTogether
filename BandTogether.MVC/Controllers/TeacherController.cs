﻿using BandTogether.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BandTogether.MVC.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route(Name = "Teacher/Detail/{id}")]
        public ActionResult Detail(string id)
        {
            var service = CreateTeacherService();
            var model = service.GetTeacherById(id);
            return View(model);
        }
        private TeacherService CreateTeacherService()
        {
            var userId = this.User.Identity.GetUserId();
            return new TeacherService(userId);
        }
    }
}