using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VarBal.Models;
using VarBal.AdminModel;



namespace VarBal.Controllers
{

    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            HomeModel home = new HomeModel() 
            {
                Sliders=db.Slider.ToList()
            };

            return View(home);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var usercontrol = db.User.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (usercontrol != null)
            {
                FormsAuthentication.SetAuthCookie(usercontrol.Id.ToString(), false); //adım2

                ViewBag.mesaj = "Giriş Başarılı";
                return Redirect("~/Home/Booking");
            }
            else
            {
                ViewBag.mesaj = "Giriş Bilgileri Uyuşmamaktadır";
                return View();
            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Home/Login");
        }
        public ActionResult About()
        {
            return View();
        }
   
        [Authorize]
        public ActionResult Booking()
        {

            int id = Convert.ToInt32(User.Identity.Name);//cookiedeki giren kişinin Id si
            var userc = db.User.FirstOrDefault(x => x.Id == id);//user tablosunda giriş yapanı bulduk userc attık
            var adres = db.Address.FirstOrDefault(x => x.UserId == id).FullAddress;//adres tablosunda o id ye ait kişini adresini bulduk
            var zip = db.Address.FirstOrDefault(x => x.UserId == id).PostCode;
            ViewBag.adres = adres;
            ViewBag.zipcode = zip;
            
            if (userc!=null)//cookie deki Id null değilse
            {
            return View(userc);//bu kişinin bilgilerinin getir

            }
            else
            {
                return RedirectToAction("login");//değilse logine at
            }
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Facility()
        {
            return View();
        }
        public ActionResult FacilityDetail()
        {
            return View();
        }
        //public ActionResult Slider()
        //{
        //    var slider = db.Slider.Where(x => x.Status == true).ToList();

        //    return View(slider);
        //}
       
    }
}