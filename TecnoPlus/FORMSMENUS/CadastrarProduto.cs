using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnoPlus  // CADASTROS
{
    public partial class CadastrarProduto : Form
    {
        public string modalidade;
        string descricao;
        string marca;
        string codBarras;
        decimal altura;
        decimal profundidade;
        decimal largura;
        decimal peso;
        decimal qtd;
        float preco;
        bool situacao;
        string condicao;
        int codigo;

        
        public CadastrarProduto()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            InitializeComponent();
            modalidade = "inserir";

            num_altura.Maximum = decimal.MaxValue;
            num_peso.Maximum = decimal.MaxValue;
            num_largura.Maximum = decimal.MaxValue;
            num_profundidade.Maximum = decimal.MaxValue;
            num_preco.Maximum = decimal.MaxValue;
            num_qtd.Maximum = decimal.MaxValue;
        }
        public CadastrarProduto(DataGridView gridProduto)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            InitializeComponent();
            modalidade = "editar";

            num_altura.Maximum = decimal.MaxValue;
            num_peso.Maximum = decimal.MaxValue;
            num_largura.Maximum = decimal.MaxValue;
            num_profundidade.Maximum = decimal.MaxValue;
            num_preco.Maximum = decimal.MaxValue;
            num_qtd.Maximum = decimal.MaxValue;

            if (gridProduto.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridProduto.SelectedRows[0];
                txt_descricao.Text = selectedRow.Cells["DESCRICAO"].Value.ToString();
                txt_marca.Text = selectedRow.Cells["MARCA"].Value.ToString();
                txt_cod_barras.Text = selectedRow.Cells["CODIGO_BARRAS"].Value.ToString();
                num_altura.Value = Convert.ToDecimal(selectedRow.Cells["ALTURA_CM"].Value);
                num_profundidade.Value = Convert.ToDecimal(selectedRow.Cells["PROFUNDIDADE_CM"].Value);
                num_largura.Value = Convert.ToDecimal(selectedRow.Cells["LARGURA_CM"].Value);
                float pesoGramas = (float)selectedRow.Cells["PESO_GRAMAS"].Value;
                num_peso.Value = Convert.ToDecimal(pesoGramas);
                num_qtd.Value = Convert.ToDecimal(selectedRow.Cells["QUANTIDADE_ESTOQUE"].Value);
                num_preco.Value = Convert.ToDecimal(selectedRow.Cells["PRECO_VENDA"].Value);
                /*ck_ativo.Checked = Convert.ToBoolean(selectedRow.Cells["SITUACAO"].Value);*/
                string condicao = selectedRow.Cells["CONDICAO"].Value.ToString();


                if (condicao == "NOVO")
                {
                    rb_novo.Checked = true;
                }
                else if (condicao == "USADO")
                {
                    rb_usado.Checked = true;
                }

                codigo = Convert.ToInt32(gridProduto.SelectedRows[0].Cells["CODIGO"].Value);
            }



            
        }
        
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            descricao = txt_descricao.Text;
            marca = txt_marca.Text;
            codBarras = txt_cod_barras.Text;
            altura = num_altura.Value;
            profundidade = num_profundidade.Value;
            largura = num_largura.Value;
            peso = num_peso.Value;
            qtd = num_qtd.Value;
            preco = Convert.ToSingle(num_preco.Value);
            situacao = ck_ativo.Checked;
            condicao = CondicaoObtida();

            if (modalidade == "inserir")
            {
                ProdutoInserir();
                
            }
            else if (modalidade == "editar")
            {
                ProdutoEditar();
            }
            FecharForms();
            MessageBox.Show("Produto adicionado com sucesso!", "ADIÇÃO DE PRODUTO");
            
        }


        private string CondicaoObtida()
        {
            if (rb_novo.Checked)
                return "Novo";
            else if (rb_usado.Checked)
                return "Usado";
            else
                return string.Empty;
        }

        private void ProdutoInserir()  //inserior o produto
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            string mysql = "INSERT INTO tab_produtos(DESCRICAO, CODIGO_BARRAS, MARCA, PESO_GRAMAS, LARGURA_CM, ALTURA_CM, PROFUNDIDADE_CM, SITUACAO, CONDICAO, PRECO_VENDA, QUANTIDADE_ESTOQUE)" +
                                      "VALUES(@DESCRICAO, @CODIGO_BARRAS, @MARCA, @PESO_GRAMAS, @LARGURA_CM, @ALTURA_CM, @PROFUNDIDADE_CM, @SITUACAO, @CONDICAO, @PRECO_VENDA, @QUANTIDADE_ESTOQUE)";
            MySqlCommand comando = new MySqlCommand(mysql, conexao);
            

            comando.Parameters.AddWithValue("@DESCRICAO", descricao);
            comando.Parameters.AddWithValue("@CODIGO_BARRAS", codBarras);
            comando.Parameters.AddWithValue("@MARCA", marca);
            comando.Parameters.AddWithValue("@PESO_GRAMAS", peso);
            comando.Parameters.AddWithValue("@LARGURA_CM", largura);
            comando.Parameters.AddWithValue("@ALTURA_CM", altura);
            comando.Parameters.AddWithValue("@PROFUNDIDADE_CM", profundidade);
            comando.Parameters.AddWithValue("@SITUACAO", situacao);
            comando.Parameters.AddWithValue("@CONDICAO", condicao);
            comando.Parameters.AddWithValue("@PRECO_VENDA", preco);
            comando.Parameters.AddWithValue("@QUANTIDADE_ESTOQUE", qtd);
            comando.CommandType = CommandType.Text;

            conexao.Open();
            

            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro incluído com sucesso!", "INCLUSÃO DE PRODUTO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", "ERRO DE INCLUSÃO" + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
            private void ProdutoEditar()  //editar o produto
            {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            string mysql = "UPDATE  tab_produtos SET DESCRICAO = @DESCRICAO, CODIGO_BARRAS = @CODIGO_BARRAS, MARCA = @MARCA, PESO_GRAMAS = @PESO_GRAMAS, LARGURA_CM = @LARGURA_CM, ALTURA_CM = @ALTURA_CM, PROFUNDIDADE_CM = @PROFUNDIDADE_CM, SITUACAO = @SITUACAO, CONDICAO = @CONDICAO, PRECO_VENDA = @PRECO_VENDA, QUANTIDADE_ESTOQUE = @QUANTIDADE_ESTOQUE WHERE CODIGO = @Codigo";

                
                MySqlCommand comando = new MySqlCommand(mysql, conexao);

                comando.Parameters.AddWithValue("@DESCRICAO", descricao);
                comando.Parameters.AddWithValue("@CODIGO_BARRAS", codBarras);
                comando.Parameters.AddWithValue("@MARCA", marca);
                comando.Parameters.AddWithValue("@PESO_GRAMAS", peso);
                comando.Parameters.AddWithValue("@LARGURA_CM", largura);
                comando.Parameters.AddWithValue("@ALTURA_CM", altura);
                comando.Parameters.AddWithValue("@PROFUNDIDADE_CM", profundidade);
                comando.Parameters.AddWithValue("@SITUACAO", situacao);
                comando.Parameters.AddWithValue("@CONDICAO", condicao);
                comando.Parameters.AddWithValue("@PRECO_VENDA", preco);
                comando.Parameters.AddWithValue("@QUANTIDADE_ESTOQUE", qtd);
                comando.Parameters.AddWithValue("@CODIGO", codigo);
                comando.CommandType = CommandType.Text;

                conexao.Open();
                

                try
                {
                    int i = comando.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro atualizado com sucesso!", "ATUALIZAÇÃO DO PRODUTO");
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
        public event EventHandler ConcluirCadastro; //Derivação de classe - eventshandler
        private void FecharForms()
        {
            // Verificação de inscrição no evento EdicaoConcluida
            if (ConcluirCadastro != null)
            {
                ConcluirCadastro(this, EventArgs.Empty);
            }
            this.Close();
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            num_altura.Maximum = decimal.MaxValue;
            num_peso.Maximum = decimal.MaxValue;
            num_largura.Maximum = decimal.MaxValue;
            num_profundidade.Maximum = decimal.MaxValue;
            num_preco.Maximum = decimal.MaxValue;
            num_qtd.Maximum = decimal.MaxValue;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}

