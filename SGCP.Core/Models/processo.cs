using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGCP.Web.MVC.Models
{
    public class processo
    {
        //atributos//
        public int id;
        public int vara;
        public vara ObVara { get; set; }
        public string numero;
        public string juiz;
        public DateTime intimacao;
        public string inicio_trabalho;
        public string entrega;
        public string requerente;
        public string requerido;
        public string honorario_pro;
        public string honorario;
        public string situacao;
        public string obs;

        //construtores
        public processo() { }
        public processo(int _id, int _vara, string _numero, string _juiz, DateTime _intimacao, string _reqd, string _reqt)
        {
            id = _id;
            vara = _vara;
            numero = _numero;
            juiz = _juiz;
            intimacao = _intimacao;
            requerente = _reqt;
            requerido = _reqd;
            situacao = "Criado";
        }
        public processo(int _vara, string _numero, string _juiz, DateTime _intimacao, string _reqd, string _reqt)
        {
            id = 0;
            vara = _vara;
            numero = _numero;
            juiz = _juiz;
            intimacao = _intimacao;
            requerente = _reqt;
            requerido = _reqd;
            situacao = "Criado";
        }
        public processo(int _id, int _vara, string _numero, string _juiz, DateTime _intimacao, string _inic_trab, string _entrega, string _reqd, string _reqt,
            string _honor_pro, string _honor, string _situacao, string _obs)
        {
            id = _id;
            vara = _vara;
            numero = _numero;
            juiz = _juiz;
            intimacao = _intimacao;
            inicio_trabalho = _inic_trab;
            entrega = _entrega;
            requerente = _reqt;
            requerido = _reqd;
            honorario_pro = _honor_pro;
            honorario = _honor;
            situacao = _situacao;
            obs = _obs;
        }


    }
}