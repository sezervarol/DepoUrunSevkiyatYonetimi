using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VarBal.Models;
using VarBal.AdminModel;
using System.Web.Security;
using System.Net.Mail;
using System.Net;
using System.IO;



namespace VarBal.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sidebar()
        {
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Home/Login");
        }

        #region eski slider
        //[HttpGet]
        //public ActionResult SliderInsert()
        //{
        //    Slider slider = new Slider();

        //    return View(slider);
        //}

        //[HttpPost]
        //public ActionResult SliderInsert(HttpPostedFileBase Image, string Title, string Description, string Link, bool State)
        //{
        //    Slider slider = new Slider();
        //    //HttpPostedFileBase// nedir bak

        //    string resimyolu = "";
        //    string resimad = "";

        //    try
        //    {
        //        if (Image != null && Image.ContentLength > 0)
        //        {
        //            resimad = Guid.NewGuid().ToString() + "-" + Path.GetFileName(Image.FileName); // benzersiz bir ıd vercek

        //            resimyolu = Path.Combine(Server.MapPath("~/Content/img/slider"), resimad);

        //            Image.SaveAs(resimyolu);
        //            slider.Image = resimad;

        //        }

        //    }
        //    catch
        //    {

        //    }

        //    slider.Title = Title;
        //    slider.Description = Description;
        //    slider.Link = Link;
        //    slider.Status = State;

        //    db.Slider.Add(slider);
        //    db.SaveChanges();

        //    return Redirect("~/Home/Index");
        //}

        //[HttpGet]

        //public ActionResult SliderEdit(int Id)
        //{
        //    var slider = db.Slider.Find(Id);

        //    return View(slider);
        //    //power bi :))
        //}
        //[HttpPost]
        //public ActionResult SliderEdit(HttpPostedFileBase Image, Slider slider)
        //{
        //    var slaydeır1 = db.Slider.Find(slider.Id);

        //    slaydeır1.Title = slider.Title;
        //    slaydeır1.Description = slider.Description;
        //    slaydeır1.Link = slider.Link;
        //    slaydeır1.Status = slider.Status;

        //    string resimyolu = "";
        //    string resimad = "";

        //    try
        //    {
        //        if (Image != null && Image.ContentLength > 0)
        //        {
        //            resimad = Guid.NewGuid().ToString() + "-" + Path.GetFileName(Image.FileName); // benzersiz bir ıd vercek

        //            resimyolu = Path.Combine(Server.MapPath("~/Content/img/slider"), resimad);

        //            Image.SaveAs(resimyolu);
        //            slaydeır1.Image = resimad;

        //        }

        //    }
        //    catch { }


        //    db.SaveChanges();

        //    //return View(slaydeır1);
        //    return RedirectToAction("Index"); /*aynı yerde kalmasın slidera donsun*/
        //}
        //[HttpGet]
        //public ActionResult SliderDelete(int id)
        //{

        //    var deleteslider = db.Slider.Find(id);


        //    deleteslider.Status = false;
        //    deleteslider.Delete = true;

        //    db.SaveChanges();

        //    return Redirect("~/Home/Index");

        //}

        #endregion

    }
}