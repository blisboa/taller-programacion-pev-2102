namespace sistema_req_v1
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.requerimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarRequerimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRequerimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requerimientosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(952, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // requerimientosToolStripMenuItem
            // 
            this.requerimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarRequerimientoToolStripMenuItem,
            this.consultarRequerimientosToolStripMenuItem});
            this.requerimientosToolStripMenuItem.Name = "requerimientosToolStripMenuItem";
            this.requerimientosToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.requerimientosToolStripMenuItem.Text = "Requerimientos";
            // 
            // ingresarRequerimientoToolStripMenuItem
            // 
            this.ingresarRequerimientoToolStripMenuItem.Name = "ingresarRequerimientoToolStripMenuItem";
            this.ingresarRequerimientoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.ingresarRequerimientoToolStripMenuItem.Text = "Ingresar Requerimiento";
            this.ingresarRequerimientoToolStripMenuItem.Click += new System.EventHandler(this.ingresarRequerimientoToolStripMenuItem_Click);
            // 
            // consultarRequerimientosToolStripMenuItem
            // 
            this.consultarRequerimientosToolStripMenuItem.Name = "consultarRequerimientosToolStripMenuItem";
            this.consultarRequerimientosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.consultarRequerimientosToolStripMenuItem.Text = "Consultar Requerimientos";
            this.consultarRequerimientosToolStripMenuItem.Click += new System.EventHandler(this.consultarRequerimientosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 585);
            this.Controls.Add(this.mnuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmMenu";
            this.Text = "Sistema de Gestión de Requerimientos";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem requerimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarRequerimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRequerimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}