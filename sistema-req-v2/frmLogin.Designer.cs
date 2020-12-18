namespace sistema_req_v1
{
    partial class frmLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.chkVer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(131, 49);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(131, 94);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 1;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(131, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(54, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(54, 101);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave:";
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.Location = new System.Drawing.Point(265, 101);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(91, 17);
            this.chkVer.TabIndex = 5;
            this.chkVer.Text = "Mostrar Clave";
            this.chkVer.UseVisualStyleBackColor = true;
            this.chkVer.CheckedChanged += new System.EventHandler(this.chkVer_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 267);
            this.Controls.Add(this.chkVer);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Name = "frmLogin";
            this.Text = "Sistema de Requerimientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.CheckBox chkVer;
    }
}

