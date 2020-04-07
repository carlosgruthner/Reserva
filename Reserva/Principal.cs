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
    public partial class Principal : Form
    {
        Thread nt;
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DadosReserva formReservar = new DadosReserva();
            formReservar.ShowDialog();
        }
    }
}
