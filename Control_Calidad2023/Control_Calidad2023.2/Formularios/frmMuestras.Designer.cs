namespace Control_Calidad2023.Formularios
{
    partial class frmMuestras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuestras));
            this.gpbBusquedas = new System.Windows.Forms.GroupBox();
            this.txtBuscarLugarDeMuestra = new System.Windows.Forms.TextBox();
            this.lblBuscarLugarMuestra = new System.Windows.Forms.Label();
            this.lblLugarMuestra = new System.Windows.Forms.Label();
            this.dgvMuestras = new System.Windows.Forms.DataGridView();
            this.id_Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_TipoAgua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAgua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lugar_muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar_muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar_aleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFechayHora = new System.Windows.Forms.Label();
            this.cboLugarMuestra = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.Agregar = new System.Windows.Forms.ToolTip(this.components);
            this.Modificar = new System.Windows.Forms.ToolTip(this.components);
            this.Borrar = new System.Windows.Forms.ToolTip(this.components);
            this.Buscar = new System.Windows.Forms.ToolTip(this.components);
            this.Imprimir = new System.Windows.Forms.ToolTip(this.components);
            this.Aceptar = new System.Windows.Forms.ToolTip(this.components);
            this.Cancelar = new System.Windows.Forms.ToolTip(this.components);
            this.Salir = new System.Windows.Forms.ToolTip(this.components);
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoAgua = new System.Windows.Forms.Label();
            this.cboTipoAgua = new System.Windows.Forms.ComboBox();
            this.gpbBusquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestras)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBusquedas
            // 
            this.gpbBusquedas.Controls.Add(this.txtBuscarLugarDeMuestra);
            this.gpbBusquedas.Controls.Add(this.lblBuscarLugarMuestra);
            this.gpbBusquedas.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusquedas.Location = new System.Drawing.Point(9, 240);
            this.gpbBusquedas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbBusquedas.Name = "gpbBusquedas";
            this.gpbBusquedas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbBusquedas.Size = new System.Drawing.Size(517, 87);
            this.gpbBusquedas.TabIndex = 111;
            this.gpbBusquedas.TabStop = false;
            this.gpbBusquedas.Text = "Búsquedas :";
            // 
            // txtBuscarLugarDeMuestra
            // 
            this.txtBuscarLugarDeMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarLugarDeMuestra.Location = new System.Drawing.Point(183, 33);
            this.txtBuscarLugarDeMuestra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarLugarDeMuestra.Name = "txtBuscarLugarDeMuestra";
            this.txtBuscarLugarDeMuestra.Size = new System.Drawing.Size(265, 23);
            this.txtBuscarLugarDeMuestra.TabIndex = 47;
            this.txtBuscarLugarDeMuestra.TextChanged += new System.EventHandler(this.txtBuscarLugarDeMuestra_TextChanged);
            // 
            // lblBuscarLugarMuestra
            // 
            this.lblBuscarLugarMuestra.AutoSize = true;
            this.lblBuscarLugarMuestra.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarLugarMuestra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuscarLugarMuestra.Location = new System.Drawing.Point(8, 33);
            this.lblBuscarLugarMuestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarLugarMuestra.Name = "lblBuscarLugarMuestra";
            this.lblBuscarLugarMuestra.Size = new System.Drawing.Size(164, 21);
            this.lblBuscarLugarMuestra.TabIndex = 46;
            this.lblBuscarLugarMuestra.Text = "Lugar de muestra:";
            // 
            // lblLugarMuestra
            // 
            this.lblLugarMuestra.AutoSize = true;
            this.lblLugarMuestra.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarMuestra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLugarMuestra.Location = new System.Drawing.Point(420, 1);
            this.lblLugarMuestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLugarMuestra.Name = "lblLugarMuestra";
            this.lblLugarMuestra.Size = new System.Drawing.Size(164, 21);
            this.lblLugarMuestra.TabIndex = 109;
            this.lblLugarMuestra.Text = "Lugar de muestra:";
            // 
            // dgvMuestras
            // 
            this.dgvMuestras.AllowUserToAddRows = false;
            this.dgvMuestras.AllowUserToDeleteRows = false;
            this.dgvMuestras.AllowUserToResizeColumns = false;
            this.dgvMuestras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMuestras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMuestras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMuestras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Muestra,
            this.id_TipoAgua,
            this.TipoAgua,
            this.fecha,
            this.hora,
            this.id_empleado,
            this.id_lugar_muestra,
            this.activo,
            this.nombre_apellido,
            this.sector,
            this.lugar_muestra,
            this.lugar_aleatorio,
            this.id_localidad,
            this.observaciones,
            this.localidades});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMuestras.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMuestras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMuestras.Location = new System.Drawing.Point(8, 2);
            this.dgvMuestras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMuestras.MultiSelect = false;
            this.dgvMuestras.Name = "dgvMuestras";
            this.dgvMuestras.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMuestras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMuestras.RowHeadersVisible = false;
            this.dgvMuestras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestras.Size = new System.Drawing.Size(409, 206);
            this.dgvMuestras.StandardTab = true;
            this.dgvMuestras.TabIndex = 108;
            this.dgvMuestras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestras_CellContentClick);
            this.dgvMuestras.SelectionChanged += new System.EventHandler(this.dgvMuestras_SelectionChanged);
            // 
            // id_Muestra
            // 
            this.id_Muestra.DataPropertyName = "id_Muestra";
            this.id_Muestra.HeaderText = "id_Muestra";
            this.id_Muestra.Name = "id_Muestra";
            this.id_Muestra.ReadOnly = true;
            this.id_Muestra.Visible = false;
            // 
            // id_TipoAgua
            // 
            this.id_TipoAgua.DataPropertyName = "id_TipoAgua";
            this.id_TipoAgua.HeaderText = "id_TipoAgua";
            this.id_TipoAgua.Name = "id_TipoAgua";
            this.id_TipoAgua.ReadOnly = true;
            this.id_TipoAgua.Visible = false;
            // 
            // TipoAgua
            // 
            this.TipoAgua.DataPropertyName = "TipoAgua";
            this.TipoAgua.HeaderText = "TipoAgua";
            this.TipoAgua.Name = "TipoAgua";
            this.TipoAgua.ReadOnly = true;
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
            this.hora.DataPropertyName = "Hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // id_empleado
            // 
            this.id_empleado.DataPropertyName = "id_empleado";
            this.id_empleado.HeaderText = "id_empleado";
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.ReadOnly = true;
            this.id_empleado.Visible = false;
            // 
            // id_lugar_muestra
            // 
            this.id_lugar_muestra.DataPropertyName = "id_lugar_muestra";
            this.id_lugar_muestra.HeaderText = "id_lugar_muestra";
            this.id_lugar_muestra.Name = "id_lugar_muestra";
            this.id_lugar_muestra.ReadOnly = true;
            this.id_lugar_muestra.Visible = false;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            // 
            // nombre_apellido
            // 
            this.nombre_apellido.DataPropertyName = "nombre_apellido";
            this.nombre_apellido.HeaderText = "nombre_apellido";
            this.nombre_apellido.Name = "nombre_apellido";
            this.nombre_apellido.ReadOnly = true;
            // 
            // sector
            // 
            this.sector.DataPropertyName = "sector";
            this.sector.HeaderText = "sector";
            this.sector.Name = "sector";
            this.sector.ReadOnly = true;
            this.sector.Visible = false;
            // 
            // lugar_muestra
            // 
            this.lugar_muestra.DataPropertyName = "lugar_muestra";
            this.lugar_muestra.HeaderText = "lugar_muestra";
            this.lugar_muestra.Name = "lugar_muestra";
            this.lugar_muestra.ReadOnly = true;
            // 
            // lugar_aleatorio
            // 
            this.lugar_aleatorio.DataPropertyName = "lugar_aleatorio";
            this.lugar_aleatorio.HeaderText = "lugar_aleatorio";
            this.lugar_aleatorio.Name = "lugar_aleatorio";
            this.lugar_aleatorio.ReadOnly = true;
            this.lugar_aleatorio.Visible = false;
            // 
            // id_localidad
            // 
            this.id_localidad.DataPropertyName = "id_localidad";
            this.id_localidad.HeaderText = "id_localidad";
            this.id_localidad.Name = "id_localidad";
            this.id_localidad.ReadOnly = true;
            this.id_localidad.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Visible = false;
            // 
            // localidades
            // 
            this.localidades.DataPropertyName = "localidades";
            this.localidades.HeaderText = "localidades";
            this.localidades.Name = "localidades";
            this.localidades.ReadOnly = true;
            this.localidades.Visible = false;
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPanel.Controls.Add(this.btnBuscar);
            this.btnPanel.Controls.Add(this.btnImprimir);
            this.btnPanel.Controls.Add(this.btnBorrar);
            this.btnPanel.Controls.Add(this.btnSalir);
            this.btnPanel.Controls.Add(this.btnCancelar);
            this.btnPanel.Controls.Add(this.btnAceptar);
            this.btnPanel.Controls.Add(this.btnModificar);
            this.btnPanel.Controls.Add(this.btnAgregar);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 334);
            this.btnPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(756, 71);
            this.btnPanel.TabIndex = 107;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(220, 10);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 49);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscar.SetToolTip(this.btnBuscar, "Buscar la muestra");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(288, 10);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(60, 49);
            this.btnImprimir.TabIndex = 4;
            this.Imprimir.SetToolTip(this.btnImprimir, "Imprimir");
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(152, 10);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(60, 49);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar.SetToolTip(this.btnBorrar, "Cancelar");
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(685, 10);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 49);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(500, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 49);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(432, 10);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 49);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Aceptar.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(84, 10);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 49);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Modificar.SetToolTip(this.btnModificar, "Modificar la muestra");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(16, 10);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 49);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregar.SetToolTip(this.btnAgregar, "Agergar muestra");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFechayHora
            // 
            this.lblFechayHora.AutoSize = true;
            this.lblFechayHora.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechayHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechayHora.Location = new System.Drawing.Point(420, 47);
            this.lblFechayHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechayHora.Name = "lblFechayHora";
            this.lblFechayHora.Size = new System.Drawing.Size(71, 21);
            this.lblFechayHora.TabIndex = 118;
            this.lblFechayHora.Text = "Fecha :";
            // 
            // cboLugarMuestra
            // 
            this.cboLugarMuestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLugarMuestra.FormattingEnabled = true;
            this.cboLugarMuestra.Location = new System.Drawing.Point(424, 20);
            this.cboLugarMuestra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLugarMuestra.Name = "cboLugarMuestra";
            this.cboLugarMuestra.Size = new System.Drawing.Size(160, 24);
            this.cboLugarMuestra.TabIndex = 120;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(424, 68);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(116, 22);
            this.dtpFecha.TabIndex = 121;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(421, 142);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(99, 21);
            this.lblEmpleado.TabIndex = 122;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(424, 164);
            this.cboEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(160, 24);
            this.cboEmpleado.TabIndex = 123;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(425, 114);
            this.dtpHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(115, 22);
            this.dtpHora.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(421, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 124;
            this.label1.Text = "Hora:";
            // 
            // lblTipoAgua
            // 
            this.lblTipoAgua.AutoSize = true;
            this.lblTipoAgua.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAgua.Location = new System.Drawing.Point(421, 193);
            this.lblTipoAgua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAgua.Name = "lblTipoAgua";
            this.lblTipoAgua.Size = new System.Drawing.Size(98, 21);
            this.lblTipoAgua.TabIndex = 126;
            this.lblTipoAgua.Text = "Tipo agua:";
            // 
            // cboTipoAgua
            // 
            this.cboTipoAgua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAgua.FormattingEnabled = true;
            this.cboTipoAgua.Location = new System.Drawing.Point(424, 213);
            this.cboTipoAgua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoAgua.Name = "cboTipoAgua";
            this.cboTipoAgua.Size = new System.Drawing.Size(160, 24);
            this.cboTipoAgua.TabIndex = 127;
            // 
            // frmMuestras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 405);
            this.Controls.Add(this.cboTipoAgua);
            this.Controls.Add(this.lblTipoAgua);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboLugarMuestra);
            this.Controls.Add(this.lblFechayHora);
            this.Controls.Add(this.gpbBusquedas);
            this.Controls.Add(this.lblLugarMuestra);
            this.Controls.Add(this.dgvMuestras);
            this.Controls.Add(this.btnPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMuestras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestras";
            this.Load += new System.EventHandler(this.frmMuestras_Load);
            this.gpbBusquedas.ResumeLayout(false);
            this.gpbBusquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestras)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBusquedas;
        private System.Windows.Forms.TextBox txtBuscarLugarDeMuestra;
        private System.Windows.Forms.Label lblBuscarLugarMuestra;
        private System.Windows.Forms.Label lblLugarMuestra;
        private System.Windows.Forms.DataGridView dgvMuestras;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFechayHora;
        private System.Windows.Forms.ComboBox cboLugarMuestra;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.ToolTip Buscar;
        private System.Windows.Forms.ToolTip Imprimir;
        private System.Windows.Forms.ToolTip Cancelar;
        private System.Windows.Forms.ToolTip Salir;
        private System.Windows.Forms.ToolTip Aceptar;
        private System.Windows.Forms.ToolTip Modificar;
        private System.Windows.Forms.ToolTip Agregar;
        private System.Windows.Forms.ToolTip Borrar;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoAgua;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_TipoAgua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAgua;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lugar_muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar_muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar_aleatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidades;
        private System.Windows.Forms.ComboBox cboTipoAgua;
    }
}