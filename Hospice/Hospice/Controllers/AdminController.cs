using Hospice.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospice.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //GET: MemberList
        public ActionResult MemberList()
        {

            //Initialize store and manager
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            //Get Current Id and Display it to the User
            var currentUserId = User.Identity.GetUserId();
            var Users = manager.Users;


            return View(Users.ToList());
        }
    }
}