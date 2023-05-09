using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Vistas.Entradas
{
    public partial class FrmMenuEntradas : Form
    {
        public FrmMenuEntradas()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lista_Click(object sender, EventArgs e)
        {
            FrmListaEntradas frmListaEntradas = new FrmListaEntradas();
            frmListaEntradas.Show();
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FrmNuevaEntrada frmNuevaEntrada = new FrmNuevaEntrada();
            frmNuevaEntrada.Show();
            this.Close();
        }
    }
}
