namespace GestionAlmacen.Vistas.Salidas
{
    partial class FrmNuevaSalida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Anadir = new System.Windows.Forms.Button();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_NomCliente = new System.Windows.Forms.TextBox();
            this.btn_BuscarProducto = new System.Windows.Forms.Button();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_CifCliente = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NomProv = new System.Windows.Forms.TextBox();
            this.btn_BuscarProv = new System.Windows.Forms.Button();
            this.lbl_NomProv = new System.Windows.Forms.Label();
            this.txt_CifProv = new System.Windows.Forms.TextBox();
            this.lbl_CifProv = new System.Windows.Forms.Label();
            this.grb_Registro = new System.Windows.Forms.GroupBox();
            this.dtp_FechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaRegistro = new System.Windows.Forms.Label();
            this.txt_NDocumento = new System.Windows.Forms.TextBox();
            this.lbl_NDocumento = new System.Windows.Forms.Label();
            this.btn_GuardarSalidas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grb_Registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 249);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Anadir);
            this.groupBox2.Controls.Add(this.nud_Cantidad);
            this.groupBox2.Controls.Add(this.lbl_Cantidad);
            this.groupBox2.Controls.Add(this.txt_NomCliente);
            this.groupBox2.Controls.Add(this.btn_BuscarProducto);
            this.groupBox2.Controls.Add(this.lbl_Descripcion);
            this.groupBox2.Controls.Add(this.txt_CifCliente);
            this.groupBox2.Controls.Add(this.lbl_Codigo);
            this.groupBox2.Location = new System.Drawing.Point(13, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 44);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btn_Anadir
            // 
            this.btn_Anadir.Location = new System.Drawing.Point(708, 11);
            this.btn_Anadir.Name = "btn_Anadir";
            this.btn_Anadir.Size = new System.Drawing.Size(61, 23);
            this.btn_Anadir.TabIndex = 5;
            this.btn_Anadir.Text = "Añadir";
            this.btn_Anadir.UseVisualStyleBackColor = true;
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(637, 13);
            this.nud_Cantidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(65, 20);
            this.nud_Cantidad.TabIndex = 3;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(582, 16);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cantidad.TabIndex = 6;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_NomCliente
            // 
            this.txt_NomCliente.Location = new System.Drawing.Point(317, 13);
            this.txt_NomCliente.Name = "txt_NomCliente";
            this.txt_NomCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NomCliente.TabIndex = 5;
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.Location = new System.Drawing.Point(501, 11);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarProducto.TabIndex = 4;
            this.btn_BuscarProducto.Text = "Buscar";
            this.btn_BuscarProducto.UseVisualStyleBackColor = true;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(215, 16);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 3;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // txt_CifCliente
            // 
            this.txt_CifCliente.Location = new System.Drawing.Point(89, 13);
            this.txt_CifCliente.Name = "txt_CifCliente";
            this.txt_CifCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_CifCliente.TabIndex = 2;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(6, 16);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_Codigo.TabIndex = 1;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NomProv);
            this.groupBox1.Controls.Add(this.btn_BuscarProv);
            this.groupBox1.Controls.Add(this.lbl_NomProv);
            this.groupBox1.Controls.Add(this.txt_CifProv);
            this.groupBox1.Controls.Add(this.lbl_CifProv);
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 44);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txt_NomProv
            // 
            this.txt_NomProv.Location = new System.Drawing.Point(317, 13);
            this.txt_NomProv.Name = "txt_NomProv";
            this.txt_NomProv.Size = new System.Drawing.Size(178, 20);
            this.txt_NomProv.TabIndex = 5;
            // 
            // btn_BuscarProv
            // 
            this.btn_BuscarProv.Location = new System.Drawing.Point(501, 11);
            this.btn_BuscarProv.Name = "btn_BuscarProv";
            this.btn_BuscarProv.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarProv.TabIndex = 4;
            this.btn_BuscarProv.Text = "Buscar";
            this.btn_BuscarProv.UseVisualStyleBackColor = true;
            // 
            // lbl_NomProv
            // 
            this.lbl_NomProv.AutoSize = true;
            this.lbl_NomProv.Location = new System.Drawing.Point(215, 16);
            this.lbl_NomProv.Name = "lbl_NomProv";
            this.lbl_NomProv.Size = new System.Drawing.Size(79, 13);
            this.lbl_NomProv.TabIndex = 3;
            this.lbl_NomProv.Text = "Nombre Cliente";
            // 
            // txt_CifProv
            // 
            this.txt_CifProv.Location = new System.Drawing.Point(89, 13);
            this.txt_CifProv.Name = "txt_CifProv";
            this.txt_CifProv.Size = new System.Drawing.Size(100, 20);
            this.txt_CifProv.TabIndex = 2;
            // 
            // lbl_CifProv
            // 
            this.lbl_CifProv.AutoSize = true;
            this.lbl_CifProv.Location = new System.Drawing.Point(6, 16);
            this.lbl_CifProv.Name = "lbl_CifProv";
            this.lbl_CifProv.Size = new System.Drawing.Size(58, 13);
            this.lbl_CifProv.TabIndex = 1;
            this.lbl_CifProv.Text = "CIF Cliente";
            // 
            // grb_Registro
            // 
            this.grb_Registro.Controls.Add(this.dtp_FechaRegistro);
            this.grb_Registro.Controls.Add(this.lbl_FechaRegistro);
            this.grb_Registro.Controls.Add(this.txt_NDocumento);
            this.grb_Registro.Controls.Add(this.lbl_NDocumento);
            this.grb_Registro.Location = new System.Drawing.Point(13, 12);
            this.grb_Registro.Name = "grb_Registro";
            this.grb_Registro.Size = new System.Drawing.Size(775, 44);
            this.grb_Registro.TabIndex = 4;
            this.grb_Registro.TabStop = false;
            // 
            // dtp_FechaRegistro
            // 
            this.dtp_FechaRegistro.Enabled = false;
            this.dtp_FechaRegistro.Location = new System.Drawing.Point(295, 13);
            this.dtp_FechaRegistro.Name = "dtp_FechaRegistro";
            this.dtp_FechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaRegistro.TabIndex = 1;
            this.dtp_FechaRegistro.Value = new System.DateTime(2023, 5, 9, 15, 54, 15, 0);
            // 
            // lbl_FechaRegistro
            // 
            this.lbl_FechaRegistro.AutoSize = true;
            this.lbl_FechaRegistro.Location = new System.Drawing.Point(215, 16);
            this.lbl_FechaRegistro.Name = "lbl_FechaRegistro";
            this.lbl_FechaRegistro.Size = new System.Drawing.Size(74, 13);
            this.lbl_FechaRegistro.TabIndex = 3;
            this.lbl_FechaRegistro.Text = "Fecha registro";
            // 
            // txt_NDocumento
            // 
            this.txt_NDocumento.Enabled = false;
            this.txt_NDocumento.Location = new System.Drawing.Point(89, 13);
            this.txt_NDocumento.Name = "txt_NDocumento";
            this.txt_NDocumento.Size = new System.Drawing.Size(100, 20);
            this.txt_NDocumento.TabIndex = 2;
            // 
            // lbl_NDocumento
            // 
            this.lbl_NDocumento.AutoSize = true;
            this.lbl_NDocumento.Location = new System.Drawing.Point(6, 16);
            this.lbl_NDocumento.Name = "lbl_NDocumento";
            this.lbl_NDocumento.Size = new System.Drawing.Size(77, 13);
            this.lbl_NDocumento.TabIndex = 1;
            this.lbl_NDocumento.Text = "Nº Documento";
            // 
            // btn_GuardarSalidas
            // 
            this.btn_GuardarSalidas.Location = new System.Drawing.Point(350, 418);
            this.btn_GuardarSalidas.Name = "btn_GuardarSalidas";
            this.btn_GuardarSalidas.Size = new System.Drawing.Size(101, 23);
            this.btn_GuardarSalidas.TabIndex = 8;
            this.btn_GuardarSalidas.Text = "Guardar Salidas";
            this.btn_GuardarSalidas.UseVisualStyleBackColor = true;
            // 
            // FrmNuevaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GuardarSalidas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_Registro);
            this.Name = "FrmNuevaSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Salida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_Registro.ResumeLayout(false);
            this.grb_Registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Anadir;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_NomCliente;
        private System.Windows.Forms.Button btn_BuscarProducto;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_CifCliente;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NomProv;
        private System.Windows.Forms.Button btn_BuscarProv;
        private System.Windows.Forms.Label lbl_NomProv;
        private System.Windows.Forms.TextBox txt_CifProv;
        private System.Windows.Forms.Label lbl_CifProv;
        private System.Windows.Forms.GroupBox grb_Registro;
        private System.Windows.Forms.DateTimePicker dtp_FechaRegistro;
        private System.Windows.Forms.Label lbl_FechaRegistro;
        private System.Windows.Forms.TextBox txt_NDocumento;
        private System.Windows.Forms.Label lbl_NDocumento;
        private System.Windows.Forms.Button btn_GuardarSalidas;
    }
}