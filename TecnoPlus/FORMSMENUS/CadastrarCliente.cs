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

namespace TecnoPlus.FORMSMENUS
{


    public partial class CadastrarCliente : Form //formcadcliente
    {
        public string maneira;
        string nomeCompleto;
        bool situacao;
        string cpf;
        string rg;
        string genero;
        DateTime dataNascimento;
        string estadoCivil;
        string profissao;
        string nacionalidade;
        string telefone;
        string celular;
        bool whatsapp;
        string email;
        string endereco;
        string numero;
        string complemento;
        string bairro;
        string cidade;
        string uf;
        string cep;
        string observacoes;
        int codigo;
        int index;


         public CadastrarCliente()
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            InitializeComponent();
            maneira = "inserir";

        }
        public CadastrarCliente(DataGridView grid)
        {
            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            InitializeComponent();
            maneira = "editar";

            txt_nome.Text = grid.SelectedRows[0].Cells["NOME_COMPLETO"].Value.ToString();
            ck_ativo.Checked = Convert.ToBoolean(grid.SelectedRows[0].Cells["SITUACAO"].Value);
            txt_cpf.Text = grid.SelectedRows[0].Cells["CPF"].Value.ToString();
            txt_rg.Text = grid.SelectedRows[0].Cells["RG"].Value.ToString();
            string Genero = grid.SelectedRows[0].Cells["GENERO"].Value.ToString();

            if (Genero == "M")
            {
                rb_mas.Checked = true;
            }
            else if (Genero == "F")
            {
                rb_fem.Checked = true;
            }
            else
            {
                rb_out.Checked = true;
            }

            txt_data.Text = grid.SelectedRows[0].Cells["DATA_NASCIMENTO"].Value.ToString();
            cb_estado.SelectedItem = grid.SelectedRows[0].Cells["ESTADO_CIVIL"].Value.ToString();
            txt_profissao.Text = grid.SelectedRows[0].Cells["PROFISSAO"].Value.ToString();
            txt_nacionalidade.Text = grid.SelectedRows[0].Cells["NACIONALIDADE"].Value.ToString();
            txt_telefone.Text = grid.SelectedRows[0].Cells["TELEFONE"].Value.ToString();
            txt_celular.Text = grid.SelectedRows[0].Cells["CELULAR"].Value.ToString();
            ck_whatsapp.Checked = Convert.ToBoolean(grid.SelectedRows[0].Cells["WHATSAPP"].Value);
            txt_cidade.Text = grid.SelectedRows[0].Cells["EMAIL"].Value.ToString();
            txt_rua.Text = grid.SelectedRows[0].Cells["ENDERECO"].Value.ToString();
            txt_numero.Text = grid.SelectedRows[0].Cells["NUMERO"].Value.ToString();
            txt_complemento.Text = grid.SelectedRows[0].Cells["COMPLEMENTO"].Value.ToString();
            txt_bairro.Text = grid.SelectedRows[0].Cells["BAIRRO"].Value.ToString();
            txt_cidade.Text = grid.SelectedRows[0].Cells["CIDADE"].Value.ToString();
            cb_uf.SelectedItem = grid.SelectedRows[0].Cells["UF"].Value.ToString();
            txt_cep.Text = grid.SelectedRows[0].Cells["CEP"].Value.ToString();
            txt_obs.Text = grid.SelectedRows[0].Cells["OBSERVACOES"].Value.ToString();
            codigo = Convert.ToInt32(grid.SelectedRows[0].Cells["ID"].Value);

            index = grid.SelectedRows[0].Index;
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {


        }


        private void btn_voltar_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            nomeCompleto = txt_nome.Text;
            situacao = ck_ativo.Checked;
            cpf = txt_cpf.Text;
            rg = txt_rg.Text;
            genero = ObGenero();
            dataNascimento = txt_data.Value;
            profissao = txt_profissao.Text;
            nacionalidade = txt_nacionalidade.Text;
            telefone = txt_telefone.Text;
            celular = txt_celular.Text;
            whatsapp = ck_whatsapp.Checked;
            email = txt_cidade.Text;
            endereco = txt_rua.Text;
            numero = txt_numero.Text;
            complemento = txt_complemento.Text;
            bairro = txt_bairro.Text;
            cidade = txt_cidade.Text;
            cep = txt_cep.Text;
            observacoes = txt_obs.Text;

            if (cb_uf.SelectedItem != null)
            {
                uf = cb_uf.SelectedItem.ToString();
            }

            if (cb_estado.Text != "")
            {
                estadoCivil = cb_estado.SelectedItem.ToString();
            }


            if (maneira == "inserir")
            {
                InsercaoCli();
            }
            else if (maneira == "editar")
            {
                EdicaoCli();
            }

            FecharForm();
        }

        public event EventHandler CadastroConcluido;
        private void FecharForm()
        {
            if (CadastroConcluido != null)
            {
                CadastroConcluido(this, EventArgs.Empty);

            }
        }
        private void EdicaoCli()
        {
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

            string sql = "UPDATE tab_cliente SET NOME_COMPLETO = @NomeCompleto, SITUACAO = @Situacao, CPF = @CPF, RG = @RG, GENERO = @Genero, DATA_NASCIMENTO = @DataNascimento, ESTADO_CIVIL = @EstadoCivil, PROFISSAO = @Profissao, NACIONALIDADE = @Nacionalidade, TELEFONE = @Telefone, CELULAR = @Celular, WHATSAPP = @WhatsApp, EMAIL = @Email, ENDERECO = @Endereco, NUMERO = @Numero, COMPLEMENTO = @Complemento, BAIRRO = @Bairro, CIDADE = @Cidade, UF = @UF, CEP = @CEP, OBSERVACOES = @Observacoes WHERE ID = @Codigo";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@NomeCompleto", nomeCompleto);
            comando.Parameters.AddWithValue("@Situacao", situacao);
            comando.Parameters.AddWithValue("@CPF", cpf);
            comando.Parameters.AddWithValue("@RG", rg);
            comando.Parameters.AddWithValue("@Genero", genero);
            comando.Parameters.AddWithValue("@DataNascimento", dataNascimento);
            comando.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
            comando.Parameters.AddWithValue("@Profissao", profissao);
            comando.Parameters.AddWithValue("@Nacionalidade", nacionalidade);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Celular", celular);
            comando.Parameters.AddWithValue("@WhatsApp", whatsapp);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Endereco", endereco);
            comando.Parameters.AddWithValue("@Numero", numero);
            comando.Parameters.AddWithValue("@Complemento", complemento);
            comando.Parameters.AddWithValue("@Bairro", bairro);
            comando.Parameters.AddWithValue("@Cidade", cidade);
            comando.Parameters.AddWithValue("@UF", uf);
            comando.Parameters.AddWithValue("@CEP", cep);
            comando.Parameters.AddWithValue("@Observacoes", observacoes);
            comando.Parameters.AddWithValue("@Codigo", codigo); // Código do cliente a ser editado
            comando.CommandType = CommandType.Text;

            conexao.Open();


            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro atualizado com sucesso!");
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
        private void InsercaoCli()
        {

            string strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;
            string sql = "INSERT INTO tab_cliente(NOME_COMPLETO, SITUACAO, CPF, RG, GENERO, DATA_NASCIMENTO, ESTADO_CIVIL, PROFISSAO, NACIONALIDADE, TELEFONE, CELULAR, WHATSAPP, EMAIL, ENDERECO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, UF, CEP, OBSERVACOES) " +
                         "VALUES (@NomeCompleto, @Situacao, @CPF, @RG, @Genero, @DataNascimento, @EstadoCivil, @Profissao, @Nacionalidade, @Telefone, @Celular, @WhatsApp, @Email, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @UF, @CEP, @Observacoes)"; ;

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@NomeCompleto", nomeCompleto);
            comando.Parameters.AddWithValue("@Situacao", situacao);
            comando.Parameters.AddWithValue("@CPF", cpf);
            comando.Parameters.AddWithValue("@RG", rg);
            comando.Parameters.AddWithValue("@Genero", genero);
            comando.Parameters.AddWithValue("@DataNascimento", dataNascimento);
            comando.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
            comando.Parameters.AddWithValue("@Profissao", profissao);
            comando.Parameters.AddWithValue("@Nacionalidade", nacionalidade);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Celular", celular);
            comando.Parameters.AddWithValue("@WhatsApp", whatsapp);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Endereco", endereco);
            comando.Parameters.AddWithValue("@Numero", numero);
            comando.Parameters.AddWithValue("@Complemento", complemento);
            comando.Parameters.AddWithValue("@Bairro", bairro);
            comando.Parameters.AddWithValue("@Cidade", cidade);
            comando.Parameters.AddWithValue("@UF", uf);
            comando.Parameters.AddWithValue("@CEP", cep);
            comando.Parameters.AddWithValue("@Observacoes", observacoes);
            comando.CommandType = CommandType.Text;

            conexao.Open();

            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro incluído com sucesso!", "INCLUSÃO", MessageBoxButtons.OK);
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
        private string ObGenero()
        {
            if (rb_mas.Checked)
                return "M";
            else if (rb_fem.Checked)
                return "F";
            else if (rb_out.Checked)
                return "O";
            else
                return string.Empty;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
