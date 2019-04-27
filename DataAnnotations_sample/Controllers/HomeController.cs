using DataAnnotations_sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotations_sample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Index(User model) 
        {   
            // Her zaman Client side ve Server side Validation olmak üzere çift taraflı mutlaka Validation kontrolu yapmalısın.

            // ModelState.IsValid ile Server Validation yapamayı unutma user yoksa Source inspect ile güvenlik açığı olusur.

            if(model.user_name!="alican")  // "alican"  dışında bir username girildiğinde ekrana uyarı basacak 
            {
                // Database den kullanıcı adı kullanılıyor mu kontrolü yaptıgımızı varsayalım. // if(model.user_name.StartsWith("alican")) gibi metodlarla kullanıcı adı sununda baslasın sununla bitsin gibi şeyleride kontrol edebiliriz.
                ModelState.AddModelError("", "I do not like your name!");
            }

            return View(model);
        }
    }
}



