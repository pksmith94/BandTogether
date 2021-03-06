﻿using BandTogether.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BandTogether.MVC.Controllers
{

    [Authorize]
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            var service = CreateTeacherService();
            var teachers = service.GetAllTeachers();
            return View(teachers);
        }
        [HttpGet]
        [Route(Name = "Teacher/Followers/{id}")]
        public ActionResult Followers(string id)
        {
            var service = CreateTeacherService();

            var followers = service.GetFollowersForTeacher(id);

            return View(followers);
        }
        [HttpGet]
        [Route(Name = "Teacher/Following/{id}")]
        public ActionResult Following(string id)
        {
            var service = CreateTeacherService();

            var following = service.GetFollowingForTeacher(id);

            return View(following);
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