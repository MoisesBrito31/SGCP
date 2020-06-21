using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGCP.Web.MVC.Models;

namespace SGCP.Core.Controllers
{
    public class usuariosController : Controller
    {
        public ActionResult Index(string execut)
        {
            if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            ViewBag.executo = execut;
            return View(new List<Usuario>(Dados.dados.conjuntoUsuarios()));
        }

        [HttpGet]
        public ActionResult add()
        {
            if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            return View();
        }

        [HttpPost]
        public String add(Usuario use)
        {
            if (!credenciado()) { return "Acesso Negado por credenciais não reconhecidas"; }
            Dados.dados.insertusuario(use);

            if (Dados.dados.get_status().Contains("falha")) { return Dados.dados.get_status(); }
            return "ok";
        }

        [HttpGet]
        public string delete(int id)
        {
            if (!credenciado()) { return Dados.dados.get_status(); }
            Dados.dados.deleteUsuario(id);
            if (Dados.dados.get_status().Contains("falha")) { return Dados.dados.get_status(); }
            return "ok";
        }

        [HttpGet]
        public ActionResult edit(int id)
        {
            if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            return View(Dados.dados.GetUsuarioById(id));
        }

        [HttpPost]
        public String edit(int id,Usuario use)
        {
            if (!credenciado()) { return "não autorizado"; }
            Dados.dados.updateUsuario(id, use);
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