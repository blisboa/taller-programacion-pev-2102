namespace sistema_req_v1
{
    partial class frmConsultar
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
            this.cmbRequerimiento = new System.Windows.Forms.ComboBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblRequerimiento = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.chkPendiente = new System.Windows.Forms.CheckBox();
            this.chkResuelto = new System.Windows.Forms.CheckBox();
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnResuelto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.lblEncontrados = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            this.gbxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRequerimiento
            // 
            this.cmbRequerimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequerimiento.FormattingEnabled = true;
            this.cmbRequerimiento.Location = new System.Drawing.Point(151, 17);
            this.cmbRequerimiento.Name = "cmbRequerimiento";
            this.cmbRequerimiento.Size = new System.Drawing.Size(121, 21);
            this.cmbRequerimiento.TabIndex = 0;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(151, 56);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(121, 21);
            this.cmbPrioridad.TabIndex = 1;
            // 
            // lblRequerimiento
            // 
            this.lblRequerimiento.AutoSize = true;
            this.lblRequerimiento.Location = new System.Drawing.Point(28, 20);
            this.lblRequerimiento.Name = "lblRequerimiento";
            this.lblRequerimiento.Size = new System.Drawing.Size(117, 13);
            this.lblRequerimiento.TabIndex = 2;
            this.lblRequerimiento.Text = "Tipo de Requerimiento:";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(28, 64);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(51, 13);
            this.lblPrioridad.TabIndex = 3;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // chkPendiente
            // 
            this.chkPendiente.AutoSize = true;
            this.chkPendiente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPendiente.Location = new System.Drawing.Point(31, 101);
            this.chkPendiente.Name = "chkPendiente";
            this.chkPendiente.Size = new System.Drawing.Size(74, 17);
            this.chkPendiente.TabIndex = 4;
            this.chkPendiente.Text = "Pendiente";
            this.chkPendiente.UseVisualStyleBackColor = true;
            // 
            // chkResuelto
            // 
            this.chkResuelto.AutoSize = true;
            this.chkResuelto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkResuelto.Location = new System.Drawing.Point(159, 103);
            this.chkResuelto.Name = "chkResuelto";
            this.chkResuelto.Size = new System.Drawing.Size(68, 17);
            this.chkResuelto.TabIndex = 5;
            this.chkResuelto.Text = "Resuelto";
            this.chkResuelto.UseVisualStyleBackColor = true;
            // 
            // dgvReq
            // 
            this.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq.Location = new System.Drawing.Point(30, 194);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.Size = new System.Drawing.Size(622, 167);
            this.dgvReq.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(314, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnResuelto
            // 
            this.btnResuelto.Location = new System.Drawing.Point(30, 378);
            this.btnResuelto.Name = "btnResuelto";
            this.btnResuelto.Size = new System.Drawing.Size(117, 23);
            this.btnResuelto.TabIndex = 8;
            this.btnResuelto.Text = "Marcar como resuelto";
            this.btnResuelto.UseVisualStyleBackColor = true;
            this.btnResuelto.Click += new System.EventHandler(this.btnResuelto_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(217, 378);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.cmbPrioridad);
            this.gbxFiltro.Controls.Add(this.cmbRequerimiento);
            this.gbxFiltro.Controls.Add(this.lblRequerimiento);
            this.gbxFiltro.Controls.Add(this.lblPrioridad);
            this.gbxFiltro.Controls.Add(this.chkPendiente);
            this.gbxFiltro.Controls.Add(this.chkResuelto);
            this.gbxFiltro.Location = new System.Drawing.Point(30, 22);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(278, 139);
            this.gbxFiltro.TabIndex = 10;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Filtro de la búsqueda:";
            // 
            // lblEncontrados
            // 
            this.lblEncontrados.AutoSize = true;
            this.lblEncontrados.Location = new System.Drawing.Point(30, 178);
            this.lblEncontrados.Name = "lblEncontrados";
            this.lblEncontrados.Size = new System.Drawing.Size(145, 13);
            this.lblEncontrados.TabIndex = 11;
            this.lblEncontrados.Text = "Requerimientos encontrados:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(329, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 424);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblEncontrados);
            this.Controls.Add(this.gbxFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnResuelto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvReq);
            this.Name = "frmConsultar";
            this.Text = "Consultar Requerimientos";
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRequerimiento;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblRequerimiento;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.CheckBox chkPendiente;
        private System.Windows.Forms.CheckBox chkResuelto;
        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnResuelto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.Label lblEncontrados;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}