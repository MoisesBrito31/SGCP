using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGCP.Core.Models;
using SGCP.Web.MVC.Models;

namespace SGCP.Core.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            return View();
        }

        public bool credenciado()
        {
            //if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            string token = Request.Cookies["token"];
            string ip = Dns.GetHostAddresses(Dns.GetHostName())[1].MapToIPv4().ToString();
           if(Login.validaPasse(token, ip)) { return true; }
            else { return false; }
        }

    }
}
