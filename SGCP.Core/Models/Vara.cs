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