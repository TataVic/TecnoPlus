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
{
    public partial class GerenciarUsuario : Form //formusuario
    {
        public GerenciarUsuario()
        {
            InitializeComponent();
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
        }

        private void btnadicionarusu_Click_1(object sender, EventArgs e)
        {
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            gridUsuario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            conexao = new MySqlConnection(strConnection);
            LoadUsuarios();
        }
        private void LoadUsuarios()
        {
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            try
            {
                conexao.Open();

                string query = "SELECT * FROM tab_usuarios";
                MySqlCommand command = new MySqlCommand(query, conexao);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                gridUsuario.DataSource = dataTable;

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados!", "ERRO" + ex.Message);
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            string nome = txtpesquisa.Text.Trim();

            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT * FROM tab_usuarios WHERE NOME_COMPLETO LIKE @nome";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    gridUsuario.DataSource = dataTable;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar os clientes!", "ERRO" + ex.Message);
                }
            }
            else
            {
                LoadUsuarios();
            }
        }


        private void btnremove_Click(object sender, EventArgs e)
        {
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            int id = Convert.ToInt32(gridUsuario.SelectedRows[0].Cells["ID"].Value);
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo deletar este registro de usuário?", "EXCLUSÃO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();

                    string query = "DELETE FROM tab_usuarios WHERE ID LIKE @id";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@id", id);

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    gridUsuario.DataSource = dataTable;

                    conexao.Close();
                    LoadUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao deletar o usuário! ", "ERRO" + ex.Message);
                }
            }


        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            GerenciarUsuario g = new GerenciarUsuario();
               g.ShowDialog();
            LoadUsuarios();
        }
    }
}
