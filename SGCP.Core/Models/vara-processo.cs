using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGCP.Web.MVC.Models
{
    public class vara_processo
    {
        public List<vara> varas { get; set; }
        public List<processo> processos { get; set; }

        public vara_processo(List<vara> vara, List<processo> pro)
        {
            varas = vara;
            processos = pro;
        }

        public string getVara(int id)
        {
            string retorno = "indefinido";
            for(int x=0;x<varas.Count;x++)
            {
                if (varas[x].id == id) { retorno = varas[x].get_nome(); }
            }
            return retorno;
        }
    }
}