using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SGCP.Web.MVC.Models
{
    public static class Login
    {
        public static List<Usuario> usuarios = new List<Usuario>();
        public static int cadastros = 0;

        public static string executaLogin(string _email,string _senha, string _ip)
        {
            string ret = "falha";
            if(Dados.dados.get_status()== "falha") { return ret; }
            if (Dados.dados.loginByEmail(_email, _senha))
            {
                Usuario novo = Dados.dados.GetUsuarioByEmail(_email, _senha);
                novo.gerarChave();
                novo.ip = _ip;
                usuarios.Add(novo);
                return novo.chave;
            }

            return ret;
            
        }

        public static bool executaLogout(string chave)
        {
            int index = -1;
            try
            {
                for (int x = 0; x < usuarios.Count; x++)
                {
                    if (chave == usuarios[x].chave)
                    {
                        index = x;
                    }
                }
            }
            catch { }
            if (index == -1) { return false; }
            usuarios.RemoveAt(index);
            return true;
        }

        public static bool validaPasse(string _chave, string _ip)
        {
            try
            {
                for (int x = 0; x < usuarios.Count; x++)
                {
                    if (_chave == usuarios[x].chave){ 
                        if (usuarios[x].ip == _ip)
                        {
                            return true;
                        }
                         
                    }                    
                }
            }
            catch { }
            return false;
        }

        public static Usuario getUsuarioByToken(string _chave)
        {
            Usuario ret = new Usuario();
            for (int x = 0; x < usuarios.Count; x++)
            {
                if (usuarios[x].chave == _chave) { ret = usuarios[x]; }
            }
            return ret;
        }

        
    }
}