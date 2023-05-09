namespace GestionAlmacen.Vistas.Salidas
{
    partial class FrmMenuSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuSalidas));
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Lista = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.BackgroundImage")));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(194, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(57, 56);
            this.btn_Cerrar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_Cerrar, "Atrás");
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Lista
            // 
            this.btn_Lista.BackColor = System.Drawing.Color.Transparent;
            this.btn_Lista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Lista.BackgroundImage")));
            this.btn_Lista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Lista.FlatAppearance.BorderSize = 0;
            this.btn_Lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lista.Location = new System.Drawing.Point(103, 12);
            this.btn_Lista.Name = "btn_Lista";
            this.btn_Lista.Size = new System.Drawing.Size(57, 56);
            this.btn_Lista.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_Lista, "Lista de Salidas");
            this.btn_Lista.UseVisualStyleBackColor = false;
            this.btn_Lista.Click += new System.EventHandler(this.btn_Lista_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(57, 56);
            this.btn_Add.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_Add, "Añadir");
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // FrmMenuSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 81);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Lista);
            this.Controls.Add(this.btn_Add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuSalidas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Lista;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}