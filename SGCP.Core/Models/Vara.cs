using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGCP.Web.MVC.Models
{
    public class vara
    {

        //atributos//
        public int id;
        private string nome;
        public string juiz { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }

        //construtores//
        public vara()
        {
            id = 0;
            nome = "";
        }

        public vara(string _nome)
        {
            nome = _nome;
            id = 0;
        }

        public vara(int _id, string _nome)
        {
            id = _id;
            nome = _nome;
        }

        public vara(int _id, string _nome,string _juiz, string _cidade, string _estado)
        {
            id = _id;
            nome = _nome;
            cidade = _cidade;
            estado = _estado;
            juiz = _juiz;
                
        }

        //controle de atributos//
        public int get_id()
        {
            return id;
        }
        public string get_nome()
        {
            return nome;
        }
        public void set_id(int valor)
        {
            id = valor;
        }
        public void set_nome(string valor)
        {
            nome = valor;
        }


    }
}