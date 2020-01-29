using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SGCP.Web.MVC.Models;

using Microsoft.AspNetCore.Authentication;
using Nancy.Authentication.Forms;
using System.Security.Claims;

namespace SGCP.Core.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Dados.dados.verificaEstrutura();
            ViewBag.banco = Dados.dados.get_status();
            return View();
        }


        public string loga(string usuario,string senha)
        {
            var grandmaClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,"moises"),
                new Claim(ClaimTypes.Email,"moises@email"),
            };
            return "ok";
        }
       
    }
}