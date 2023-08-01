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
using TecnoPlus.FORMSMENUS;

namespace TecnoPlus
{
    public partial class GerenciarClientes : Form
    {
        public GerenciarClientes() //formscliente
        {
            InitializeComponent();
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
        }

        private void GerenciarClientes_Load(object sender, EventArgs e)
        {

            gridClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ClienteLoad();
        }
        public void ClienteLoad()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open();

                string query = "SELECT * FROM tab_cliente";
                MySqlCommand command = new MySqlCommand(query, conexao);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                gridClientes.DataSource = dataTable;

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados! ", "ERRO" + ex.Message);
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            string nome = txtpesquisa.Text.Trim();

            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT * FROM tab_cliente WHERE NOME_COMPLETO LIKE @Nome";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    gridClientes.DataSource = dataTable;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar os clientes! ", "ERRO" + ex.Message);
                }
            }
            else
            {
                ClienteLoad();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            CadastrarCliente c = new CadastrarCliente(gridClientes); //editar - parametro grid

            // Evento EdicaoConcluida
            c.CadastroConcluido += FormCadConcluido;

            // Abre o form de editar
            c.ShowDialog();
            ClienteLoad();
        }
        private void FormCadConcluido(object sender, EventArgs e)
        {
            //atualiza
            ClienteLoad();
        }

        private void btnadicionarcli_Click(object sender, EventArgs e) //adicionar
        {
                CadastrarCliente c = new CadastrarCliente();
                c.ShowDialog();
                 ClienteLoad();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            int id = Convert.ToInt32(gridClientes.SelectedRows[0].Cells["ID"].Value);
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo deletar este registro?", "EXCLUSÃO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();

                    string query = "DELETE FROM tab_cliente WHERE ID LIKE @id";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@id", id);

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    gridClientes.DataSource = dataTable;

                    conexao.Close();
                    ClienteLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao deletar o cliente!", "ERRO" + ex.Message);
                }
            }
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
