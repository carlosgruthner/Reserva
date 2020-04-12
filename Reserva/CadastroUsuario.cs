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
    public partial class CadastroUsuario : Form
    {

        Thread Login;

        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void SaveCad_Click(object sender, EventArgs e)
        {
            this.Close();
            Login = new Thread(PainelPrincipal);
            Login.SetApartmentState(ApartmentState.MTA);
            Login.Start();
        }

        private void PainelPrincipal()
        {
            Application.Run(new Principal());
        }

        private void CancelCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
