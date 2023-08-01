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
    public partial class GerenciarVendas : Form //form de vendas
    {
        public GerenciarVendas()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            string id = txtpesquisa.Text.Trim();
            if (!string.IsNullOrEmpty(id))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM tab_venda WHERE ID LIKE @Id";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@Nome", id);

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    gridVenda.DataSource = dataTable;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar as vendas! " + ex.Message);
                }
            }
            else
                {
                    CarregarVenda();
                }
        }
        public void CarregarVenda()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open();

                string query = "SELECT * FROM tab_venda";
                MySqlCommand command = new MySqlCommand(query, conexao);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                gridVenda.DataSource = dataTable;

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados de venda! " + ex.Message);
            }
        }

        private void btnadicionarvend_Click(object sender, EventArgs e) // adicionar - inserir
        {
           // CarregarVenda();
            FormsCadVendas cvI = new FormsCadVendas();
            cvI.ShowDialog();
            CarregarVenda();
        }

        private void GerenciarVendas_Load(object sender, EventArgs e)
        {
            CarregarVenda();
        }

        private void btneditar_Click(object sender, EventArgs e) //editar - grid
        {
            FormsCadVendas cvE = new FormsCadVendas(gridVenda); //PARAMETRO VAI SER A GRID 
            cvE.ShowDialog();
            CarregarVenda(); //CONSTRUTOR DO EDITAR 
        }
    }
 }

