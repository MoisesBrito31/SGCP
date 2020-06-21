using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGCP.Web.MVC.Models
{
    public static class Dados
    {
        public static BancoDados dados = new BancoDados("mysql5014.site4now.net", "db_a635d2_sgcp", "a635d2_sgcp", "betim516",0);
        //public static BancoDados dados = new BancoDados("localhost", "db_SGCP", "root", "betim516", 1);
    }
}