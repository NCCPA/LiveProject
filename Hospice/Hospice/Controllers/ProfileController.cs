using System.Globalization;
using System.Linq;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Hospice.Models;
using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Net;

namespace Hospice.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Profile
        public ActionResult Index(string id)
        {
            //Initialize store and manager
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            //Get Current Id and Display it to the User
            var currentUserId = User.Identity.GetUserId();
            var currentUser = manager.FindById(currentUserId);

            //If Coming here as admin to view member profile
            if (id != null)
            {
                currentUser = manager.FindById(id);
            }

            return View(currentUser);
        }

        // GET: Edit
        public ActionResult Edit(string id)
        {

            //Initialize store and manager
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            //Get Current Id and Display it to the User
            var currentUserId = User.Identity.GetUserId();
            var currentUser = db.Users.Include(p => p.Roles).Where(x => x.Id == currentUserId);

            //If Coming here as admin to view member profile
            if (id != null)
            {
                ApplicationUser editUser = db.Users.Where(u => u.Id == id).SingleOrDefault();
                return View(editUser);
            }

            return View(currentUser);
        }
    }
}