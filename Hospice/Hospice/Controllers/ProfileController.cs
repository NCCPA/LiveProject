using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Hospice.Models;
using System;

namespace Hospice.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Profile
        public ActionResult Index()
        {
            

            //Find User by to get information for profile
            string currentUserId = User.Identity.GetUserId();
            var currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);


            ViewData["FirstName"] = currentUser.FName;
            ViewData["LastName"] = currentUser.LName;
            ViewData["Phone"] = currentUser.PhoneNumber;
            ViewData["DOB"] = currentUser.DOB.Value.ToShortDateString();

            return View();
        }
    }
}