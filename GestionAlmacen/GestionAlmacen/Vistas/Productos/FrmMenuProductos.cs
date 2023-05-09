using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Vistas
{
    public partial class FrmMenuProductos : Form
    {
        public FrmMenuProductos()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FrmAddProductos frmAddProductos = new FrmAddProductos();
            frmAddProductos.Show();
            this.Close();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            FrmCargarProductos frmCargarProductos = new FrmCargarProductos();
            frmCargarProductos.Show();
            this.Close();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
