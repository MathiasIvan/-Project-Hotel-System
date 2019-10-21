using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Registrador
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void registradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrador frmRegis = new frmRegistrador();
            frmRegis.Show();
        }

        private void estadoDeHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstado_Habitacion frmEstadoDeHabit = new frmEstado_Habitacion();
            frmEstadoDeHabit.Show();

        }
    }
}
