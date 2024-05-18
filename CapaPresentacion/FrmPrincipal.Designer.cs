namespace CapaPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeProductosToolStripMenuItem,
            this.gestionDeProveedoresToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeComprasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.configutaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónDeProductosToolStripMenuItem
            // 
            this.gestiónDeProductosToolStripMenuItem.Name = "gestiónDeProductosToolStripMenuItem";
            this.gestiónDeProductosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.gestiónDeProductosToolStripMenuItem.Text = "Gestión de Productos";
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            // 
            // gestionDeComprasToolStripMenuItem
            // 
            this.gestionDeComprasToolStripMenuItem.Name = "gestionDeComprasToolStripMenuItem";
            this.gestionDeComprasToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.gestionDeComprasToolStripMenuItem.Text = "Gestion de Compras";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(125, 21);
            this.ventasToolStripMenuItem.Text = "Gestion de Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // configutaToolStripMenuItem
            // 
            this.configutaToolStripMenuItem.Name = "configutaToolStripMenuItem";
            this.configutaToolStripMenuItem.Size = new System.Drawing.Size(101, 21);
            this.configutaToolStripMenuItem.Text = "Configuración";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema De Ventas - ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configutaToolStripMenuItem;
    }
}

