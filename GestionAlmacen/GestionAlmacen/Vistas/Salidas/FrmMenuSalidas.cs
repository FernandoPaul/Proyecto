using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Vistas.Salidas
{
    public partial class FrmMenuSalidas : Form
    {
        public FrmMenuSalidas()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FrmNuevaSalida frmNuevaSalida = new FrmNuevaSalida();
            frmNuevaSalida.Show();
            this.Close();
        }
        private void btn_Lista_Click(object sender, EventArgs e)
        {
            FrmListaSalidas frmListaSalidas =   new FrmListaSalidas();
            frmListaSalidas.Show();
            this.Close();
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
