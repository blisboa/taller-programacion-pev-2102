namespace sistema_req_v1
{
    partial class frmIngresar
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
            this.cmbTipoReq = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbPriodidad = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipoReq
            // 
            this.cmbTipoReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReq.FormattingEnabled = true;
            this.cmbTipoReq.Location = new System.Drawing.Point(208, 37);
            this.cmbTipoReq.Name = "cmbTipoReq";
            this.cmbTipoReq.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoReq.TabIndex = 0;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(208, 79);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuario.TabIndex = 1;
            // 
            // cmbPriodidad
            // 
            this.cmbPriodidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriodidad.FormattingEnabled = true;
            this.cmbPriodidad.Location = new System.Drawing.Point(208, 224);
            this.cmbPriodidad.Name = "cmbPriodidad";
            this.cmbPriodidad.Size = new System.Drawing.Size(121, 21);
            this.cmbPriodidad.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(84, 143);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(270, 59);
            this.txtDesc.TabIndex = 3;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(31, 288);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(171, 288);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(302, 288);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(180, 23);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ir a listado de requerimientos";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(81, 44);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(114, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo de Requerimiento";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(81, 87);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Usuario";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(81, 127);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Descripcion";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(81, 227);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(48, 13);
            this.lblPrioridad.TabIndex = 10;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // frmIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 352);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.cmbPriodidad);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.cmbTipoReq);
            this.Name = "frmIngresar";
            this.Text = "frmIngresar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoReq;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbPriodidad;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrioridad;
    }
}