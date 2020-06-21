using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGCP.Web.MVC.Models;
using System.Net;
using System.Text;

namespace SGCP.Core.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Dados.dados.verificaEstrutura();
            ViewBag.banco = Dados.dados.get_status();
            if (credenciado()) { return RedirectToAction("Index", "home"); }
            return View();
        }

        public IActionResult logout()
        {
            if (Login.executaLogout(Request.Cookies["token"])) { return RedirectToAction("index", "login"); }
            else { return RedirectToAction("erro", "home"); }
            
        }


        public string loga(string usuario,string senha)
        {
            string ret = "falha";
            string ip = Dns.GetHostAddresses(Dns.GetHostName())[1].MapToIPv4().ToString();
            string token = Login.executaLogin(usuario, senha, ip);
            if (token=="falha") { return ret; }
            else { return token; }
            
        }

        public bool credenciado()
        {
            //if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            string token = Request.Cookies["token"];
            string ip = Dns.GetHostAddresses(Dns.GetHostName())[1].MapToIPv4().ToString();
            if (Login.validaPasse(token, ip)) { return true; }
            else { return false; }
        }

    }
}