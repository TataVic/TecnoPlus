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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;

        }


        private void FormMenu_Load(object sender, EventArgs e) //forms menu
        {
            String strConnection = "server=srv470.hstgr.io;User Id=u174804365_btr_lipa747;database=u174804365_btr_lipa747;password=RcVt2XvO#4";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            conexao.ConnectionString = strConnection;


            //while (cadusuarios._usuarioLogado == null)
            //{
            //    Visible = false; //this.Visible


            //    if (login.Cancelar == true)
            //    {
            //        Application.Exit(); //Encerra a aplicação
            //        return;
            //    }
        }

        private void btn_cadastro_prod_Click(object sender, EventArgs e) //forms de produtos
        {
            GerenciaProduto gerenciaprod = new GerenciaProduto();
            this.Hide();
            gerenciaprod.ShowDialog();
            this.Show();


        }
        private void btn_cadastro_clientes_Click(object sender, EventArgs e) //forms cliente
        {
            GerenciarClientes gerenciacliente = new GerenciarClientes();
            this.Hide();
            gerenciacliente.ShowDialog();
            this.Show();
        }

        private void btn_registro_vendas_Click(object sender, EventArgs e) //forms vendas
        {
            GerenciarVendas gerenciarVendas = new GerenciarVendas();
            this.Hide();
            gerenciarVendas.ShowDialog();
            this.Show();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e) //forms de login
        {
            login login = new login();
            login.Show();
        }

        private void btn_relatorios_Click(object sender, EventArgs e) //forms relatórios
        {
            {
                Relatório relatorio = new Relatório();
                this.Hide();
                relatorio.ShowDialog();
                this.Show();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e) //buuton voltar
        {
            login login = new login();
            this.Hide();
            login.ShowDialog();
        }


        //private void btn_cadastro_clientes_Click(object sender, EventArgs e)
        //{
        //    //cadusuarios._usuarioLogado = null;
        //    //cadusuarios._nomeUsuarioLogado = null;
        //    //cadusuarios._tipoUsuario = null;


    }
}

