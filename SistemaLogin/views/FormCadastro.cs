using SistemaLogin.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin.views
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroUsuario.AddUsuario(txtNome.Text, txtEmail.Text, txtSenha.Text);
            }
            catch
            {
                MessageBox.Show("Falha ao Cadastrar Usuário");
            }

            MessageBox.Show("Usuário Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }
    }
}
