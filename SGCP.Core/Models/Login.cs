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
        public static List<Usuario> users = new List<Usuario>();
        

        public static bool executaLogin(string passe,string cript)
        {
            users = Dados.dados.conjuntoUsuarios();
            int index = -1;
            try
            {
                for (int x = 0; x < usuarios.Count; x++)
                {
                    if (passe == usuarios[x].passe)
                    {
                        index = x;
                    }
                }
            }
            catch { }
            if (index == -1) { return false; }

            string str = DesCript(cript, usuarios[index]);           
            int var = 0;
            
            for(int x=0;x<str.Length;x++)
            {
                if(str.Substring(x,1)==" ")
                {
                    var = x;
                }
            }
            string uid = str.Substring(0, var);
            string password = str.Substring(var+1, str.Length-(var+1));
            string status = Dados.dados.get_status();

            if (users.Count > 0)
            {
                for (int x = 0; x < users.Count; x++)
                {
                    if (users[x].usuario == uid && users[x].senha == password)
                    {
                        usuarios[index].nome = users[x].nome;
                        usuarios[index].email = users[x].email;
                        usuarios[index].id = users[x].id;                       
                        usuarios[index].logado = true;
                        return true;
                    }
                }
            }
            else
            {
                if(uid=="moises" && password=="1234" )
                {
                    usuarios[index].nome = "Moises Fuentes";
                    usuarios[index].email = "moises@e-servicerio.com";
                    usuarios[index].logado = true;
                    return true;
                }
            }

            return false;
            
        }

        public static int UsuarioLogado(string _ip,string _passe)
        {
            int retorno = -1;
            try
            {
                for (int x = 0; x < usuarios.Count; x++)
                {
                    if (_passe == usuarios[x].passe)
                    {
                        if (_ip == usuarios[x].ip && usuarios[x].logado) { return x; }
                    }
                }
            }
            catch { }
            return retorno;
        }

        public static bool executaLogout(string passe)
        {
            int index = -1;
            try
            {
                for (int x = 0; x < usuarios.Count; x++)
                {
                    if (passe == usuarios[x].passe)
                    {
                        index = x;
                    }
                }
            }
            catch { }
            if (index == -1) { return false; }
            usuarios[index].LogOff();
            return true;
        }

        public static bool validaPasse(string _passe)
        {
            try
            {
                for (int x = 0; x < usuarios.Count; x++)
                {
                    if (_passe == usuarios[x].passe){ return true; }                    
                }
            }
            catch { }
            return false;
        }

        public static void novoPasse(Usuario usuario)
        {
            try
            {
                
                for (int x = 0; x < usuarios.Count; x++)
                {
                    if (usuarios[x].passe==null) { usuarios.RemoveAt(x); }
                    else if (usuario.passe == usuarios[x].passe)
                    {
                        usuarios.RemoveAt(x);
                    }
                }
            }
            catch { }
            
            usuarios.Add(usuario);
            cadastros++;
        }

        private static string DesCript(string cript, Usuario user)
        {            
            string[] buffer_str = cript.Split(',');
            int[] buffer_int = new int[buffer_str.Length];
            for (int y = 0; y < buffer_int.Length; y++) { buffer_int[y] = Convert.ToInt16(buffer_str[y]); }
            byte[] buffer_byte = new byte[buffer_str.Length];
            int[] chave_int = user.get_chaveByte();
            for (int x = 0; x < buffer_byte.Length; x++) buffer_byte[x] = Convert.ToByte(buffer_int[x] - chave_int[x]);
            System.Console.WriteLine();
            System.Console.WriteLine("recebido post: " + Encoding.UTF8.GetString(buffer_byte));
            System.Console.WriteLine();
            return Encoding.UTF8.GetString(buffer_byte);
            
        }

        public static bool credenciado(string _ip, string _passe)
        {
            if (_passe == null) { _passe = ""; }
            
            try
            {
                for (int x = 0; x < usuarios.Count; x++)
                {
                    if (_passe == usuarios[x].passe)
                    {
                        { return true; }
                    }
                }
            }
            catch { }
            return false;
        }

        
    }
}