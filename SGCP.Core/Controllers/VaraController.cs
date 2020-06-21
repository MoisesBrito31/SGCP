using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGCP.Web.MVC.Models;

namespace SGCP.Core.Controllers
{
    public class VaraController : Controller
    {
        public ActionResult Index(string execut)
        {
            if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            ViewBag.executo = execut;
            return View(new List<vara>(Dados.dados.conjunto_vara()));
          
        }

        [HttpGet]
        public ActionResult add()
        {
            if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            return View();
        }

        [HttpPost]
        public String add(string nome,string juiz,string cidade,string estado)
        {
            if (!credenciado()) { return "não autorizado"; }
            vara va = new vara(0,nome,juiz,cidade,estado);
            Dados.dados.insert_vara(va);
           if (Dados.dados.get_status().Contains("falha")) { return Dados.dados.get_status(); }
           return "ok";
        }

        [HttpGet]
        public string delete(int id)
        {
            if (!credenciado()) { return "não autorizado"; }
            Dados.dados.delete_vara(id);
           if (Dados.dados.get_status().Contains("falha")) { return Dados.dados.get_status(); }
           return "ok";
        }

        [HttpGet]
        public ActionResult edit(int id)
        {
            if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            return View(Dados.dados.get_vara(id));
        }

        [HttpPost]
        public String edit(int id,string nome, string juiz, string cidade, string estado)
        {
            if (!credenciado()) { return "não autorizado"; }
            vara va = new vara(id,nome, juiz, cidade, estado);
            Dados.dados.update_vara(id, va);
            if (Dados.dados.get_status().Contains("falha")) { return Dados.dados.get_status(); }
            return "ok";
        }

        public bool credenciado()
        {
            //if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            //ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            string token = Request.Cookies["token"];
            string ip = Dns.GetHostAddresses(Dns.GetHostName())[1].MapToIPv4().ToString();
            if (Login.validaPasse(token, ip)) { return true; }
            else { return false; }
        }
    }
}