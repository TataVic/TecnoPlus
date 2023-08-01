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
    public partial class Relatorio : Form
    {
       //private string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
       // private MySqlConnection conexao;

        public Relatorio()
        {
            InitializeComponent();
        }

        private void LoadVendas()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            try
            {
                conexao.Open();

                string query = "SELECT *  FROM tab_venda";
                MySqlCommand command = new MySqlCommand(query, conexao);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                decimal valorTotal = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    decimal valorVenda = Convert.ToDecimal(row["VALOR_TOTAL"]);
                    valorTotal += valorVenda;
                }

                VLTotal.Text = valorTotal.ToString();
                QtdTotal.Text = dataTable.Rows.Count.ToString();

                grid_vendas.DataSource = dataTable;

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados: " + ex.Message);
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string DtInicial = datainicial.Text;
            string DtFinal = datafinal.Text;
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            try
            {
                conexao.Open();

                string query = "SELECT * FROM tab_venda WHERE DATE(DATA_VENDA) BETWEEN DATE(@wDtInicial) AND DATE(@wDtFinal)";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@wDtInicial", DateTime.Parse(DtInicial));
                command.Parameters.AddWithValue("@wDtFinal", DateTime.Parse(DtFinal));

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                decimal valorTotal = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    decimal valorVenda = Convert.ToDecimal(row["VALOR_TOTAL"]);
                    valorTotal += valorVenda;
                }

                VLTotal.Text = valorTotal.ToString();
                QtdTotal.Text = dataTable.Rows.Count.ToString();

                grid_vendas.DataSource = dataTable;



                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar as vendas: " + ex.Message);
            }
        }

       

        private void Relatorio_Load(object sender, EventArgs e)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            grid_vendas.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Bold);

            grid_vendas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            LoadVendas();
        }

        private void btn_mais_vendidos_Click(object sender, EventArgs e)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            try
            {
                string DtInicial = datainicial.Text;
                string DtFinal = datafinal.Text;
                conexao.Open();

                string query = "SELECT tab_produtos.DESCRICAO, SUM(tab_items_venda.QUANTIDADE) FROM tab_produtos INNER JOIN tab_items_venda ON (tab_items_venda.CODIGO_PRODUTO = tab_produtos.CODIGO) INNER JOIN tab_venda ON (tab_venda.ID = tab_items_venda.CODIGO_VENDA) WHERE DATE(tab_venda.DATA_VENDA)  BETWEEN DATE(@wDtInicial) AND DATE(@wDtFinal) GROUP BY 1 ORDER BY 2 DESC LIMIT 10";
                MySqlCommand command = new MySqlCommand(query, conexao);

                command.Parameters.AddWithValue("@wDtInicial", DateTime.Parse(DtInicial));
                command.Parameters.AddWithValue("@wDtFinal", DateTime.Parse(DtFinal));

                DataTable dataTable1 = new DataTable();
                MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(command);
                dataAdapter1.Fill(dataTable1);


                grid_vendas.DataSource = dataTable1;

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados: " + ex.Message);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }
    }
}
