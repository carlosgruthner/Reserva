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
    public partial class fLogin : Form
    {
        Thread nt;
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Usuario.Text == "carlos" && tb_Senha.Text == "senha")
            {
                this.Close();
                nt = new Thread(fMinha_pagina);
                nt.SetApartmentState(ApartmentState.MTA);
                nt.Start();
            }

            else
            {
                MessageBox.Show("Usuário ou Senha incorretos");
            }
            
        }

        private void fMinha_pagina()
        {
            Application.Run(new fPrincipal());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Run(new fCadastro_usuario());
        }
    }
}
