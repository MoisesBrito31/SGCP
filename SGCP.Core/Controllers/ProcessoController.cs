using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGCP.Web.MVC.Models;

namespace SGCP.Core.Controllers
{
    public class ProcessoController : Controller
    {
        public ActionResult Index(string execut)
        {
            if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            ViewBag.tabela = processoToJSon(Dados.dados.conjunto_processo());
            ViewBag.executo = execut;
            vara_processo dado = new vara_processo(Dados.dados.conjunto_vara(), Dados.dados.conjunto_processo());
            return View(dado);
        }

        [HttpGet]
        public ActionResult add()
        {
            if (!credenciado()) { return RedirectToAction("Index", "Login"); }
            ViewBag.nome = Login.getUsuarioByToken(Request.Cookies["token"]).nome;
            return View(Dados.dados.conjunto_vara());
        }

        [HttpPost]
        public String add(int _vara,string _numero, DateTime _intimacao,string _reqd,string _reqt,string _obs)
        {
            processo pro = new processo();
            try
            {
                pro = new processo(_vara, _numero, "", _intimacao, _reqd, _reqt);
                pro.obs = _obs;
            }
            catch(Exception ex) { return ex.Message; }
            if (!credenciado()) { return "não autorizado"; }
            Dados.dados.insert_processo(pro);
            if (Dados.dados.get_status().Contains("falha")) { return Dados.dados.get_status(); }
            return "ok";
        }

        [HttpGet]
        public string delete(int id)
        {
            if (!credenciado()) { return "não autorizado"; }
            Dados.dados.delete_processo(id);
            if (Dados.dados.get_status().Contains("falha")) { return Dados.dados.get_status(); }
            return "ok";
        }

        [HttpGet]
        public ActionResult edit(int id)
        {
             ViewBag.varas = Dados.dados.conjunto_vara();
             List<processo> process = Dados.dados.conjunto_processo();
             processo proc = Dados.dados.get_processo(id);
             return View(proc);
        }

        [HttpPost]
        public String edit(int _id,int _vara, string _numero,  DateTime _intimacao, string _reqd, string _reqt, string _obs,
            string _ini_tra, string _Hpro, string _Hapro, string _entrega)
        {
            if (!credenciado()) { return "não autorizado"; }
            processo usu = new processo();
            try
            {
                usu = new processo(_id, _vara, _numero, "", _intimacao, _reqd, _reqt);
                usu.obs = _obs;
                usu.inicio_trabalho = _ini_tra;
                usu.honorario = _Hapro;
                usu.honorario_pro = _Hpro;
                usu.entrega = _entrega;
            }
            catch { return "falha, Dados Incompletos"; }

             Dados.dados.update_processo(usu.id, usu);

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
        private string processoToJSon(List<processo> lista)
        {
            string r = "[";

            for (int x = 0; x < lista.Count; x++)
            {
                if (x == lista.Count - 1) { r = r + "{" + string.Format("\"id\":{3},\"vara\":{0},\"numero\":\"{1}\",\"situacao\":\"{2}\"", lista[x].vara.ToString(), lista[x].numero, lista[x].situacao, lista[x].id) + "}]"; }
                else { r = r + "{" + string.Format("\"id\":{3},\"vara\":{0},\"numero\":\"{1}\",\"situacao\":\"{2}\"", lista[x].vara.ToString(), lista[x].numero, lista[x].situacao, lista[x].id) + "},"; }
            }
            return r;
        }
    }
}