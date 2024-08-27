namespace Control_Calidad2023.Formularios
{
    partial class frmBuscarMuestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarMuestra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbBusquedadeMuestras = new System.Windows.Forms.GroupBox();
            this.txtBuscarMuestra = new System.Windows.Forms.TextBox();
            this.lblLugarMuestra = new System.Windows.Forms.Label();
            this.txtBuscarFecha = new System.Windows.Forms.TextBox();
            this.lblFechaMuestra = new System.Windows.Forms.Label();
            this.dgvBusquedaMuestra = new System.Windows.Forms.DataGridView();
            this.id_Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar_muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_LugarMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar_aleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Analisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ResultadoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_AnalisisDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_TipoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoanalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbBusquedadeMuestras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(720, 173);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(660, 173);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gpbBusquedadeMuestras
            // 
            this.gpbBusquedadeMuestras.Controls.Add(this.txtBuscarMuestra);
            this.gpbBusquedadeMuestras.Controls.Add(this.lblLugarMuestra);
            this.gpbBusquedadeMuestras.Controls.Add(this.txtBuscarFecha);
            this.gpbBusquedadeMuestras.Controls.Add(this.lblFechaMuestra);
            this.gpbBusquedadeMuestras.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusquedadeMuestras.Location = new System.Drawing.Point(604, 12);
            this.gpbBusquedadeMuestras.Name = "gpbBusquedadeMuestras";
            this.gpbBusquedadeMuestras.Size = new System.Drawing.Size(222, 155);
            this.gpbBusquedadeMuestras.TabIndex = 5;
            this.gpbBusquedadeMuestras.TabStop = false;
            this.gpbBusquedadeMuestras.Text = "Busqueda de Muestra";
            // 
            // txtBuscarMuestra
            // 
            this.txtBuscarMuestra.Location = new System.Drawing.Point(7, 104);
            this.txtBuscarMuestra.Name = "txtBuscarMuestra";
            this.txtBuscarMuestra.Size = new System.Drawing.Size(200, 23);
            this.txtBuscarMuestra.TabIndex = 5;
            this.txtBuscarMuestra.TextChanged += new System.EventHandler(this.txtBuscarMuestra_TextChanged);
            // 
            // lblLugarMuestra
            // 
            this.lblLugarMuestra.AutoSize = true;
            this.lblLugarMuestra.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarMuestra.Location = new System.Drawing.Point(7, 86);
            this.lblLugarMuestra.Name = "lblLugarMuestra";
            this.lblLugarMuestra.Size = new System.Drawing.Size(113, 17);
            this.lblLugarMuestra.TabIndex = 4;
            this.lblLugarMuestra.Text = "Lugar de muestra:";
            // 
            // txtBuscarFecha
            // 
            this.txtBuscarFecha.Location = new System.Drawing.Point(6, 51);
            this.txtBuscarFecha.Name = "txtBuscarFecha";
            this.txtBuscarFecha.Size = new System.Drawing.Size(200, 23);
            this.txtBuscarFecha.TabIndex = 3;
            this.txtBuscarFecha.TextChanged += new System.EventHandler(this.txtBuscarLugardeMuestra_TextChanged);
            // 
            // lblFechaMuestra
            // 
            this.lblFechaMuestra.AutoSize = true;
            this.lblFechaMuestra.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMuestra.Location = new System.Drawing.Point(6, 33);
            this.lblFechaMuestra.Name = "lblFechaMuestra";
            this.lblFechaMuestra.Size = new System.Drawing.Size(112, 17);
            this.lblFechaMuestra.TabIndex = 1;
            this.lblFechaMuestra.Text = "Fecha de muestra:";
            // 
            // dgvBusquedaMuestra
            // 
            this.dgvBusquedaMuestra.AllowUserToAddRows = false;
            this.dgvBusquedaMuestra.AllowUserToDeleteRows = false;
            this.dgvBusquedaMuestra.AllowUserToResizeColumns = false;
            this.dgvBusquedaMuestra.AllowUserToResizeRows = false;
            this.dgvBusquedaMuestra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusquedaMuestra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusquedaMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaMuestra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Muestra,
            this.lugar_muestra,
            this.id_LugarMuestra,
            this.lugar_aleatorio,
            this.sector,
            this.fecha,
            this.Hora,
            this.id_Analisis,
            this.id_ResultadoAnalisis,
            this.id_AnalisisDetalles,
            this.id_TipoAnalisis,
            this.tipoanalisis});
            this.dgvBusquedaMuestra.Location = new System.Drawing.Point(1, 1);
            this.dgvBusquedaMuestra.Name = "dgvBusquedaMuestra";
            this.dgvBusquedaMuestra.ReadOnly = true;
            this.dgvBusquedaMuestra.RowHeadersVisible = false;
            this.dgvBusquedaMuestra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusquedaMuestra.Size = new System.Drawing.Size(535, 237);
            this.dgvBusquedaMuestra.TabIndex = 4;
            // 
            // id_Muestra
            // 
            this.id_Muestra.DataPropertyName = "id_Muestra";
            this.id_Muestra.HeaderText = "id_Muestra";
            this.id_Muestra.Name = "id_Muestra";
            this.id_Muestra.ReadOnly = true;
            this.id_Muestra.Visible = false;
            // 
            // lugar_muestra
            // 
            this.lugar_muestra.DataPropertyName = "lugar_muestra";
            this.lugar_muestra.HeaderText = "Lugar muestra";
            this.lugar_muestra.Name = "lugar_muestra";
            this.lugar_muestra.ReadOnly = true;
            // 
            // id_LugarMuestra
            // 
            this.id_LugarMuestra.DataPropertyName = "id_LugarMuestra";
            this.id_LugarMuestra.HeaderText = "id_LugarMuestra";
            this.id_LugarMuestra.Name = "id_LugarMuestra";
            this.id_LugarMuestra.ReadOnly = true;
            this.id_LugarMuestra.Visible = false;
            // 
            // lugar_aleatorio
            // 
            this.lugar_aleatorio.DataPropertyName = "lugar_aleatorio";
            this.lugar_aleatorio.HeaderText = "Lugar aleatorio";
            this.lugar_aleatorio.Name = "lugar_aleatorio";
            this.lugar_aleatorio.ReadOnly = true;
            // 
            // sector
            // 
            this.sector.DataPropertyName = "sector";
            this.sector.HeaderText = "Sector";
            this.sector.Name = "sector";
            this.sector.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // id_Analisis
            // 
            this.id_Analisis.DataPropertyName = "id_Analisis";
            this.id_Analisis.HeaderText = "id_Analisis";
            this.id_Analisis.Name = "id_Analisis";
            this.id_Analisis.ReadOnly = true;
            this.id_Analisis.Visible = false;
            // 
            // id_ResultadoAnalisis
            // 
            this.id_ResultadoAnalisis.DataPropertyName = "id_ResultadoAnalisis";
            this.id_ResultadoAnalisis.HeaderText = "id_ResultadoAnalisis";
            this.id_ResultadoAnalisis.Name = "id_ResultadoAnalisis";
            this.id_ResultadoAnalisis.ReadOnly = true;
            this.id_ResultadoAnalisis.Visible = false;
            // 
            // id_AnalisisDetalles
            // 
            this.id_AnalisisDetalles.DataPropertyName = "id_AnalisisDetalles";
            this.id_AnalisisDetalles.HeaderText = "id_AnalisisDetalles";
            this.id_AnalisisDetalles.Name = "id_AnalisisDetalles";
            this.id_AnalisisDetalles.ReadOnly = true;
            this.id_AnalisisDetalles.Visible = false;
            // 
            // id_TipoAnalisis
            // 
            this.id_TipoAnalisis.DataPropertyName = "id_TipoAnalisis";
            this.id_TipoAnalisis.HeaderText = "id_TipoAnalisis";
            this.id_TipoAnalisis.Name = "id_TipoAnalisis";
            this.id_TipoAnalisis.ReadOnly = true;
            this.id_TipoAnalisis.Visible = false;
            // 
            // tipoanalisis
            // 
            this.tipoanalisis.DataPropertyName = "tipoanalisis";
            this.tipoanalisis.HeaderText = "Tipo de análisis";
            this.tipoanalisis.Name = "tipoanalisis";
            this.tipoanalisis.ReadOnly = true;
            this.tipoanalisis.Visible = false;
            // 
            // frmBuscarMuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 258);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbBusquedadeMuestras);
            this.Controls.Add(this.dgvBusquedaMuestra);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarMuestra";
            this.Text = "frmBuscarMuestra";
            this.Load += new System.EventHandler(this.frmBuscarMuestra_Load);
            this.gpbBusquedadeMuestras.ResumeLayout(false);
            this.gpbBusquedadeMuestras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gpbBusquedadeMuestras;
        private System.Windows.Forms.TextBox txtBuscarFecha;
        private System.Windows.Forms.Label lblFechaMuestra;
        private System.Windows.Forms.DataGridView dgvBusquedaMuestra;
        private System.Windows.Forms.TextBox txtBuscarMuestra;
        private System.Windows.Forms.Label lblLugarMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar_muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_LugarMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar_aleatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Analisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ResultadoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_AnalisisDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_TipoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoanalisis;
    }
}