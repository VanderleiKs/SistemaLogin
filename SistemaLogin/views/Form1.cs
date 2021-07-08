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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CadastroUsuario.AddUsuario("vander", "vander@gmail.com", "123");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin login = new();
   
            while (CadastroUsuario.UsuarioLogado == null)
            {
                if (FormLogin.Cancelar)
                {
                    Application.Exit();
                    return;
                }
                else
                {
                    Visible = false;
                    login.ShowDialog();
                }
            }
            lblInicial.Text = $"Bem vindo(a) {CadastroUsuario.UsuarioLogado.Nome}";
            Visible = true;
        }

        private void lblBListarCadastro_MouseHover(object sender, EventArgs e)
        {
            //Selec. BackColor = Color.Red;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            listUsuarios.Visible = false;
            lblInicial.Visible = true;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            listUsuarios.Visible = true;
            listUsuarios.Items.Clear();

            foreach (Usuario user in CadastroUsuario.usuarios)
            {
                ListViewItem item = new()
                {
                    Text = user.Id.ToString(),
                    SubItems =
                    {
                        user.Nome,
                        user.Email,
                        user.Senha
                    }
                };
                listUsuarios.Items.Add(item);
            }
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro cad = new();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            CadastroUsuario.Sair();
            Visible = false;
            Form1_Load(sender, EventArgs.Empty);
        }
    }
}
