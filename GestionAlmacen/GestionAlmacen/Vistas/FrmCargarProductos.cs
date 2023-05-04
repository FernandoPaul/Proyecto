using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Vistas
{
    public partial class FrmCargarProductos : Form
    {
        public FrmCargarProductos()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //Abre una ventana para elegir un documento excel.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx"; //Indico las extensiones que puede subir
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_NomArchivo.Text = openFileDialog.FileName.ToString();

                //timer1.Tick += avanzarBarraDeProgreso;
                //timer1.Start();
            }
        }

        private void btn_Subir_Click(object sender, EventArgs e)
        {
            if (txt_NomArchivo.Text != "")
            {
                IWorkbook MiExcel = null;
                FileStream fs = new FileStream(oOpenFileDialog.FileName, FileMode.Open, FileAccess.Read);
            }
            else
            {
                MessageBox.Show("Cargue el documento");
            }
        }
    }
}
