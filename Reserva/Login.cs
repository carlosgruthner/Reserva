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
        Thread NewUser;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TbUsuario.Text == "admin" && TbSenha.Text == "admin")
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

        private void BtnCad_Click(object sender, EventArgs e)
        {
            Application.Run(new CadastroUsuario());
        }

        private void CadUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser = new Thread(PainelCadastro);
            NewUser.SetApartmentState(ApartmentState.MTA);
            NewUser.Start();
        }

        private void PainelCadastro()
        {
            Application.Run(new CadastroUsuario());
        }
    }
}
