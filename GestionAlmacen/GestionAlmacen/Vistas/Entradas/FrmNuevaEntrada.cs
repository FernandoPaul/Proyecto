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
    public partial class FrmNuevaEntrada : Form
    {
        public FrmNuevaEntrada()
        {
            InitializeComponent();
        }

        private void FrmNuevaEntrada_Load(object sender, EventArgs e)
        {
            txt_NDocumento.Text = "10000";
            dtp_FechaRegistro.Value = DateTime.Today;

        }
    }
}
