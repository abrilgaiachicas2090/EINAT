namespace Control_Calidad2023.Formularios
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreyApellido = new System.Windows.Forms.TextBox();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.gpbBusquedas = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombreyApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.id_Empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnBuscarr = new System.Windows.Forms.Button();
            this.btnImprimirr = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalirr = new System.Windows.Forms.Button();
            this.btnCancelarr = new System.Windows.Forms.Button();
            this.btnAceptarr = new System.Windows.Forms.Button();
            this.btnModificarr = new System.Windows.Forms.Button();
            this.btnAgregarr = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.ToolTip(this.components);
            this.Modificar = new System.Windows.Forms.ToolTip(this.components);
            this.Eliminar = new System.Windows.Forms.ToolTip(this.components);
            this.Buscar = new System.Windows.Forms.ToolTip(this.components);
            this.Imprimir = new System.Windows.Forms.ToolTip(this.components);
            this.Aceptar = new System.Windows.Forms.ToolTip(this.components);
            this.Cancelar = new System.Windows.Forms.ToolTip(this.components);
            this.Salir = new System.Windows.Forms.ToolTip(this.components);
            this.gpbBusquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(165, 283);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 40);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(216, 283);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(45, 40);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(114, 283);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 40);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(657, 283);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 40);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(437, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 40);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(386, 283);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(63, 283);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(45, 40);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(12, 283);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 40);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(434, 127);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(144, 20);
            this.txtGmail.TabIndex = 130;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(433, 82);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 20);
            this.txtTelefono.TabIndex = 129;
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.Location = new System.Drawing.Point(434, 39);
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.Size = new System.Drawing.Size(145, 20);
            this.txtNombreyApellido.TabIndex = 127;
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmail.Location = new System.Drawing.Point(431, 111);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(56, 18);
            this.lblGmail.TabIndex = 126;
            this.lblGmail.Text = "Gmail :";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(431, 66);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 18);
            this.lblTelefono.TabIndex = 125;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // gpbBusquedas
            // 
            this.gpbBusquedas.Controls.Add(this.txtBuscarNombreyApellido);
            this.gpbBusquedas.Controls.Add(this.label4);
            this.gpbBusquedas.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusquedas.Location = new System.Drawing.Point(9, 212);
            this.gpbBusquedas.Name = "gpbBusquedas";
            this.gpbBusquedas.Size = new System.Drawing.Size(420, 53);
            this.gpbBusquedas.TabIndex = 123;
            this.gpbBusquedas.TabStop = false;
            this.gpbBusquedas.Text = "Búsquedas :";
            // 
            // txtBuscarNombreyApellido
            // 
            this.txtBuscarNombreyApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombreyApellido.Location = new System.Drawing.Point(141, 26);
            this.txtBuscarNombreyApellido.Name = "txtBuscarNombreyApellido";
            this.txtBuscarNombreyApellido.Size = new System.Drawing.Size(195, 20);
            this.txtBuscarNombreyApellido.TabIndex = 47;
            this.txtBuscarNombreyApellido.TextChanged += new System.EventHandler(this.txtBuscarEmpleado_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nombre y Apellido:";
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpleados.Location = new System.Drawing.Point(431, 23);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(133, 18);
            this.lblEmpleados.TabIndex = 122;
            this.lblEmpleados.Text = "Nombre y Apellido :";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleados,
            this.nombre_apellido,
            this.telefono,
            this.gmail,
            this.activo});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 12);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(403, 167);
            this.dgvEmpleados.StandardTab = true;
            this.dgvEmpleados.TabIndex = 121;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // id_Empleados
            // 
            this.id_Empleados.DataPropertyName = "id_Empleados";
            this.id_Empleados.HeaderText = "id_Empleados";
            this.id_Empleados.Name = "id_Empleados";
            this.id_Empleados.ReadOnly = true;
            this.id_Empleados.Visible = false;
            // 
            // nombre_apellido
            // 
            this.nombre_apellido.DataPropertyName = "nombre_apellido";
            this.nombre_apellido.HeaderText = "Nombre y Apellido";
            this.nombre_apellido.Name = "nombre_apellido";
            this.nombre_apellido.ReadOnly = true;
            this.nombre_apellido.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.telefono.DefaultCellStyle = dataGridViewCellStyle8;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // gmail
            // 
            this.gmail.DataPropertyName = "gmail";
            this.gmail.HeaderText = "Gmail";
            this.gmail.Name = "gmail";
            this.gmail.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPanel.Controls.Add(this.btnBuscarr);
            this.btnPanel.Controls.Add(this.btnImprimirr);
            this.btnPanel.Controls.Add(this.btnEliminar);
            this.btnPanel.Controls.Add(this.btnSalirr);
            this.btnPanel.Controls.Add(this.btnCancelarr);
            this.btnPanel.Controls.Add(this.btnAceptarr);
            this.btnPanel.Controls.Add(this.btnModificarr);
            this.btnPanel.Controls.Add(this.btnAgregarr);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 277);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(626, 58);
            this.btnPanel.TabIndex = 131;
            // 
            // btnBuscarr
            // 
            this.btnBuscarr.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarr.Image")));
            this.btnBuscarr.Location = new System.Drawing.Point(166, 9);
            this.btnBuscarr.Name = "btnBuscarr";
            this.btnBuscarr.Size = new System.Drawing.Size(45, 40);
            this.btnBuscarr.TabIndex = 11;
            this.btnBuscarr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscar.SetToolTip(this.btnBuscarr, "Bsucar empleado");
            this.btnBuscarr.UseVisualStyleBackColor = true;
            this.btnBuscarr.Click += new System.EventHandler(this.btnBuscarr_Click);
            // 
            // btnImprimirr
            // 
            this.btnImprimirr.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirr.Image")));
            this.btnImprimirr.Location = new System.Drawing.Point(217, 9);
            this.btnImprimirr.Name = "btnImprimirr";
            this.btnImprimirr.Size = new System.Drawing.Size(45, 40);
            this.btnImprimirr.TabIndex = 12;
            this.Imprimir.SetToolTip(this.btnImprimirr, "Imprimir");
            this.btnImprimirr.UseVisualStyleBackColor = true;
            this.btnImprimirr.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(115, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalirr
            // 
            this.btnSalirr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalirr.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirr.Image")));
            this.btnSalirr.Location = new System.Drawing.Point(533, 9);
            this.btnSalirr.Name = "btnSalirr";
            this.btnSalirr.Size = new System.Drawing.Size(45, 40);
            this.btnSalirr.TabIndex = 15;
            this.btnSalirr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.SetToolTip(this.btnSalirr, "Salir");
            this.btnSalirr.UseVisualStyleBackColor = true;
            this.btnSalirr.Click += new System.EventHandler(this.btnSalirr_Click);
            // 
            // btnCancelarr
            // 
            this.btnCancelarr.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarr.Image")));
            this.btnCancelarr.Location = new System.Drawing.Point(393, 9);
            this.btnCancelarr.Name = "btnCancelarr";
            this.btnCancelarr.Size = new System.Drawing.Size(45, 40);
            this.btnCancelarr.TabIndex = 14;
            this.btnCancelarr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar.SetToolTip(this.btnCancelarr, "Cancelar");
            this.btnCancelarr.UseVisualStyleBackColor = true;
            this.btnCancelarr.Click += new System.EventHandler(this.btnCancelarr_Click);
            // 
            // btnAceptarr
            // 
            this.btnAceptarr.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarr.Image")));
            this.btnAceptarr.Location = new System.Drawing.Point(342, 9);
            this.btnAceptarr.Name = "btnAceptarr";
            this.btnAceptarr.Size = new System.Drawing.Size(45, 40);
            this.btnAceptarr.TabIndex = 13;
            this.btnAceptarr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Aceptar.SetToolTip(this.btnAceptarr, "Aceptar");
            this.btnAceptarr.UseVisualStyleBackColor = true;
            this.btnAceptarr.Click += new System.EventHandler(this.btnAceptarr_Click);
            // 
            // btnModificarr
            // 
            this.btnModificarr.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarr.Image")));
            this.btnModificarr.Location = new System.Drawing.Point(64, 9);
            this.btnModificarr.Name = "btnModificarr";
            this.btnModificarr.Size = new System.Drawing.Size(45, 40);
            this.btnModificarr.TabIndex = 9;
            this.btnModificarr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Modificar.SetToolTip(this.btnModificarr, "Modificar");
            this.btnModificarr.UseVisualStyleBackColor = true;
            this.btnModificarr.Click += new System.EventHandler(this.btnModificarr_Click);
            // 
            // btnAgregarr
            // 
            this.btnAgregarr.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarr.Image")));
            this.btnAgregarr.Location = new System.Drawing.Point(13, 9);
            this.btnAgregarr.Name = "btnAgregarr";
            this.btnAgregarr.Size = new System.Drawing.Size(45, 40);
            this.btnAgregarr.TabIndex = 8;
            this.btnAgregarr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregar.SetToolTip(this.btnAgregarr, "Agregar nuevo empleado");
            this.btnAgregarr.UseVisualStyleBackColor = true;
            this.btnAgregarr.Click += new System.EventHandler(this.btnAgregarr_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 335);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombreyApellido);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.gpbBusquedas);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.gpbBusquedas.ResumeLayout(false);
            this.gpbBusquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreyApellido;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox gpbBusquedas;
        private System.Windows.Forms.TextBox txtBuscarNombreyApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnBuscarr;
        private System.Windows.Forms.Button btnImprimirr;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalirr;
        private System.Windows.Forms.Button btnCancelarr;
        private System.Windows.Forms.Button btnAceptarr;
        private System.Windows.Forms.Button btnModificarr;
        private System.Windows.Forms.Button btnAgregarr;
        private System.Windows.Forms.ToolTip Buscar;
        private System.Windows.Forms.ToolTip Imprimir;
        private System.Windows.Forms.ToolTip Eliminar;
        private System.Windows.Forms.ToolTip Salir;
        private System.Windows.Forms.ToolTip Cancelar;
        private System.Windows.Forms.ToolTip Aceptar;
        private System.Windows.Forms.ToolTip Modificar;
        private System.Windows.Forms.ToolTip Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
    }
}