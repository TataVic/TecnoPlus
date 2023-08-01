using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TecnoPlus
{
    static class cadusuarios
    {
        public static int _idUsuario= 0;
        public static string _usuariologado = null;
        public static string _nomeUsuarioLogado = null;
        public static string _tipoUsuario = null;

        public static string _idVendedor;
        private static string nome;

        public static bool Login(string nome, string senha)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open();


                string query = "SELECT * FROM tab_usuarios WHERE usuario = '" + nome + "'";
                MySqlCommand command = new MySqlCommand(query, conexao);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string nomeUsuario = reader.GetString("usuario");
                    string nomecompleto = reader.GetString("nome_completo");
                    string senhaUsuario = reader.GetString("senha");
                    string type = reader.GetString("tipo_usuario");
                    bool status = reader.GetBoolean("situacao");


                    if (nomeUsuario == nome && senhaUsuario == senha)
                    {
                        if (status)
                        {
                            _usuariologado = nomeUsuario;
                            _nomeUsuarioLogado = nomecompleto;
                            _tipoUsuario = type;
                            _idUsuario = id;

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("O usuário informado não possui acesso ao sistema!", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Dados dos campos incorretos", "VERIFICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        reader.Close();
                        conexao.Close();
                        return false;
                    }
                }

                if (!reader.Read())
                {
                    MessageBox.Show("Dados dos campos incorretos", "VERIFICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                reader.Close();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: ", "CONEXÃO" + ex.Message);
            }

            return false;
        }

        public static string IDUser(int id)
        {
  
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();


                string query = "SELECT * FROM tab_usuarios Where id = " + id;
                MySqlCommand command = new MySqlCommand(query, conexao);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nome = reader.GetString("NOME_COMPLETO");
                    if (nome != String.Empty)
                    {
                        return nome;

                    }

                }
            }
            catch 
            {

            }
            return nome;
        }
    }
}
