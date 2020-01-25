using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace SGCP.Web.MVC.Models
{
    public class BancoDados
    {
        private string status = "falha";
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnectionStringBuilder conectionstring;
        private MySqlConnection conector;
        private MySqlSslMode ssl;


        public BancoDados(string _server, string _database, string _usu, string _senha, int _ssl)
        {
            server = _server;
            database = _database;
            uid = _usu;
            password = _senha;
            switch (_ssl)
            {
                case 0:
                    ssl = MySqlSslMode.None;
                    break;
                case 1:
                    ssl = MySqlSslMode.Required;
                    break;
                case 2:
                    ssl = MySqlSslMode.VerifyCA;
                    break;
                case 3:
                    ssl = MySqlSslMode.VerifyFull;
                    break;
                default:
                    ssl = MySqlSslMode.None;
                    break;
            }
            conectionstring = new MySqlConnectionStringBuilder();
            conectionstring.Server = server;
            conectionstring.Database = database;
            conectionstring.UserID = uid;
            conectionstring.Password = password;
            conectionstring.SslMode = ssl;

            conector = new MySqlConnection(conectionstring.ConnectionString);
            string funcao = string.Format("use {0};", database);
            MySqlCommand comando = new MySqlCommand(funcao, conector);


            try
            {
                conector.Open();
                comando.ExecuteNonQuery();
                status = "conectado";
                conector.Close();
            }
            catch (Exception ex)
            {
                status = "falha de conexão\r\n" + ex.Message;
            }


        }

        public bool verificaEstrutura()
        {
            string funcao = "select * from tb_usuario;";

            MySqlConnection conector = new MySqlConnection(conectionstring.ConnectionString);
            MySqlCommand comando = new MySqlCommand(funcao, conector);

            try
            {
                conector.Open();
                MySqlDataReader data = comando.ExecuteReader();
                data.Read();
                string ab = data.GetString(1);
                conector.Close();
                status = "conectado";
                return true;
            }
            catch (Exception ex)
            {
                status = ex.Message;
                return false;
            }

        }

        public void estruturar()
        {
            MySqlConnection conec = new MySqlConnection(conectionstring.ConnectionString);
            string funcao = "create table tb_usuario(" +
            "id int not null auto_increment," +
            "nome varchar(20) not null," +
            "usuario varchar(20) not null," +
            "senha varchar(20) not null," +
            "nivel int default 0," +
            "email varchar(40) not null unique," +            
            "primary key(id)" +
            ");" +
            "insert into tb_usuario" +
            "('moises', 'moises', '1234',1,'moises.eservicerio@gmail.com')" +
            "values" +
            "('moises', 'moises', '1234', 1);\r\n" +
            "create table tb_vara(" +
            "id int not null auto_increment," +
            "nome varchar(20) not null," +
            "primary key(id)" +
            ");\r\n" +
            "create table tb_processo(" +
            "id int not null auto_increment," +
            "vara int not null," +
            "numero varchar(20) not null unique," +
            "juiz varchar(20) not null," +
            "intimacao varchar(10) not null," +
            "inicio_trabalhos varchar(10)," +
            "entrega varchar(10)," +
            "requerente varchar(20) not null," +
            "requerido varchar(20) not null," +
            "honorario_pro varchar(20)," +
            "honorario varchar(20)," +
            "situacao varchar(30)," +
            "obs varchar(100)," +
            "primary key(id)" +
            ");\r\n";

            MySqlCommand comando = new MySqlCommand(funcao, conec);

            try
            {
                conec.Open();
                comando.ExecuteNonQuery();
                status = "conectado";
                conec.Close();

            }
            catch (Exception ex)
            {
                status = "falha de estrutura\r\n" + ex.Message;
            }
        }

        public bool login(string us, string senha)
        {

            string funcao = string.Format("select * from tb_usuario where usuario='{0}' and senha='{1}';", us, senha);

            MySqlConnection conector = new MySqlConnection(conectionstring.ConnectionString);
            MySqlCommand comando = new MySqlCommand(funcao, conector);

            try
            {
                conector.Open();
                MySqlDataReader data = comando.ExecuteReader();
                data.Read();
                string ab = data.GetString(1);
                conector.Close();
                return true;
            }
            catch (Exception ex)
            { return false; }


        }

        public Usuario GetUsuario(string us, string senha)
        {
            Usuario retorno = new Usuario();

            string funcao = string.Format("select * from tb_usuario where usuario='{0}' and senha='{1}';", us, senha);

            MySqlConnection conector = new MySqlConnection(conectionstring.ConnectionString);
            MySqlCommand comando = new MySqlCommand(funcao, conector);

            try
            {
                conector.Open();
                MySqlDataReader data = comando.ExecuteReader();
                while (data.Read())
                {
                    string id = data.GetString(0);
                    string a = data.GetString(1);
                    string b = data.GetString(2);
                    string c = data.GetString(3);
                    string d = data.GetString(4);
                    retorno = new Usuario(Convert.ToInt16(id), a, b, c, Convert.ToInt16(d));
                }
                conector.Close();

            }
            catch (Exception ex)
            {
                status = "falha ao gravar\r\n" + ex.Message;                
            }

            return retorno;
        }

        public Usuario GetUsuarioById(int _id)
        {
            Usuario retorno = new Usuario();

            string funcao = string.Format("select * from tb_usuario where id='{0}';", _id);

            MySqlConnection conector = new MySqlConnection(conectionstring.ConnectionString);
            MySqlCommand comando = new MySqlCommand(funcao, conector);

            try
            {
                conector.Open();
                MySqlDataReader data = comando.ExecuteReader();
                while (data.Read())
                {
                    string id = data.GetString(0);
                    string a = data.GetString(1);
                    string b = data.GetString(2);
                    string c = data.GetString(3);
                    string d = data.GetString(4);
                    string e = data.GetString(5);
                    retorno = new Usuario(Convert.ToInt16(id), a, b, c, Convert.ToInt16(d),e);
                }
                conector.Close();

            }
            catch (Exception ex)
            {
                status = "falha ao gravar\r\n" + ex.Message;                
            }

            return retorno;
        }

        public string get_status()
        {
            return status;
        }

        public bool insertusuario(Usuario log)
        {
            string func = string.Format("insert into tb_usuario (nome,usuario,senha,nivel,email) values('{0}','{1}','{2}',{3},'{4}')", log.nome, log.usuario, log.senha, log.nivel,log.email);
            MySqlConnection conec = new MySqlConnection(conectionstring.ConnectionString);
            MySqlCommand comando = new MySqlCommand(func, conec);

            try
            {
                conec.Open();
                comando.ExecuteNonQuery();
                conec.Close();
                return true;
            }
            catch (Exception ex)
            {
                status = "falha ao gravar\r\n" + ex.Message;
                return false;
            }
        }

        public bool updateUsuario(int id, Usuario logNovo)
        {
            string func = string.Format("update tb_usuario SET `nome`='{0}',`usuario`='{1}',`senha`='{2}',`nivel`={3} " +
                "where `id`={4};", logNovo.nome, logNovo.usuario, logNovo.senha,
                Convert.ToString(logNovo.nivel), id);

            MySqlCommand comando = new MySqlCommand(func, conector);

            try
            {
                conector.Open();
                comando.ExecuteNonQuery();
                conector.Close();
                status = "OK";
                return true;
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "falha ao alterar\r\n" + ex.Message;
                return false;
            }
        }

        public bool deleteUsuario(int id)
        {
            string func = string.Format("delete from tb_usuario where `id`={0};", id);
            MySqlCommand comando = new MySqlCommand(func, conector);
            try
            {
                conector.Open();
                comando.ExecuteNonQuery();
                conector.Close();
                status = "OK";
                return true;
            }
            catch (Exception ex)
            {
                status = "falha ao deletar\r\n" + ex.Message;
                return false;
            }
        }

        public List<Usuario> conjuntoUsuarios()
        {
            List<Usuario> conjunto = new List<Usuario>();
            string func = "select * from tb_usuario;";
            MySqlCommand comando = new MySqlCommand(func, conector);

            try
            {
                conector.Open();
                MySqlDataReader data = comando.ExecuteReader();
                while (data.Read())
                {
                    string id = data.GetString(0);
                    string a = data.GetString(1);
                    string b = data.GetString(2);
                    string c = data.GetString(3);
                    string d = data.GetString(4);
                    conjunto.Add(new Usuario(Convert.ToInt16(id), a, b, c, Convert.ToInt16(d)));
                }
                conector.Close();
                status = "ok";
            }
            catch (Exception ex)
            {
                status = "erro ao ler\r\n" + ex.Message;
            }
            return conjunto;

        }

        #region controle tb_vara
        public vara get_vara(int _id)
        {
            vara retorno = new vara();
            string func = string.Format("select * from tb_vara where `id`={0};", _id);
            MySqlCommand comando = new MySqlCommand(func, conector);

            try
            {
                conector.Open();
                MySqlDataReader data = comando.ExecuteReader();
                while (data.Read())
                {
                    string id = data.GetString(0);
                    string a = data.GetString(1);

                    retorno = new vara(Convert.ToInt16(id), a);

                }
                conector.Close();
                status = "ok";
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "erro ao ler\r\n" + ex.Message;
            }
            return retorno;

        }
        public bool insert_vara(vara vara)
        {
            string func = string.Format("insert into tb_vara (nome) values('{0}');", vara.get_nome());
            MySqlConnection conec = new MySqlConnection(conectionstring.ConnectionString);
            MySqlCommand comando = new MySqlCommand(func, conec);

            try
            {
                conec.Open();
                comando.ExecuteNonQuery();
                conec.Close();
                return true;
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "falha ao gravar\r\n" + ex.Message;
                return false;
            }
        }
        public bool delete_vara(int id)
        {
            string func = string.Format("delete from tb_vara where `id`={0};", id);
            MySqlCommand comando = new MySqlCommand(func, conector);
            try
            {
                conector.Open();
                comando.ExecuteNonQuery();
                conector.Close();
                status = "OK";
                return true;
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "falha ao deletar\r\n" + ex.Message;
                return false;
            }
        }
        public bool update_vara(int id, vara vara)
        {
            string func = string.Format("update tb_vara SET `nome`='{0}' " +
               "where `id`={1};", vara.get_nome(), id);

            MySqlCommand comando = new MySqlCommand(func, conector);

            try
            {
                conector.Open();
                comando.ExecuteNonQuery();
                conector.Close();
                status = "OK";
                return true;
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "falha ao alterar\r\n" + ex.Message;
                return false;
            }
        }
        public List<vara> conjunto_vara()
        {
            List<vara> conjunto = new List<vara>();
            string func = "select * from tb_vara;";
            MySqlCommand comando = new MySqlCommand(func, conector);

            try
            {
                conector.Open();
                MySqlDataReader data = comando.ExecuteReader();
                while (data.Read())
                {
                    string id = data.GetString(0);
                    string a = data.GetString(1);

                    conjunto.Add(new vara(Convert.ToInt16(id), a));

                }
                conector.Close();
                status = "ok";
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "erro ao ler\r\n" + ex.Message;
            }
            return conjunto;

        }
        #endregion

        #region controle tb_processo
        public processo get_processo(int _id)
        {
            processo conjunto = new processo();
            string func = string.Format("select * from tb_processo where `id`={0};", _id);
            MySqlCommand comando = new MySqlCommand(func, conector);

            try
            {
                conector.Open();
                MySqlDataReader data = comando.ExecuteReader();
                while (data.Read())
                {
                    string id = data.GetString(0);
                    string a = data.GetString(1);
                    string b = data.GetString(2);
                    string c = data.GetString(3);
                    string d = data.GetString(4);
                    string e = data.GetString(5);
                    string f = data.GetString(6);
                    string g = data.GetString(7);
                    string h = data.GetString(8);
                    string i = data.GetString(9);
                    string j = data.GetString(10);
                    string k = data.GetString(11);
                    string l = data.GetString(12);

                    conjunto = new processo(Convert.ToInt16(id), Convert.ToInt16(a), b, c, Convert.ToDateTime(d), e, f, g, h, i, j, k, l);
                    
                }
                conector.Close();
                status = "ok";
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "erro ao ler\r\n" + ex.Message;
            }
            return conjunto;
        }
        public bool insert_processo(processo proce)
        {
            string func = string.Format("insert into tb_processo (vara,numero,juiz,intimacao,inicio_trabalhos,entrega,requerente,requerido," +
                "honorario_pro,honorario,situacao,obs) " +
                "values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}');"
                , proce.vara, proce.numero, proce.juiz, proce.intimacao.Date.ToShortDateString(), proce.inicio_trabalho, proce.entrega,
                proce.requerente, proce.requerido, proce.honorario_pro, proce.honorario, proce.situacao, proce.obs);

            MySqlConnection conec = new MySqlConnection(conectionstring.ConnectionString);
            MySqlCommand comando = new MySqlCommand(func, conec);

            try
            {
                conec.Open();
                comando.ExecuteNonQuery();
                conec.Close();
                return true;
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "falha ao gravar\r\n" + ex.Message;
                return false;
            }
        }
        public bool delete_processo(int id)
        {
            string func = string.Format("delete from tb_processo where `id`={0};", id);
            MySqlCommand comando = new MySqlCommand(func, conector);
            try
            {
                conector.Open();
                comando.ExecuteNonQuery();
                conector.Close();
                status = "OK";
                return true;
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "falha ao deletar\r\n" + ex.Message;
                return false;
            }
        }
        public bool update_processo(int id, processo proce)
        {
            string func = string.Format("update tb_processo SET `vara`={0},`numero`='{1}',`juiz`='{2}',`intimacao`='{3}',`inicio_trabalhos`='{4}',`entrega`='{5}'" +
                ",`requerente`='{6}',`requerido`='{7}',`honorario_pro`='{8}',`honorario`='{9}',`situacao`='{10}',`obs`='{11}' " +
                "where `id`={12};", Convert.ToString(proce.vara), proce.numero, proce.juiz, proce.intimacao.Date.ToShortDateString(), proce.inicio_trabalho,
                proce.entrega, proce.requerente, proce.requerido, proce.honorario_pro, proce.honorario, proce.situacao, proce.obs, id);

            MySqlCommand comando = new MySqlCommand(func, conector);

            try
            {
                conector.Open();
                comando.ExecuteNonQuery();
                conector.Close();
                status = "OK";
                return true;
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "falha ao alterar\r\n" + ex.Message;
                return false;
            }
        }
        public List<processo> conjunto_processo()
        {
            List<processo> conjunto = new List<processo>();
            string func = "select * from tb_processo;";
            MySqlCommand comando = new MySqlCommand(func, conector);

            try
            {
                conector.Open();
                MySqlDataReader data = comando.ExecuteReader();
                while (data.Read())
                {
                    string id = data.GetString(0);
                    string a = data.GetString(1);
                    string b = data.GetString(2);
                    string c = data.GetString(3);
                    string d = data.GetString(4);
                    string e = data.GetString(5);
                    string f = data.GetString(6);
                    string g = data.GetString(7);
                    string h = data.GetString(8);
                    string i = data.GetString(9);
                    string j = data.GetString(10);
                    string k = data.GetString(11);
                    string l = data.GetString(12);

                    conjunto.Add(new processo(Convert.ToInt16(id), Convert.ToInt16(a), b, c, Convert.ToDateTime(d), e, f, g, h, i, j, k, l));
                }
                conector.Close();
                status = "ok";
            }
            catch (Exception ex)
            {
                conector.Close();
                status = "erro ao ler\r\n" + ex.Message;
            }
            return conjunto;
        }
        #endregion

        public string getEndereco()
        { return server; }
        public string getDatabase()
        { return database; }
        public string getUID()
        { return uid; }
        public string getSenha()
        { return password; }
        public int getSSL()
        {
            if (ssl == MySqlSslMode.None)
            {
                return 0;
            }
            else if (ssl == MySqlSslMode.Required)
            {
                return 1;
            }
            else if (ssl == MySqlSslMode.VerifyCA)
            { return 2; }
            else
            {
                return 3;
            }
        }
    }
}