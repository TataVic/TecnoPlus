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
    public partial class login : Form
    {

        public static bool Cancelar = false;
        public login()
        {
            InitializeComponent();
        }


        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

             FormMenu formMenu = new FormMenu();
             formMenu.Show();
           

            //if (cadusuarios.Login(usuario, senha))
            //{
            //    FormMenu formMenu = new FormMenu();
            //    formMenu.Show();
            //    this.Close();

            //}
            //else
            //{
            //    txt_usuario.Text = "";
            //    txt_senha.Text = "";

            //}

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            this.Close();
        }
    }
}
