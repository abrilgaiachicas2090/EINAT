namespace Control_Calidad2023.Formularios
{
    partial class frmBusqueda_Muestra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbBusquedaMuestra = new System.Windows.Forms.GroupBox();
            this.txtBuscarLugarMuestra = new System.Windows.Forms.TextBox();
            this.txtBuscarFechaMuestra = new System.Windows.Forms.TextBox();
            this.lblLugarMuestra = new System.Windows.Forms.Label();
            this.lblFechaMuestra = new System.Windows.Forms.Label();
            this.dgvBusquedaMuestra = new System.Windows.Forms.DataGridView();
            this.id_Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar_muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbBusquedaMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(487, 197);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(406, 197);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gpbBusquedaMuestra
            // 
            this.gpbBusquedaMuestra.Controls.Add(this.txtBuscarLugarMuestra);
            this.gpbBusquedaMuestra.Controls.Add(this.txtBuscarFechaMuestra);
            this.gpbBusquedaMuestra.Controls.Add(this.lblLugarMuestra);
            this.gpbBusquedaMuestra.Controls.Add(this.lblFechaMuestra);
            this.gpbBusquedaMuestra.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusquedaMuestra.Location = new System.Drawing.Point(372, 28);
            this.gpbBusquedaMuestra.Name = "gpbBusquedaMuestra";
            this.gpbBusquedaMuestra.Size = new System.Drawing.Size(222, 154);
            this.gpbBusquedaMuestra.TabIndex = 13;
            this.gpbBusquedaMuestra.TabStop = false;
            this.gpbBusquedaMuestra.Text = "Busqueda de muestras";
            this.gpbBusquedaMuestra.Enter += new System.EventHandler(this.gpbBusquedaMuestra_Enter);
            // 
            // txtBuscarLugarMuestra
            // 
            this.txtBuscarLugarMuestra.Location = new System.Drawing.Point(5, 95);
            this.txtBuscarLugarMuestra.Name = "txtBuscarLugarMuestra";
            this.txtBuscarLugarMuestra.Size = new System.Drawing.Size(194, 23);
            this.txtBuscarLugarMuestra.TabIndex = 3;
            this.txtBuscarLugarMuestra.TextChanged += new System.EventHandler(this.txtBuscarLugarMuestra_TextChanged);
            this.txtBuscarLugarMuestra.Enter += new System.EventHandler(this.txtBuscarLugarMuestra_Enter);
            // 
            // txtBuscarFechaMuestra
            // 
            this.txtBuscarFechaMuestra.Location = new System.Drawing.Point(5, 48);
            this.txtBuscarFechaMuestra.Name = "txtBuscarFechaMuestra";
            this.txtBuscarFechaMuestra.Size = new System.Drawing.Size(195, 23);
            this.txtBuscarFechaMuestra.TabIndex = 2;
            this.txtBuscarFechaMuestra.TextChanged += new System.EventHandler(this.txtBuscarFechaMuestra_TextChanged);
            this.txtBuscarFechaMuestra.Enter += new System.EventHandler(this.txtBuscarFechaMuestra_Enter);
            // 
            // lblLugarMuestra
            // 
            this.lblLugarMuestra.AutoSize = true;
            this.lblLugarMuestra.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarMuestra.Location = new System.Drawing.Point(6, 79);
            this.lblLugarMuestra.Name = "lblLugarMuestra";
            this.lblLugarMuestra.Size = new System.Drawing.Size(113, 17);
            this.lblLugarMuestra.TabIndex = 1;
            this.lblLugarMuestra.Text = "Lugar de muestra:";
            // 
            // lblFechaMuestra
            // 
            this.lblFechaMuestra.AutoSize = true;
            this.lblFechaMuestra.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMuestra.Location = new System.Drawing.Point(6, 27);
            this.lblFechaMuestra.Name = "lblFechaMuestra";
            this.lblFechaMuestra.Size = new System.Drawing.Size(126, 17);
            this.lblFechaMuestra.TabIndex = 0;
            this.lblFechaMuestra.Text = "Fecha de la muestra:";
            // 
            // dgvBusquedaMuestra
            // 
            this.dgvBusquedaMuestra.AllowUserToAddRows = false;
            this.dgvBusquedaMuestra.AllowUserToDeleteRows = false;
            this.dgvBusquedaMuestra.AllowUserToResizeColumns = false;
            this.dgvBusquedaMuestra.AllowUserToResizeRows = false;
            this.dgvBusquedaMuestra.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusquedaMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaMuestra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Muestra,
            this.fecha,
            this.lugar_muestra});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBusquedaMuestra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBusquedaMuestra.Location = new System.Drawing.Point(31, 12);
            this.dgvBusquedaMuestra.MultiSelect = false;
            this.dgvBusquedaMuestra.Name = "dgvBusquedaMuestra";
            this.dgvBusquedaMuestra.ReadOnly = true;
            this.dgvBusquedaMuestra.RowHeadersVisible = false;
            this.dgvBusquedaMuestra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusquedaMuestra.Size = new System.Drawing.Size(305, 211);
            this.dgvBusquedaMuestra.TabIndex = 143;
            // 
            // id_Muestra
            // 
            this.id_Muestra.DataPropertyName = "id_Muestra";
            this.id_Muestra.HeaderText = "id_Muestra";
            this.id_Muestra.Name = "id_Muestra";
            this.id_Muestra.ReadOnly = true;
            this.id_Muestra.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha de la muestra";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // lugar_muestra
            // 
            this.lugar_muestra.DataPropertyName = "lugar_muestra";
            this.lugar_muestra.HeaderText = "Lugar de muestra";
            this.lugar_muestra.Name = "lugar_muestra";
            this.lugar_muestra.ReadOnly = true;
            this.lugar_muestra.Width = 150;
            // 
            // frmBusqueda_Muestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 274);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbBusquedaMuestra);
            this.Controls.Add(this.dgvBusquedaMuestra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusqueda_Muestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de muestras";
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            this.gpbBusquedaMuestra.ResumeLayout(false);
            this.gpbBusquedaMuestra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gpbBusquedaMuestra;
        private System.Windows.Forms.TextBox txtBuscarLugarMuestra;
        private System.Windows.Forms.TextBox txtBuscarFechaMuestra;
        private System.Windows.Forms.Label lblLugarMuestra;
        private System.Windows.Forms.Label lblFechaMuestra;
        private System.Windows.Forms.DataGridView dgvBusquedaMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar_muestra;
    }
}