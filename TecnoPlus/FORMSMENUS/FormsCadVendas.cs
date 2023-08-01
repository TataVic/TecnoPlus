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
    public partial class FormsCadVendas : Form   //formrelvenda
    {
        string maneira;
      //  int codigo;
        //CLIENTE
        public int id_cliente;
        public string nome= "";
        //PRODUTO
        public int id_prod;
        public string descricao;
        public double preco;
        public int qtd_estoque;
        //USUARIO
        public int user;

        //VENDA
        DateTime dataVenda;
        int codigoCliente;
        int codigoUsuario;
        double totalItens;
        decimal subtotal;
        decimal desconto;
        decimal valorTotal;
        string formaPagamento;
        string situacao;
        public int IdVenda;

        public FormsCadVendas() //inserir
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            InitializeComponent();
            maneira = "inserir";
        }
        public FormsCadVendas(DataGridView gridItemVenda) //editar
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            InitializeComponent();
            maneira = "editar";

            txt_datavenda.Text = gridItemVenda.SelectedRows[0].Cells["DATA_VENDA"].Value.ToString();

            id_cliente = Convert.ToInt32(gridItemVenda.SelectedRows[0].Cells["ID_CLIENTE"].Value);
           //txtcliente.Text = nome(id_cliente);

            user = Convert.ToInt32(gridItemVenda.SelectedRows[0].Cells["ID_USUARIO"].Value);
            // txtvendedor.Text = CadastroUsuarios.UserId(user);

            txttotalitems.Text = gridItemVenda.SelectedRows[0].Cells["TOTAL_ITENS"].Value.ToString();
            txtsubtotal.Text = gridItemVenda.SelectedRows[0].Cells["SUBTOTAL"].Value.ToString();
            txtdesconto.Text = gridItemVenda.SelectedRows[0].Cells["DESCONTO"].Value.ToString();
            lblTotal.Text = gridItemVenda.SelectedRows[0].Cells["VALOR_TOTAL"].Value.ToString();
            cmbFormaPag.SelectedItem = gridItemVenda.SelectedRows[0].Cells["FORMA_PAGAMENTO"].Value.ToString();
            cmbsituacao.SelectedItem = gridItemVenda.SelectedRows[0].Cells["SITUACAO"].Value.ToString();
            txt_cod_barras.Text = Convert.ToString(gridItemVenda.SelectedRows[0].Cells["ID"].Value);
        }

        private string nome_cliente(int id)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open();


                string query = "SELECT * FROM clientes Where id = " + id;
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
            catch (Exception ex)
            {
                MessageBox.Show("Errooooo:" + ex);
            }
            return nome;
        }

        public void CarregarItems()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            try
            {
                conexao.Open();

                string query = "SELECT * FROM tab_items_vendas WHERE CODIGO_VENDA = @Nome";
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.AddWithValue("@Nome", Convert.ToInt32(txt_cod_barras.Text));
                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

               gridItemVenda.DataSource = dataTable;

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados: " + ex.Message);
            }
        }
        private void Forms_Vendas_Load(object sender, EventArgs e)
        {
            if (maneira == "inserir")
            {
                txtvendedor.Text = cadusuarios._usuariologado;
                CadastrarVendas();
            }
        }
        private void InserirItemVenda()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            int codigoVenda = Convert.ToInt32(txt_cod_barras.Text);
            int codigoProduto = Convert.ToInt32(id_prod);
            int quantidade = Convert.ToInt32(txtQtd.Text);
            decimal valorUnitario = Convert.ToDecimal(txtpreco.Text);

            // Inseri o item na tabela tab_items_vendas
            string sqlItemVenda = "INSERT INTO tab_items_vendas (CODIGO_VENDA, CODIGO_PRODUTO, QUANTIDADE, VALOR_UNITARIO) " +
                                  "VALUES (@CodigoVenda, @CodigoProduto, @Quantidade, @ValorUnitario)";

            // Atualizar a quantidade do produto na tabela tab_produtos
            string sqlAtualizarProduto = "UPDATE tab_produtos SET QUANTIDADE_ESTOQUE = QUANTIDADE_ESTOQUE - @Quantidade WHERE CODIGO = @CodigoProduto";

            MySqlCommand comandoItemVenda = new MySqlCommand(sqlItemVenda, conexao);
            MySqlCommand comandoAtualizarProduto = new MySqlCommand(sqlAtualizarProduto, conexao);

            comandoItemVenda.Parameters.AddWithValue("@CodigoVenda", codigoVenda);
            comandoItemVenda.Parameters.AddWithValue("@CodigoProduto", codigoProduto);
            comandoItemVenda.Parameters.AddWithValue("@Quantidade", quantidade);
            comandoItemVenda.Parameters.AddWithValue("@ValorUnitario", valorUnitario);

            comandoAtualizarProduto.Parameters.AddWithValue("@Quantidade", quantidade);
            comandoAtualizarProduto.Parameters.AddWithValue("@CodigoProduto", codigoProduto);

            conexao.Open();

            try
            {
                // Inserir o item na tabela ITEM_VENDA
                int rowsAffectedItemVenda = comandoItemVenda.ExecuteNonQuery();

                // Atualizar a quantidade do produto na tabela PRODUTO
                int rowsAffectedAtualizarProduto = comandoAtualizarProduto.ExecuteNonQuery();

                if (rowsAffectedItemVenda > 0 && rowsAffectedAtualizarProduto > 0)
                {
                    CarregarItems();
                }
               
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
        private void CadastrarVendas()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            string sql = "INSERT INTO tab_venda (DATA_VENDA, ID_CLIENTE, ID_USUARIO, TOTAL_ITENS, SUBTOTAL, DESCONTO, VALOR_TOTAL, FORMA_PAGAMENTO, SITUACAO) " +
                         "VALUES (@DataVenda, @IdCliente, @IdUsuario, @TotalItens, @Subtotal, @Desconto, @ValorTotal, @FormaPagamento, @Situacao)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@DataVenda", dataVenda);
            comando.Parameters.AddWithValue("@IdCliente", id_cliente);
            comando.Parameters.AddWithValue("@IdUsuario", user);
            comando.Parameters.AddWithValue("@TotalItens", totalItens);
            comando.Parameters.AddWithValue("@Subtotal", subtotal);
            comando.Parameters.AddWithValue("@Desconto", desconto);
            comando.Parameters.AddWithValue("@ValorTotal", valorTotal);
            comando.Parameters.AddWithValue("@FormaPagamento", formaPagamento);
            comando.Parameters.AddWithValue("@Situacao", situacao);


            comando.CommandType = CommandType.Text;

            conexao.Open();

            try
            {
            //    int rowsAffected = comando.ExecuteNonQuery();
            //    if (rowsAffected > 0)
            //    {
            //       // long idVenda = comando.LastInsertedId;
            //       // txt_cod_barras.Text = idVenda.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Erro ao incluir a venda!");
            //    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnadicionarvend_Click(object sender, EventArgs e)
        {
            InserirItemVenda();
            CarregarItems();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            dataVenda = DateTime.Parse(txt_datavenda.Text);
            codigoCliente = id_cliente;
            codigoUsuario = cadusuarios._idUsuario;
            totalItens = Convert.ToDouble(txttotalitems.Text);
            subtotal = Convert.ToDecimal(txtsubtotal.Text);
            desconto = Convert.ToDecimal(txtdesconto.Text);
            valorTotal = Convert.ToDecimal(lblTotal.Text);
            formaPagamento = cmbFormaPag.SelectedItem.ToString();
            situacao = cmbsituacao.SelectedItem.ToString();

            conexao.Open();
            CarregarItems();
            MessageBox.Show("Erro!");
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQtd_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtpreco.Text = Convert.ToString(preco * Convert.ToInt32(txtQtd.Value));
            }
            catch
            {

            }
        }
    }
}
