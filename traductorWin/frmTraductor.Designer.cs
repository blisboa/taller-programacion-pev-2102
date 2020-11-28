namespace traductorWin
{
    partial class frmTraductor
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
            this.btnTraducir = new System.Windows.Forms.Button();
            this.txtFraseEspanol = new System.Windows.Forms.TextBox();
            this.lblFraseEspañol = new System.Windows.Forms.Label();
            this.txtFraseIngles = new System.Windows.Forms.TextBox();
            this.lblFraseIngles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTraducir
            // 
            this.btnTraducir.Location = new System.Drawing.Point(59, 101);
            this.btnTraducir.Name = "btnTraducir";
            this.btnTraducir.Size = new System.Drawing.Size(75, 23);
            this.btnTraducir.TabIndex = 0;
            this.btnTraducir.Text = "Traducir";
            this.btnTraducir.UseVisualStyleBackColor = true;
            this.btnTraducir.Click += new System.EventHandler(this.btnTraducir_Click);
            // 
            // txtFraseEspanol
            // 
            this.txtFraseEspanol.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraseEspanol.Location = new System.Drawing.Point(59, 53);
            this.txtFraseEspanol.Name = "txtFraseEspanol";
            this.txtFraseEspanol.Size = new System.Drawing.Size(464, 35);
            this.txtFraseEspanol.TabIndex = 1;
            // 
            // lblFraseEspañol
            // 
            this.lblFraseEspañol.AutoSize = true;
            this.lblFraseEspañol.Location = new System.Drawing.Point(56, 37);
            this.lblFraseEspañol.Name = "lblFraseEspañol";
            this.lblFraseEspañol.Size = new System.Drawing.Size(88, 13);
            this.lblFraseEspañol.TabIndex = 2;
            this.lblFraseEspañol.Text = "Frase en español";
            // 
            // txtFraseIngles
            // 
            this.txtFraseIngles.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtFraseIngles.Location = new System.Drawing.Point(59, 154);
            this.txtFraseIngles.Name = "txtFraseIngles";
            this.txtFraseIngles.Size = new System.Drawing.Size(464, 35);
            this.txtFraseIngles.TabIndex = 3;
            // 
            // lblFraseIngles
            // 
            this.lblFraseIngles.AutoSize = true;
            this.lblFraseIngles.Location = new System.Drawing.Point(59, 135);
            this.lblFraseIngles.Name = "lblFraseIngles";
            this.lblFraseIngles.Size = new System.Drawing.Size(79, 13);
            this.lblFraseIngles.TabIndex = 4;
            this.lblFraseIngles.Text = "Frase en Ingles";
            // 
            // frmTraductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 235);
            this.Controls.Add(this.lblFraseIngles);
            this.Controls.Add(this.txtFraseIngles);
            this.Controls.Add(this.lblFraseEspañol);
            this.Controls.Add(this.txtFraseEspanol);
            this.Controls.Add(this.btnTraducir);
            this.Name = "frmTraductor";
            this.Text = "Traductor";
            this.Load += new System.EventHandler(this.frmTraductor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraducir;
        private System.Windows.Forms.TextBox txtFraseEspanol;
        private System.Windows.Forms.Label lblFraseEspañol;
        private System.Windows.Forms.TextBox txtFraseIngles;
        private System.Windows.Forms.Label lblFraseIngles;
    }
}

