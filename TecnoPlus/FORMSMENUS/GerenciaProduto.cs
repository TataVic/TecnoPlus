using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class GerenciaProduto : Form
    {

        public GerenciaProduto()
        {
            InitializeComponent();
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
        }

        private void LoadProdutos()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open();

                string query = "SELECT * FROM tab_produtos";
                MySqlCommand command = new MySqlCommand(query, conexao);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                gridProduto.DataSource = dataTable;

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados!", "ERRO - CARREGAMENTO" + ex.Message);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadproduto = new CadastrarProduto(gridProduto);
            cadproduto.Show();
            LoadProdutos();
        }

        private void btnadicionarprod_Click_1(object sender, EventArgs e)
        {
            CadastrarProduto cadproduto = new CadastrarProduto(gridProduto);
            cadproduto.Show();
            LoadProdutos();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text.Trim();
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT * FROM tab_produto WHERE DESCRICAO LIKE @Produto";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@Produto", "%" + nome + "%");

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    gridProduto.DataSource = dataTable;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar os produtos!", "ERRO - PESQUISA" + ex.Message);
                }
            }
            else
            {
                LoadProdutos();
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;


            int id = Convert.ToInt32(gridProduto.SelectedRows[0].Cells["CODIGO"].Value);
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo deletar este registro?", "EXCLUSÃO", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();

                    string query = "DELETE FROM tab_produtos WHERE CODIGO LIKE @id";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@id", id);

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    gridProduto.DataSource = dataTable;

                    conexao.Close();
                    LoadProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao deletar o produto: ", "ERRO - DELETAR" + ex.Message);
                }
            }
        }
    }
}
