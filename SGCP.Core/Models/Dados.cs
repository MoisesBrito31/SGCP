using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGCP.Web.MVC.Models
{
    public static class Dados
    {
        //public static BancoDados dados = new BancoDados("mysql5022.site4now.net", "db_a4e14b_sgcp", "a4e14b_sgcp", "Betim516",0);
        public static BancoDados dados = new BancoDados("localhost", "db_SGCP", "root", "betim516", 1);
    }
}