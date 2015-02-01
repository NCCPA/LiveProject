using Hospice.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Hospice.Controllers
{
    public class FilesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Files
        public ActionResult Index()
        {
            var fileList = from f in db.Files
                           select new FileViewModel
                           {
                               ID = f.ID,
                               FileName = f.FileName,
                               MimeType = f.MimeType,
                               FileDescription = f.FileDescription
                           };
            return View(fileList.ToList());
        }
        // POST: Home/Delete/5
        [HttpPost, ActionName("Index")]
        public ActionResult IndexUpload(string fileDescription)
        {
            string mimeType = Request.Files[0].ContentType;
            string fileName = Path.GetFileName(Request.Files[0].FileName);
            int fileLength = Request.Files[0].ContentLength;
            if (!(fileName == "" || fileLength == 0))//Looks like we have a file!!!
            {
                Stream fileStream = Request.Files[0].InputStream;
                byte[] fileData = new byte[fileLength];
                fileStream.Read(fileData, 0, fileLength);

                Hospice.Models.File newFile = new Hospice.Models.File
                {
                    FileContent = fileData,
                    MimeType = mimeType,
                    FileName = fileName,
                    FileDescription = fileDescription
                };

                db.Files.Add(newFile);
                db.SaveChanges();
            }

            return RedirectToAction("Index");

        }
        public FileContentResult Download(int id)
        {
            var theFile = db.Files.Where(f => f.ID == id).SingleOrDefault();
            return File(theFile.FileContent, theFile.MimeType, theFile.FileName);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileViewModel filetoDelete = (from f in db.Files
                                               where f.ID == id
                                               select new FileViewModel
                                               {
                                                   ID = f.ID,
                                                   FileName = f.FileName,
                                                   MimeType = f.MimeType,
                                                   FileDescription = f.FileDescription
                                               }).SingleOrDefault();
            if (filetoDelete == null)
            {
                return HttpNotFound();
            }
            return View(filetoDelete);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hospice.Models.File fileStore = db.Files.Find(id);
            db.Files.Remove(fileStore);
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