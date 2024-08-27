namespace Control_Calidad_2023.Formularios
{
    partial class frmNombreAnalisis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNombreAnalisis));
            this.gpbBusquedas = new System.Windows.Forms.GroupBox();
            this.txtBuscarNAnalisis = new System.Windows.Forms.TextBox();
            this.lblNAnalisis = new System.Windows.Forms.Label();
            this.txtNombreAnalisis = new System.Windows.Forms.TextBox();
            this.lblNombreAnalisis = new System.Windows.Forms.Label();
            this.dgvNomAnalisis = new System.Windows.Forms.DataGridView();
            this.id_NombreAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_TipoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipoAnalisis = new System.Windows.Forms.Label();
            this.cboTipoAnalisis = new System.Windows.Forms.ComboBox();
            this.Agregar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.gpbBusquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomAnalisis)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBusquedas
            // 
            this.gpbBusquedas.Controls.Add(this.txtBuscarNAnalisis);
            this.gpbBusquedas.Controls.Add(this.lblNAnalisis);
            this.gpbBusquedas.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusquedas.Location = new System.Drawing.Point(12, 191);
            this.gpbBusquedas.Name = "gpbBusquedas";
            this.gpbBusquedas.Size = new System.Drawing.Size(420, 53);
            this.gpbBusquedas.TabIndex = 111;
            this.gpbBusquedas.TabStop = false;
            this.gpbBusquedas.Text = "Búsqueda :";
            // 
            // txtBuscarNAnalisis
            // 
            this.txtBuscarNAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNAnalisis.Location = new System.Drawing.Point(115, 24);
            this.txtBuscarNAnalisis.Name = "txtBuscarNAnalisis";
            this.txtBuscarNAnalisis.Size = new System.Drawing.Size(195, 20);
            this.txtBuscarNAnalisis.TabIndex = 47;
            this.txtBuscarNAnalisis.TextChanged += new System.EventHandler(this.txtBuscarNAnalisis_TextChanged);
            // 
            // lblNAnalisis
            // 
            this.lblNAnalisis.AutoSize = true;
            this.lblNAnalisis.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNAnalisis.Location = new System.Drawing.Point(6, 27);
            this.lblNAnalisis.Name = "lblNAnalisis";
            this.lblNAnalisis.Size = new System.Drawing.Size(110, 17);
            this.lblNAnalisis.TabIndex = 46;
            this.lblNAnalisis.Text = "Nombre Análisis:";
            // 
            // txtNombreAnalisis
            // 
            this.txtNombreAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAnalisis.Location = new System.Drawing.Point(389, 31);
            this.txtNombreAnalisis.Name = "txtNombreAnalisis";
            this.txtNombreAnalisis.Size = new System.Drawing.Size(158, 20);
            this.txtNombreAnalisis.TabIndex = 110;
            // 
            // lblNombreAnalisis
            // 
            this.lblNombreAnalisis.AutoSize = true;
            this.lblNombreAnalisis.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreAnalisis.Location = new System.Drawing.Point(387, 12);
            this.lblNombreAnalisis.Name = "lblNombreAnalisis";
            this.lblNombreAnalisis.Size = new System.Drawing.Size(60, 17);
            this.lblNombreAnalisis.TabIndex = 109;
            this.lblNombreAnalisis.Text = "Análisis:";
            // 
            // dgvNomAnalisis
            // 
            this.dgvNomAnalisis.AllowUserToAddRows = false;
            this.dgvNomAnalisis.AllowUserToDeleteRows = false;
            this.dgvNomAnalisis.AllowUserToResizeColumns = false;
            this.dgvNomAnalisis.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNomAnalisis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNomAnalisis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNomAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNomAnalisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_NombreAnalisis,
            this.NombreAnalisis,
            this.activo,
            this.id_TipoAnalisis});
            this.dgvNomAnalisis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNomAnalisis.Location = new System.Drawing.Point(12, 12);
            this.dgvNomAnalisis.MultiSelect = false;
            this.dgvNomAnalisis.Name = "dgvNomAnalisis";
            this.dgvNomAnalisis.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNomAnalisis.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNomAnalisis.RowHeadersVisible = false;
            this.dgvNomAnalisis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNomAnalisis.Size = new System.Drawing.Size(369, 167);
            this.dgvNomAnalisis.StandardTab = true;
            this.dgvNomAnalisis.TabIndex = 108;
            this.dgvNomAnalisis.SelectionChanged += new System.EventHandler(this.dgvNomAnalisis_SelectionChanged);
            // 
            // id_NombreAnalisis
            // 
            this.id_NombreAnalisis.DataPropertyName = "id_NombreAnalisis";
            this.id_NombreAnalisis.HeaderText = "idNobreAnalisis";
            this.id_NombreAnalisis.Name = "id_NombreAnalisis";
            this.id_NombreAnalisis.ReadOnly = true;
            this.id_NombreAnalisis.Visible = false;
            // 
            // NombreAnalisis
            // 
            this.NombreAnalisis.DataPropertyName = "nombreanalisis";
            this.NombreAnalisis.HeaderText = "Nombre Analisis";
            this.NombreAnalisis.MinimumWidth = 4;
            this.NombreAnalisis.Name = "NombreAnalisis";
            this.NombreAnalisis.ReadOnly = true;
            this.NombreAnalisis.Width = 260;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            // 
            // id_TipoAnalisis
            // 
            this.id_TipoAnalisis.DataPropertyName = "id_TipoAnalisis";
            this.id_TipoAnalisis.HeaderText = "Tipo análisis";
            this.id_TipoAnalisis.Name = "id_TipoAnalisis";
            this.id_TipoAnalisis.ReadOnly = true;
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
            this.btnPanel.Location = new System.Drawing.Point(0, 259);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(570, 58);
            this.btnPanel.TabIndex = 107;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(165, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btnBuscar, "Buscar");
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
            this.toolTip2.SetToolTip(this.btnBorrar, "Borrar");
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(504, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip6.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(375, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(324, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btnAceptar, "Aceptar");
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
            this.toolTip1.SetToolTip(this.btnModificar, "Editar");
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
            this.Agregar.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTipoAnalisis
            // 
            this.lblTipoAnalisis.AutoSize = true;
            this.lblTipoAnalisis.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnalisis.Location = new System.Drawing.Point(390, 65);
            this.lblTipoAnalisis.Name = "lblTipoAnalisis";
            this.lblTipoAnalisis.Size = new System.Drawing.Size(107, 17);
            this.lblTipoAnalisis.TabIndex = 135;
            this.lblTipoAnalisis.Text = "Tipo de Análisis:";
            // 
            // cboTipoAnalisis
            // 
            this.cboTipoAnalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAnalisis.FormattingEnabled = true;
            this.cboTipoAnalisis.Location = new System.Drawing.Point(389, 85);
            this.cboTipoAnalisis.Name = "cboTipoAnalisis";
            this.cboTipoAnalisis.Size = new System.Drawing.Size(145, 21);
            this.cboTipoAnalisis.TabIndex = 134;
            // 
            // frmNombreAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 317);
            this.Controls.Add(this.lblTipoAnalisis);
            this.Controls.Add(this.cboTipoAnalisis);
            this.Controls.Add(this.gpbBusquedas);
            this.Controls.Add(this.txtNombreAnalisis);
            this.Controls.Add(this.lblNombreAnalisis);
            this.Controls.Add(this.dgvNomAnalisis);
            this.Controls.Add(this.btnPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNombreAnalisis";
            this.Text = "frmNombreAnalisis";
            this.Load += new System.EventHandler(this.frmNombreAnalisis_Load);
            this.gpbBusquedas.ResumeLayout(false);
            this.gpbBusquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomAnalisis)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBusquedas;
        private System.Windows.Forms.TextBox txtBuscarNAnalisis;
        private System.Windows.Forms.Label lblNAnalisis;
        private System.Windows.Forms.TextBox txtNombreAnalisis;
        private System.Windows.Forms.Label lblNombreAnalisis;
        private System.Windows.Forms.DataGridView dgvNomAnalisis;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTipoAnalisis;
        private System.Windows.Forms.ComboBox cboTipoAnalisis;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_NombreAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_TipoAnalisis;
    }
}