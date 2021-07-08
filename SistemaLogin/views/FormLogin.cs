using SistemaLogin.domain;
using SistemaLogin.entities;
using SistemaLogin.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public static bool Cadastro = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            CadastroUsuario.AddUsuario("ana", "ana@gmail.com", "123");
            if (CadastroUsuario.Login(txtUsuario.Text, txtSenha.Text))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Falha no Login");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
        }

        private void lblNaoCad_Click(object sender, EventArgs e)
        {
            Cadastro = true;
            FormCadastro cad = new();
            
                cad.Show();
         }
    }
}
