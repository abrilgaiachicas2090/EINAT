namespace Control_Calidad_2023.Formularios
{
    partial class frmListadoReclamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoReclamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListadoReclamos = new System.Windows.Forms.DataGridView();
            this.gpbBusquedas = new System.Windows.Forms.GroupBox();
            this.txtEstadoReclamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCodCliente = new System.Windows.Forms.TextBox();
            this.lblBuscarCodCliente = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboEstadoReclamo = new System.Windows.Forms.ComboBox();
            this.lblEstadoReclamo = new System.Windows.Forms.Label();
            this.id_ListadoReclamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_EstadoReclamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Reclamos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_TipoReclamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiporeclamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reclamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoReclamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoReclamos)).BeginInit();
            this.gpbBusquedas.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoReclamos
            // 
            this.dgvListadoReclamos.AllowUserToAddRows = false;
            this.dgvListadoReclamos.AllowUserToDeleteRows = false;
            this.dgvListadoReclamos.AllowUserToResizeColumns = false;
            this.dgvListadoReclamos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListadoReclamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoReclamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListadoReclamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ListadoReclamo,
            this.id_EstadoReclamo,
            this.id_Reclamos,
            this.id_TipoReclamo,
            this.tiporeclamo,
            this.reclamo,
            this.fecha,
            this.hora,
            this.cod_cliente,
            this.EstadoReclamo,
            this.activo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoReclamos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListadoReclamos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoReclamos.Location = new System.Drawing.Point(12, 12);
            this.dgvListadoReclamos.MultiSelect = false;
            this.dgvListadoReclamos.Name = "dgvListadoReclamos";
            this.dgvListadoReclamos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoReclamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListadoReclamos.RowHeadersVisible = false;
            this.dgvListadoReclamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoReclamos.Size = new System.Drawing.Size(654, 167);
            this.dgvListadoReclamos.StandardTab = true;
            this.dgvListadoReclamos.TabIndex = 104;
            this.dgvListadoReclamos.SelectionChanged += new System.EventHandler(this.dgvListadoReclamos_SelectionChanged);
            // 
            // gpbBusquedas
            // 
            this.gpbBusquedas.Controls.Add(this.txtEstadoReclamo);
            this.gpbBusquedas.Controls.Add(this.label1);
            this.gpbBusquedas.Controls.Add(this.txtBuscarCodCliente);
            this.gpbBusquedas.Controls.Add(this.lblBuscarCodCliente);
            this.gpbBusquedas.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusquedas.Location = new System.Drawing.Point(24, 199);
            this.gpbBusquedas.Name = "gpbBusquedas";
            this.gpbBusquedas.Size = new System.Drawing.Size(333, 76);
            this.gpbBusquedas.TabIndex = 107;
            this.gpbBusquedas.TabStop = false;
            this.gpbBusquedas.Text = "Búsqueda :";
            // 
            // txtEstadoReclamo
            // 
            this.txtEstadoReclamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoReclamo.Location = new System.Drawing.Point(130, 45);
            this.txtEstadoReclamo.Name = "txtEstadoReclamo";
            this.txtEstadoReclamo.Size = new System.Drawing.Size(195, 20);
            this.txtEstadoReclamo.TabIndex = 51;
            this.txtEstadoReclamo.TextChanged += new System.EventHandler(this.txtEstadoReclamo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Estado del reclamo:";
            // 
            // txtBuscarCodCliente
            // 
            this.txtBuscarCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCodCliente.Location = new System.Drawing.Point(85, 19);
            this.txtBuscarCodCliente.Name = "txtBuscarCodCliente";
            this.txtBuscarCodCliente.Size = new System.Drawing.Size(195, 20);
            this.txtBuscarCodCliente.TabIndex = 49;
            this.txtBuscarCodCliente.TextChanged += new System.EventHandler(this.txtBuscarCodCliente_TextChanged);
            // 
            // lblBuscarCodCliente
            // 
            this.lblBuscarCodCliente.AutoSize = true;
            this.lblBuscarCodCliente.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCodCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuscarCodCliente.Location = new System.Drawing.Point(7, 19);
            this.lblBuscarCodCliente.Name = "lblBuscarCodCliente";
            this.lblBuscarCodCliente.Size = new System.Drawing.Size(76, 17);
            this.lblBuscarCodCliente.TabIndex = 48;
            this.lblBuscarCodCliente.Text = "Cod cliente:";
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPanel.Controls.Add(this.btnBuscar);
            this.btnPanel.Controls.Add(this.btnSalir);
            this.btnPanel.Controls.Add(this.btnCancelar);
            this.btnPanel.Controls.Add(this.btnAceptar);
            this.btnPanel.Controls.Add(this.btnModificar);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 281);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(820, 58);
            this.btnPanel.TabIndex = 108;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(162, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(672, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(437, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(386, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(106, 8);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(45, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnModificar, "Editar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cboEstadoReclamo
            // 
            this.cboEstadoReclamo.FormattingEnabled = true;
            this.cboEstadoReclamo.Location = new System.Drawing.Point(685, 40);
            this.cboEstadoReclamo.Name = "cboEstadoReclamo";
            this.cboEstadoReclamo.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoReclamo.TabIndex = 118;
            // 
            // lblEstadoReclamo
            // 
            this.lblEstadoReclamo.AutoSize = true;
            this.lblEstadoReclamo.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoReclamo.Location = new System.Drawing.Point(682, 24);
            this.lblEstadoReclamo.Name = "lblEstadoReclamo";
            this.lblEstadoReclamo.Size = new System.Drawing.Size(114, 16);
            this.lblEstadoReclamo.TabIndex = 117;
            this.lblEstadoReclamo.Text = "Estado del reclamo:";
            // 
            // id_ListadoReclamo
            // 
            this.id_ListadoReclamo.DataPropertyName = "id_ListadoReclamos";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ListadoReclamo.DefaultCellStyle = dataGridViewCellStyle3;
            this.id_ListadoReclamo.HeaderText = "id_ListadoReclamos";
            this.id_ListadoReclamo.Name = "id_ListadoReclamo";
            this.id_ListadoReclamo.ReadOnly = true;
            this.id_ListadoReclamo.Visible = false;
            // 
            // id_EstadoReclamo
            // 
            this.id_EstadoReclamo.DataPropertyName = "id_EstadoReclamo";
            this.id_EstadoReclamo.HeaderText = "id_EstadoReclamo";
            this.id_EstadoReclamo.Name = "id_EstadoReclamo";
            this.id_EstadoReclamo.ReadOnly = true;
            this.id_EstadoReclamo.Visible = false;
            // 
            // id_Reclamos
            // 
            this.id_Reclamos.DataPropertyName = "id_Reclamos";
            this.id_Reclamos.HeaderText = "id_Reclamos";
            this.id_Reclamos.Name = "id_Reclamos";
            this.id_Reclamos.ReadOnly = true;
            this.id_Reclamos.Visible = false;
            // 
            // id_TipoReclamo
            // 
            this.id_TipoReclamo.DataPropertyName = "id_TipoReclamo";
            this.id_TipoReclamo.HeaderText = "id_TipoReclamo";
            this.id_TipoReclamo.Name = "id_TipoReclamo";
            this.id_TipoReclamo.ReadOnly = true;
            this.id_TipoReclamo.Visible = false;
            this.id_TipoReclamo.Width = 150;
            // 
            // tiporeclamo
            // 
            this.tiporeclamo.DataPropertyName = "tiporeclamo";
            this.tiporeclamo.HeaderText = "Tipo de reclamo";
            this.tiporeclamo.Name = "tiporeclamo";
            this.tiporeclamo.ReadOnly = true;
            // 
            // reclamo
            // 
            this.reclamo.DataPropertyName = "reclamo";
            this.reclamo.HeaderText = "Descripcion del reclamo";
            this.reclamo.Name = "reclamo";
            this.reclamo.ReadOnly = true;
            this.reclamo.Width = 130;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // cod_cliente
            // 
            this.cod_cliente.DataPropertyName = "cod_cliente";
            this.cod_cliente.HeaderText = "Cod_cliente";
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.ReadOnly = true;
            // 
            // EstadoReclamo
            // 
            this.EstadoReclamo.DataPropertyName = "EstadoReclamo";
            this.EstadoReclamo.HeaderText = "Estado del reclamo";
            this.EstadoReclamo.Name = "EstadoReclamo";
            this.EstadoReclamo.ReadOnly = true;
            this.EstadoReclamo.Width = 120;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            // 
            // frmListadoReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 339);
            this.Controls.Add(this.cboEstadoReclamo);
            this.Controls.Add(this.lblEstadoReclamo);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.gpbBusquedas);
            this.Controls.Add(this.dgvListadoReclamos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoReclamos";
            this.Text = "frmListadoReclamos";
            this.Load += new System.EventHandler(this.frmListadoReclamos_Load);
            this.TextChanged += new System.EventHandler(this.frmListadoReclamos_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoReclamos)).EndInit();
            this.gpbBusquedas.ResumeLayout(false);
            this.gpbBusquedas.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoReclamos;
        private System.Windows.Forms.GroupBox gpbBusquedas;
        private System.Windows.Forms.TextBox txtBuscarCodCliente;
        private System.Windows.Forms.Label lblBuscarCodCliente;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtEstadoReclamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstadoReclamo;
        private System.Windows.Forms.Label lblEstadoReclamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ListadoReclamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_EstadoReclamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Reclamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_TipoReclamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiporeclamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn reclamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoReclamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}