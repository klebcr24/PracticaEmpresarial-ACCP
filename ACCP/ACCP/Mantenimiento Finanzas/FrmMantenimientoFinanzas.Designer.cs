namespace ACCP.Mantenimiento_Finanzas
{
    partial class FrmMantenimientoFinanzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoFinanzas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoPagosToolStripMenuItem,
            this.mantenimientosGastosToolStripMenuItem,
            this.salirDelMantenimientoToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // mantenimientoPagosToolStripMenuItem
            // 
            this.mantenimientoPagosToolStripMenuItem.Name = "mantenimientoPagosToolStripMenuItem";
            this.mantenimientoPagosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mantenimientoPagosToolStripMenuItem.Text = "Mantenimiento Pagos";
            // 
            // mantenimientosGastosToolStripMenuItem
            // 
            this.mantenimientosGastosToolStripMenuItem.Name = "mantenimientosGastosToolStripMenuItem";
            this.mantenimientosGastosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mantenimientosGastosToolStripMenuItem.Text = "Mantenimientos Gastos";
            // 
            // salirDelMantenimientoToolStripMenuItem
            // 
            this.salirDelMantenimientoToolStripMenuItem.Name = "salirDelMantenimientoToolStripMenuItem";
            this.salirDelMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.salirDelMantenimientoToolStripMenuItem.Text = "Salir del Mantenimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 472);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMantenimientoFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMantenimientoFinanzas";
            this.Text = "Mantenimiento Finanzas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelMantenimientoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}