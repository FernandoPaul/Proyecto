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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            tst_Usuario.Text = "Admin";
            tst_Hora.Text = DateTime.Now.ToString();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicioSesion frmInicioSesion = new FrmInicioSesion();
            frmInicioSesion.Show();
        }




        private void btn_Productos_Click(object sender, EventArgs e)
        {
            FrmMenuProductos frmMenuProductos = new FrmMenuProductos();
            frmMenuProductos.Show();
        }
    }
}
