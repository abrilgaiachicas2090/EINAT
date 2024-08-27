namespace Control_Calidad_2023.Formularios
{
    partial class frmAnalisis_detalles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalisis_detalles));
            this.gpbBusquedas = new System.Windows.Forms.GroupBox();
            this.txtBuscarAnalisis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAnalisis_detalles = new System.Windows.Forms.DataGridView();
            this.id_AnalisisDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ResultadoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Analisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResultadoAnalisis = new System.Windows.Forms.Label();
            this.lblanalisis = new System.Windows.Forms.Label();
            this.cboAnalisis = new System.Windows.Forms.ComboBox();
            this.cboResultadoAnalisis = new System.Windows.Forms.ComboBox();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.gpbBusquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis_detalles)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBusquedas
            // 
            this.gpbBusquedas.Controls.Add(this.txtBuscarAnalisis);
            this.gpbBusquedas.Controls.Add(this.label4);
            this.gpbBusquedas.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusquedas.Location = new System.Drawing.Point(9, 184);
            this.gpbBusquedas.Name = "gpbBusquedas";
            this.gpbBusquedas.Size = new System.Drawing.Size(420, 53);
            this.gpbBusquedas.TabIndex = 146;
            this.gpbBusquedas.TabStop = false;
            this.gpbBusquedas.Text = "Búsqueda :";
            this.gpbBusquedas.Enter += new System.EventHandler(this.gpbBusquedas_Enter);
            // 
            // txtBuscarAnalisis
            // 
            this.txtBuscarAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAnalisis.Location = new System.Drawing.Point(110, 24);
            this.txtBuscarAnalisis.Name = "txtBuscarAnalisis";
            this.txtBuscarAnalisis.Size = new System.Drawing.Size(195, 20);
            this.txtBuscarAnalisis.TabIndex = 47;
            this.txtBuscarAnalisis.TextChanged += new System.EventHandler(this.txtBuscarAnalisis_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Buscar Analisis:";
            // 
            // dgvAnalisis_detalles
            // 
            this.dgvAnalisis_detalles.AllowUserToAddRows = false;
            this.dgvAnalisis_detalles.AllowUserToDeleteRows = false;
            this.dgvAnalisis_detalles.AllowUserToResizeColumns = false;
            this.dgvAnalisis_detalles.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAnalisis_detalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalisis_detalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAnalisis_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAnalisis_detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_AnalisisDetalles,
            this.id_ResultadoAnalisis,
            this.id_Analisis,
            this.activo});
            this.dgvAnalisis_detalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnalisis_detalles.Location = new System.Drawing.Point(9, 6);
            this.dgvAnalisis_detalles.MultiSelect = false;
            this.dgvAnalisis_detalles.Name = "dgvAnalisis_detalles";
            this.dgvAnalisis_detalles.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalisis_detalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAnalisis_detalles.RowHeadersVisible = false;
            this.dgvAnalisis_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnalisis_detalles.Size = new System.Drawing.Size(254, 167);
            this.dgvAnalisis_detalles.StandardTab = true;
            this.dgvAnalisis_detalles.TabIndex = 143;
            this.dgvAnalisis_detalles.SelectionChanged += new System.EventHandler(this.dgvAnalisis_detalles_SelectionChanged);
            // 
            // id_AnalisisDetalles
            // 
            this.id_AnalisisDetalles.DataPropertyName = "id_AnalisisDetalles";
            this.id_AnalisisDetalles.HeaderText = "Analisis de detalles";
            this.id_AnalisisDetalles.Name = "id_AnalisisDetalles";
            this.id_AnalisisDetalles.ReadOnly = true;
            this.id_AnalisisDetalles.Visible = false;
            // 
            // id_ResultadoAnalisis
            // 
            this.id_ResultadoAnalisis.DataPropertyName = "id_ResultadoAnalisis";
            this.id_ResultadoAnalisis.HeaderText = "Resultado del analisis";
            this.id_ResultadoAnalisis.Name = "id_ResultadoAnalisis";
            this.id_ResultadoAnalisis.ReadOnly = true;
            this.id_ResultadoAnalisis.Width = 150;
            // 
            // id_Analisis
            // 
            this.id_Analisis.DataPropertyName = "id_Analisis";
            this.id_Analisis.HeaderText = "Analisis";
            this.id_Analisis.Name = "id_Analisis";
            this.id_Analisis.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            // 
            // lblResultadoAnalisis
            // 
            this.lblResultadoAnalisis.AutoSize = true;
            this.lblResultadoAnalisis.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoAnalisis.Location = new System.Drawing.Point(275, 16);
            this.lblResultadoAnalisis.Name = "lblResultadoAnalisis";
            this.lblResultadoAnalisis.Size = new System.Drawing.Size(139, 17);
            this.lblResultadoAnalisis.TabIndex = 149;
            this.lblResultadoAnalisis.Text = "Resultado de análisis :";
            // 
            // lblanalisis
            // 
            this.lblanalisis.AutoSize = true;
            this.lblanalisis.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanalisis.Location = new System.Drawing.Point(281, 62);
            this.lblanalisis.Name = "lblanalisis";
            this.lblanalisis.Size = new System.Drawing.Size(63, 17);
            this.lblanalisis.TabIndex = 150;
            this.lblanalisis.Text = "Análisis :";
            // 
            // cboAnalisis
            // 
            this.cboAnalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnalisis.FormattingEnabled = true;
            this.cboAnalisis.Location = new System.Drawing.Point(276, 80);
            this.cboAnalisis.Name = "cboAnalisis";
            this.cboAnalisis.Size = new System.Drawing.Size(160, 21);
            this.cboAnalisis.TabIndex = 151;
            // 
            // cboResultadoAnalisis
            // 
            this.cboResultadoAnalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResultadoAnalisis.FormattingEnabled = true;
            this.cboResultadoAnalisis.Location = new System.Drawing.Point(277, 35);
            this.cboResultadoAnalisis.Name = "cboResultadoAnalisis";
            this.cboResultadoAnalisis.Size = new System.Drawing.Size(159, 21);
            this.cboResultadoAnalisis.TabIndex = 153;
            this.cboResultadoAnalisis.SelectedIndexChanged += new System.EventHandler(this.cboResultadoAnalisis_SelectedIndexChanged);
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPanel.Controls.Add(this.btnBuscar);
            this.btnPanel.Controls.Add(this.btnBorrar);
            this.btnPanel.Controls.Add(this.btnSalir);
            this.btnPanel.Controls.Add(this.btnCancelar);
            this.btnPanel.Controls.Add(this.btnAceptar);
            this.btnPanel.Controls.Add(this.btnModificar);
            this.btnPanel.Controls.Add(this.btnAgregar);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 251);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(480, 58);
            this.btnPanel.TabIndex = 142;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(165, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(114, 8);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 40);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btnBorrar, "Borrar");
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(421, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip7.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(333, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip6.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(282, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(63, 8);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(45, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btnModificar, "Editar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(12, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAnalisis_detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 309);
            this.Controls.Add(this.cboResultadoAnalisis);
            this.Controls.Add(this.cboAnalisis);
            this.Controls.Add(this.lblanalisis);
            this.Controls.Add(this.lblResultadoAnalisis);
            this.Controls.Add(this.gpbBusquedas);
            this.Controls.Add(this.dgvAnalisis_detalles);
            this.Controls.Add(this.btnPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnalisis_detalles";
            this.Text = "Detalles de los análisis";
            this.Load += new System.EventHandler(this.frmAnalisis_detalles_Load);
            this.gpbBusquedas.ResumeLayout(false);
            this.gpbBusquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis_detalles)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBusquedas;
        private System.Windows.Forms.TextBox txtBuscarAnalisis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAnalisis_detalles;
        private System.Windows.Forms.Label lblResultadoAnalisis;
        private System.Windows.Forms.Label lblanalisis;
        private System.Windows.Forms.ComboBox cboAnalisis;
        private System.Windows.Forms.ComboBox cboResultadoAnalisis;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_AnalisisDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ResultadoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Analisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}