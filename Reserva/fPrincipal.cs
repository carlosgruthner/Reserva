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
    public partial class fPrincipal : Form
    {
        Thread nt;
        public fPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fReservar_dados formReservar = new fReservar_dados();
            formReservar.ShowDialog();
        }
    }
}
