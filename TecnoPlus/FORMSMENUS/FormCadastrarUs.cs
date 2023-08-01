using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnoPlus
{ //formusuario
    public partial class FormCadastrarUs : Form
    {
        int codigo;
        string maneira;
        string nomeCompleto;
        string usuario;
        string senha;
        string tipo;
        bool situacao;

        
        public FormCadastrarUs()
        {
            InitializeComponent();
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
        }
        public FormCadastrarUs(DataGridView gridUsuario)
        {
            InitializeComponent();
            maneira = "editar";
            txtNomeCompleto.Text = gridUsuario.SelectedRows[0].Cells["NOME_COMPLETO"].Value.ToString();
            txtUsuario.Text = gridUsuario.SelectedRows[0].Cells["USUARIO"].Value.ToString();
            txtSenha.Text = gridUsuario.SelectedRows[0].Cells["SENHA"].Value.ToString();
            ckativo.Checked = Convert.ToBoolean(gridUsuario.SelectedRows[0].Cells["SITUACAO"].Value);
            string tipo = gridUsuario.SelectedRows[0].Cells["TIPO_USUARIO"].Value.ToString();
            if (tipo == "ADMIN")
            {
                admin.Checked = true;
            }
            else if (tipo == "NORMAL")
            {
                normal.Checked = true;
            }
            codigo = Convert.ToInt32(gridUsuario.SelectedRows[0].Cells["ID"].Value);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            nomeCompleto = txtNomeCompleto.Text;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            tipo = ObterTipo();
            situacao = ckativo.Checked;

            if (maneira == "inserir")
            {
                InserirUsu();
            }
            else if (maneira == "editar")
            {
                EditarUsu();
            }
            FecharForm();
        }

        private void InserirUsu()
        {
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            string sql = "INSERT INTO tab_usuarios(NOME_COMPLETO, USUARIO, SENHA, SITUACAO, TIPO_USUARIO)" +
                                          "VALUES(@NOME_COMPLETO, @USUARIO, @SENHA, @SITUACAO, @TIPO_USUARIO)";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@NOME_COMPLETO", nomeCompleto);
                comando.Parameters.AddWithValue("@USUARIO", usuario);
                comando.Parameters.AddWithValue("@SENHA", senha);
                comando.Parameters.AddWithValue("@SITUACAO", situacao);
                comando.Parameters.AddWithValue("@TIPO_USUARIO", tipo);

                conexao.Open();
                try
                {
                    int i = comando.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro incluído com sucesso!", "EXCLUIR USUÁRIO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
        private void EditarUsu()
        {
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            string sql = "UPDATE tab_usuarios SET NOME_COMPLETO = @NOME_COMPLETO, USUARIO = @USUARIO, SENHA = @SENHA, SITUACAO = @SITUACAO, TIPO_USUARIO = @TIPO_USUARIO WHERE ID LIKE @ID";

  
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@NOME_COMPLETO", nomeCompleto);
            comando.Parameters.AddWithValue("@USUARIO", usuario);
            comando.Parameters.AddWithValue("@SENHA", senha);
            comando.Parameters.AddWithValue("@SITUACAO", situacao);
            comando.Parameters.AddWithValue("@TIPO_USUARIO", tipo);
            comando.Parameters.AddWithValue("@ID", codigo);

            conexao.Open();

            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro atualizado com sucesso!", "EDITAR USUÁRIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
        private string ObterTipo()
        {
            if (admin.Checked)
            {
                return "ADMIN";
            }
            else if (normal.Checked)
            {
                return "NORMAL";
            }
            else { return string.Empty; }

        }

        public event EventHandler CadastroConcluido;
        private void FecharForm()
        {
            if (CadastroConcluido != null)
            {
                CadastroConcluido(this, EventArgs.Empty);
            }
            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
