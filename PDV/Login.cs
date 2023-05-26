using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string senha = txtsenha.Text;

            if (usuario == "admin" && senha == "Senha123")
             {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
             }
            else
             {
                MessageBox.Show("Credenciais Inválidas. Tente novamente.");
             }
        }

        private void linksair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
