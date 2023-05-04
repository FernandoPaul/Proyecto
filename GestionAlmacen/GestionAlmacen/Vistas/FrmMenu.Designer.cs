namespace GestionAlmacen.Vistas
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btn_Entrada = new System.Windows.Forms.Button();
            this.btn_Salidas = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsl_Usuario = new System.Windows.Forms.ToolStripLabel();
            this.tst_Usuario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tst_Hora = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Info = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Entrada
            // 
            this.btn_Entrada.Location = new System.Drawing.Point(76, 150);
            this.btn_Entrada.Name = "btn_Entrada";
            this.btn_Entrada.Size = new System.Drawing.Size(75, 23);
            this.btn_Entrada.TabIndex = 0;
            this.btn_Entrada.Text = "Entrada";
            this.btn_Entrada.UseVisualStyleBackColor = true;
            // 
            // btn_Salidas
            // 
            this.btn_Salidas.Location = new System.Drawing.Point(177, 150);
            this.btn_Salidas.Name = "btn_Salidas";
            this.btn_Salidas.Size = new System.Drawing.Size(75, 23);
            this.btn_Salidas.TabIndex = 1;
            this.btn_Salidas.Text = "Salida";
            this.btn_Salidas.UseVisualStyleBackColor = true;
            // 
            // btn_Productos
            // 
            this.btn_Productos.Location = new System.Drawing.Point(177, 192);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(75, 23);
            this.btn_Productos.TabIndex = 4;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(76, 192);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(75, 23);
            this.btn_Clientes.TabIndex = 3;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.Location = new System.Drawing.Point(273, 192);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(75, 23);
            this.btn_Proveedores.TabIndex = 5;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = true;
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.Location = new System.Drawing.Point(273, 150);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(75, 23);
            this.btn_Inventario.TabIndex = 2;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Location = new System.Drawing.Point(510, 363);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(48, 47);
            this.btn_Salir.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_Salir, "Salir");
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_Usuario,
            this.tst_Usuario,
            this.toolStripLabel1,
            this.tst_Hora});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsl_Usuario
            // 
            this.tsl_Usuario.Name = "tsl_Usuario";
            this.tsl_Usuario.Size = new System.Drawing.Size(97, 22);
            this.tsl_Usuario.Text = "Nombre Usuario:";
            // 
            // tst_Usuario
            // 
            this.tst_Usuario.Enabled = false;
            this.tst_Usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tst_Usuario.Name = "tst_Usuario";
            this.tst_Usuario.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(137, 22);
            this.toolStripLabel1.Text = "Fecha / Hora de entrada:";
            // 
            // tst_Hora
            // 
            this.tst_Hora.Enabled = false;
            this.tst_Hora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tst_Hora.Name = "tst_Hora";
            this.tst_Hora.Size = new System.Drawing.Size(150, 25);
            // 
            // btn_Info
            // 
            this.btn_Info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Info.BackgroundImage")));
            this.btn_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Info.FlatAppearance.BorderSize = 0;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Info.Location = new System.Drawing.Point(437, 363);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(48, 47);
            this.btn_Info.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_Info, "Información");
            this.btn_Info.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 339);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(800, 111);
            this.lbl_Titulo.TabIndex = 10;
            this.lbl_Titulo.Text = "Software Almacen";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_Inventario);
            this.Controls.Add(this.btn_Proveedores);
            this.Controls.Add(this.btn_Clientes);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_Salidas);
            this.Controls.Add(this.btn_Entrada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrada;
        private System.Windows.Forms.Button btn_Salidas;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Proveedores;
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsl_Usuario;
        private System.Windows.Forms.ToolStripTextBox tst_Usuario;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tst_Hora;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}