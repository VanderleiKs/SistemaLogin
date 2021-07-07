using SistemaLogin.domain;
using SistemaLogin.entities;
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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormLogin f = new();
            
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



           // Usuario user = CadastroUsuario.usuarios
           //                .FirstOrDefault(u => u.Nome == txtUsuario.Text);
           // if (user == null)
           // {
           //     MessageBox.Show("Usuario não encontrado");
           // }                        
           //else if(user.Senha == txtSenha.Text)         
           // {

           //     MessageBox.Show("Usuario com senha correta");
           // }
           // else
           // {
           //     MessageBox.Show("Usuario sem senha correta");
           // }
        }
    }
}
