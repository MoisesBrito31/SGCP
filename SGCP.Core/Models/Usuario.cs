using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SGCP.Web.MVC.Models
{
    public class Usuario
    {
        public string nome { get; set; }       
        public int nivel { get; set; }
        public string senha { get; set; }
        public string usuario { get; set; }
        public string email { get; set; }
        public string chave { get; set; }
        public string passe { get; set; }
        public string ip { get; set; }
        public int id;
        public bool logado = false;
        private int[] chaveByte = new int[25];

        public Usuario()
        { }

        public Usuario(string _ip,string _passe, int nu)
        {
            passe = _passe;
            ip = _ip;
            gerarChave();
            //gerarPasse(nu);
            passe = Convert.ToString(nu);
        }

        public Usuario(string _nome, string _nick, string _senha, int _nivel,string _email)
        {
            nome = _nome;
            nivel = _nivel;
            senha = _senha;
            usuario = _nick;
            email = _email;
        }

        public Usuario(int _id, string _nome, string _nick, string _senha, int _nivel)
        {
            nome = _nome;
            nivel = _nivel;
            senha = _senha;
            usuario = _nick;
            id = _id;            
        }

        public Usuario(int _id, string _nome, string _nick, string _senha, int _nivel, string _email)
        {
            nome = _nome;
            nivel = _nivel;
            senha = _senha;
            usuario = _nick;
            id = _id;
            email = _email;
        }

        public Usuario (int _id, string _nome, string _nick, string _senha, int _nivel,string _email, string _chave, string _passe, string _ip)
        {
            nome = _nome;
            nivel = _nivel;
            senha = _senha;
            usuario = _nick;
            id = _id;
            email = _email;
            chave = _chave;
            passe = _passe;
            ip = _ip;
        }

        public void Login()
        {
            logado = true;
        }
        public void LogOff()
        {
            logado = false;
        }

        public void gerarChave()
        {
            string r = "";
            int vAnterior = 0;
            int index = 0;
            while (r.Length < 25)
            {
                Random ram = new Random();
                byte[] dado = new byte[1];
                int var = ram.Next(40, 126);
                dado[0] = Convert.ToByte(var);
                if (((var > 47 && var < 58) || (var > 64 && var < 91) || (var > 96 && var < 103)) &&  vAnterior != var )
                {
                    r = string.Format("{0}{1}", r, Encoding.UTF8.GetString(dado));
                    chaveByte[index] = var;
                    index++;
                }
                vAnterior = var;
            }

            chave = r;            
        }

        internal int[] get_chaveByte()
        {
            return chaveByte;
        }

        public void gerarPasse(int cont)
        {
            string r = Convert.ToString(cont);
            int vAnterior = 0;
            int index = 0;
            while (r.Length < 5)
            {
                Random ram = new Random();
                byte[] dado = new byte[1];
                int var = ram.Next(40, 122);
                dado[0] = Convert.ToByte(var);
                if (((var > 47 && var < 58) || (var > 64 && var < 91) || (var > 96 && var < 103)) && vAnterior != var)
                {
                    r = string.Format("{0}{1}", r, Encoding.UTF8.GetString(dado));
                    chaveByte[index] = var;
                    index++;
                }
                vAnterior = var;
            }

            passe = r;            
        }



    }
}