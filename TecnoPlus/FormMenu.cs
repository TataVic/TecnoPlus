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
        private Form frmPanel;
        private bool max = false;
        public FormMenu()
        {
            InitializeComponent();
           
        }
        

      
        private void FormMenu_Load(object sender, EventArgs e)
        {
          
            

            //while (cadusuarios._usuarioLogado == null)
            //{
            //    Visible = false; //this.Visible
             

            //    if (login.Cancelar == true)
            //    {
            //        Application.Exit(); //Encerra a aplicação
            //        return;
            //    }
            }

        private void btn_cadastro_prod_Click(object sender, EventArgs e)
        {
            GerenciaProduto gerenciaprod = new GerenciaProduto();
            gerenciaprod.Show();

        }

        //gerar relatorios
        private void btn_relatorios_Click(object sender, EventArgs e)
        {
          Relatorio relatorio = new Relatorio();
            relatorio.Show();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }
    }

    //private void btnClose_Click(object sender, EventArgs e)
    //{
    //    this.Close();
    //}




    //private void btn_cadastro_clientes_Click(object sender, EventArgs e)
    //{
    //    //cadusuarios._usuarioLogado = null;
    //    //cadusuarios._nomeUsuarioLogado = null;
    //    //cadusuarios._tipoUsuario = null;

    //    //FormMenu_Load(sender, e);
    //    FormCliente formCliente = new FormCliente();
    //    formCliente.Show();



    //}

    // cadastrar produto e gerenciar leva ao forms de gerenciar



    ////registrar vendas
    //private void btn_registro_vendas_Click(object sender, EventArgs e)
    //{
    //    FormVenda formVenda = new FormVenda();
    //    formVenda.Show();
    //}


}

