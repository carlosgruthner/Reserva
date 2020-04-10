using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void SaveCad_Click(object sender, EventArgs e)
        {
            Application.Run(new Principal());
        }

        private void CancelCad_Click(object sender, EventArgs e)
        {
            Application.Run(new Login());
        }
    }
}
