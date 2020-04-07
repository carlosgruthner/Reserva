using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Reserva
{
    public partial class Login : Form
    {
        Thread NewLogin;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TbUsuario.Text == "carlos" && TbSenha.Text == "senha")
            {
                this.Close();
                NewLogin = new Thread(PainelPricipal);
                NewLogin.SetApartmentState(ApartmentState.MTA);
                NewLogin.Start();
            }

            else
            {
                MessageBox.Show("Usuário ou Senha incorretos");
            }
            
        }

        private void PainelPricipal()
        {
            Application.Run(new Principal());
        }

        private void Sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void CadUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Run(new CadastroUsuario());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
