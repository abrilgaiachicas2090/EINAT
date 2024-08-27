namespace Control_Calidad2023.Formularios
{
    partial class frmParametros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametros));
            this.txtLimiteNormProvincial = new System.Windows.Forms.TextBox();
            this.lblNormProvincialLimite = new System.Windows.Forms.Label();
            this.cboNombreAnalisis = new System.Windows.Forms.ComboBox();
            this.txtLimiteCodigoAlimentario = new System.Windows.Forms.TextBox();
            this.txtNormProvincial = new System.Windows.Forms.TextBox();
            this.txtCodAlimentario = new System.Windows.Forms.TextBox();
            this.lblNombreAnalisis = new System.Windows.Forms.Label();
            this.lblCodAlimentarioLimite = new System.Windows.Forms.Label();
            this.lblNormProvincial = new System.Windows.Forms.Label();
            this.gpbBusquedas = new System.Windows.Forms.GroupBox();
            this.txtBuscarAnalisis = new System.Windows.Forms.TextBox();
            this.lblBuscarAnalisis = new System.Windows.Forms.Label();
            this.lblCodAlimentario = new System.Windows.Forms.Label();
            this.dgvParametros = new System.Windows.Forms.DataGridView();
            this.nombreanalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoanalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_alimentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_alimentario_limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.norm_provincial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.norm_provincial_limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_NombreAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_TipoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.ToolTip(this.components);
            this.Modificar = new System.Windows.Forms.ToolTip(this.components);
            this.Eliminar = new System.Windows.Forms.ToolTip(this.components);
            this.Buscar = new System.Windows.Forms.ToolTip(this.components);
            this.Imprimir = new System.Windows.Forms.ToolTip(this.components);
            this.Aceptar = new System.Windows.Forms.ToolTip(this.components);
            this.Cancelar = new System.Windows.Forms.ToolTip(this.components);
            this.Salir = new System.Windows.Forms.ToolTip(this.components);
            this.gpbBusquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLimiteNormProvincial
            // 
            this.txtLimiteNormProvincial.Location = new System.Drawing.Point(626, 190);
            this.txtLimiteNormProvincial.Name = "txtLimiteNormProvincial";
            this.txtLimiteNormProvincial.Size = new System.Drawing.Size(63, 20);
            this.txtLimiteNormProvincial.TabIndex = 146;
            this.txtLimiteNormProvincial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimiteNormProvincial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteNormProvincial_KeyPress);
            // 
            // lblNormProvincialLimite
            // 
            this.lblNormProvincialLimite.AutoSize = true;
            this.lblNormProvincialLimite.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormProvincialLimite.Location = new System.Drawing.Point(624, 174);
            this.lblNormProvincialLimite.Name = "lblNormProvincialLimite";
            this.lblNormProvincialLimite.Size = new System.Drawing.Size(207, 18);
            this.lblNormProvincialLimite.TabIndex = 145;
            this.lblNormProvincialLimite.Text = "Normativa provincial máximo:";
            // 
            // cboNombreAnalisis
            // 
            this.cboNombreAnalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreAnalisis.FormattingEnabled = true;
            this.cboNombreAnalisis.Location = new System.Drawing.Point(626, 24);
            this.cboNombreAnalisis.Name = "cboNombreAnalisis";
            this.cboNombreAnalisis.Size = new System.Drawing.Size(144, 21);
            this.cboNombreAnalisis.TabIndex = 144;
            // 
            // txtLimiteCodigoAlimentario
            // 
            this.txtLimiteCodigoAlimentario.Location = new System.Drawing.Point(625, 110);
            this.txtLimiteCodigoAlimentario.Name = "txtLimiteCodigoAlimentario";
            this.txtLimiteCodigoAlimentario.Size = new System.Drawing.Size(64, 20);
            this.txtLimiteCodigoAlimentario.TabIndex = 143;
            this.txtLimiteCodigoAlimentario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimiteCodigoAlimentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteCodigoAlimentario_KeyPress);
            // 
            // txtNormProvincial
            // 
            this.txtNormProvincial.Location = new System.Drawing.Point(626, 151);
            this.txtNormProvincial.Name = "txtNormProvincial";
            this.txtNormProvincial.Size = new System.Drawing.Size(63, 20);
            this.txtNormProvincial.TabIndex = 142;
            this.txtNormProvincial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNormProvincial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNormProvincial_KeyPress);
            // 
            // txtCodAlimentario
            // 
            this.txtCodAlimentario.Location = new System.Drawing.Point(626, 69);
            this.txtCodAlimentario.Name = "txtCodAlimentario";
            this.txtCodAlimentario.Size = new System.Drawing.Size(63, 20);
            this.txtCodAlimentario.TabIndex = 141;
            this.txtCodAlimentario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodAlimentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodAlimentario_KeyPress);
            // 
            // lblNombreAnalisis
            // 
            this.lblNombreAnalisis.AutoSize = true;
            this.lblNombreAnalisis.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAnalisis.Location = new System.Drawing.Point(623, 8);
            this.lblNombreAnalisis.Name = "lblNombreAnalisis";
            this.lblNombreAnalisis.Size = new System.Drawing.Size(70, 18);
            this.lblNombreAnalisis.TabIndex = 140;
            this.lblNombreAnalisis.Text = "Análisis :";
            // 
            // lblCodAlimentarioLimite
            // 
            this.lblCodAlimentarioLimite.AutoSize = true;
            this.lblCodAlimentarioLimite.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAlimentarioLimite.Location = new System.Drawing.Point(623, 94);
            this.lblCodAlimentarioLimite.Name = "lblCodAlimentarioLimite";
            this.lblCodAlimentarioLimite.Size = new System.Drawing.Size(194, 18);
            this.lblCodAlimentarioLimite.TabIndex = 139;
            this.lblCodAlimentarioLimite.Text = "Código alimentario máximo:";
            // 
            // lblNormProvincial
            // 
            this.lblNormProvincial.AutoSize = true;
            this.lblNormProvincial.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormProvincial.Location = new System.Drawing.Point(623, 135);
            this.lblNormProvincial.Name = "lblNormProvincial";
            this.lblNormProvincial.Size = new System.Drawing.Size(205, 18);
            this.lblNormProvincial.TabIndex = 138;
            this.lblNormProvincial.Text = "Normativa provincial mínimo:";
            // 
            // gpbBusquedas
            // 
            this.gpbBusquedas.Controls.Add(this.txtBuscarAnalisis);
            this.gpbBusquedas.Controls.Add(this.lblBuscarAnalisis);
            this.gpbBusquedas.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusquedas.Location = new System.Drawing.Point(27, 198);
            this.gpbBusquedas.Name = "gpbBusquedas";
            this.gpbBusquedas.Size = new System.Drawing.Size(328, 69);
            this.gpbBusquedas.TabIndex = 137;
            this.gpbBusquedas.TabStop = false;
            this.gpbBusquedas.Text = "Búsquedas :";
            // 
            // txtBuscarAnalisis
            // 
            this.txtBuscarAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAnalisis.Location = new System.Drawing.Point(71, 26);
            this.txtBuscarAnalisis.Name = "txtBuscarAnalisis";
            this.txtBuscarAnalisis.Size = new System.Drawing.Size(195, 20);
            this.txtBuscarAnalisis.TabIndex = 47;
            this.txtBuscarAnalisis.TextChanged += new System.EventHandler(this.txtBuscarCodAlimentario_TextChanged);
            this.txtBuscarAnalisis.Enter += new System.EventHandler(this.txtBuscarCodAlimentario_Enter);
            // 
            // lblBuscarAnalisis
            // 
            this.lblBuscarAnalisis.AutoSize = true;
            this.lblBuscarAnalisis.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuscarAnalisis.Location = new System.Drawing.Point(6, 27);
            this.lblBuscarAnalisis.Name = "lblBuscarAnalisis";
            this.lblBuscarAnalisis.Size = new System.Drawing.Size(66, 18);
            this.lblBuscarAnalisis.TabIndex = 46;
            this.lblBuscarAnalisis.Text = "Análisis:";
            // 
            // lblCodAlimentario
            // 
            this.lblCodAlimentario.AutoSize = true;
            this.lblCodAlimentario.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAlimentario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodAlimentario.Location = new System.Drawing.Point(623, 53);
            this.lblCodAlimentario.Name = "lblCodAlimentario";
            this.lblCodAlimentario.Size = new System.Drawing.Size(192, 18);
            this.lblCodAlimentario.TabIndex = 136;
            this.lblCodAlimentario.Text = "Código alimentario mínimo:";
            // 
            // dgvParametros
            // 
            this.dgvParametros.AllowUserToAddRows = false;
            this.dgvParametros.AllowUserToDeleteRows = false;
            this.dgvParametros.AllowUserToResizeColumns = false;
            this.dgvParametros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvParametros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParametros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreanalisis,
            this.tipoanalisis,
            this.cod_alimentario,
            this.cod_alimentario_limite,
            this.norm_provincial,
            this.norm_provincial_limite,
            this.id_NombreAnalisis,
            this.activo,
            this.id_TipoAnalisis,
            this.id_Parametro});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParametros.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvParametros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParametros.Location = new System.Drawing.Point(12, 4);
            this.dgvParametros.MultiSelect = false;
            this.dgvParametros.Name = "dgvParametros";
            this.dgvParametros.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParametros.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParametros.RowHeadersVisible = false;
            this.dgvParametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParametros.Size = new System.Drawing.Size(594, 173);
            this.dgvParametros.StandardTab = true;
            this.dgvParametros.TabIndex = 135;
            this.dgvParametros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParametros_CellContentClick);
            this.dgvParametros.SelectionChanged += new System.EventHandler(this.dgvParametros_SelectionChanged);
            // 
            // nombreanalisis
            // 
            this.nombreanalisis.DataPropertyName = "nombreanalisis";
            this.nombreanalisis.HeaderText = "Análisis";
            this.nombreanalisis.Name = "nombreanalisis";
            this.nombreanalisis.ReadOnly = true;
            this.nombreanalisis.Width = 150;
            // 
            // tipoanalisis
            // 
            this.tipoanalisis.DataPropertyName = "tipoanalisis";
            this.tipoanalisis.HeaderText = "Tipo Análisis";
            this.tipoanalisis.Name = "tipoanalisis";
            this.tipoanalisis.ReadOnly = true;
            this.tipoanalisis.Width = 120;
            // 
            // cod_alimentario
            // 
            this.cod_alimentario.DataPropertyName = "cod_alimentario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cod_alimentario.DefaultCellStyle = dataGridViewCellStyle3;
            this.cod_alimentario.HeaderText = "Cod. Al.Min.";
            this.cod_alimentario.Name = "cod_alimentario";
            this.cod_alimentario.ReadOnly = true;
            this.cod_alimentario.Width = 80;
            // 
            // cod_alimentario_limite
            // 
            this.cod_alimentario_limite.DataPropertyName = "cod_alimentario_limite";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cod_alimentario_limite.DefaultCellStyle = dataGridViewCellStyle4;
            this.cod_alimentario_limite.HeaderText = "Cod.Al.Max.";
            this.cod_alimentario_limite.Name = "cod_alimentario_limite";
            this.cod_alimentario_limite.ReadOnly = true;
            this.cod_alimentario_limite.Width = 80;
            // 
            // norm_provincial
            // 
            this.norm_provincial.DataPropertyName = "norm_provincial";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.norm_provincial.DefaultCellStyle = dataGridViewCellStyle5;
            this.norm_provincial.HeaderText = "Nor.Pr.Min";
            this.norm_provincial.Name = "norm_provincial";
            this.norm_provincial.ReadOnly = true;
            this.norm_provincial.Width = 80;
            // 
            // norm_provincial_limite
            // 
            this.norm_provincial_limite.DataPropertyName = "norm_provincial_limite";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.norm_provincial_limite.DefaultCellStyle = dataGridViewCellStyle6;
            this.norm_provincial_limite.HeaderText = "Nor.Pr.Max";
            this.norm_provincial_limite.Name = "norm_provincial_limite";
            this.norm_provincial_limite.ReadOnly = true;
            this.norm_provincial_limite.Width = 80;
            // 
            // id_NombreAnalisis
            // 
            this.id_NombreAnalisis.DataPropertyName = "id_NombreAnalisis";
            this.id_NombreAnalisis.HeaderText = "id_NombreAnalisis";
            this.id_NombreAnalisis.Name = "id_NombreAnalisis";
            this.id_NombreAnalisis.ReadOnly = true;
            this.id_NombreAnalisis.Visible = false;
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
            this.id_TipoAnalisis.HeaderText = "id_TipoAnalisis";
            this.id_TipoAnalisis.Name = "id_TipoAnalisis";
            this.id_TipoAnalisis.ReadOnly = true;
            this.id_TipoAnalisis.Visible = false;
            // 
            // id_Parametro
            // 
            this.id_Parametro.DataPropertyName = "id_Parametro";
            this.id_Parametro.HeaderText = "id_Parametro";
            this.id_Parametro.Name = "id_Parametro";
            this.id_Parametro.ReadOnly = true;
            this.id_Parametro.Visible = false;
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
            this.btnPanel.Location = new System.Drawing.Point(0, 275);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(845, 58);
            this.btnPanel.TabIndex = 134;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(165, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscar.SetToolTip(this.btnBuscar, "Buscar Parámetro");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(216, 8);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(45, 40);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(114, 8);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 40);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar.SetToolTip(this.btnBorrar, "Eliminar un Parámetro");
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(683, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(508, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(457, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Aceptar.SetToolTip(this.btnAceptar, "Aceptar");
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
            this.Modificar.SetToolTip(this.btnModificar, "Modificar un Parámetro");
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
            this.Agregar.SetToolTip(this.btnAgregar, "Agregar un nuevo Parámetro");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 333);
            this.Controls.Add(this.txtLimiteNormProvincial);
            this.Controls.Add(this.lblNormProvincialLimite);
            this.Controls.Add(this.cboNombreAnalisis);
            this.Controls.Add(this.txtLimiteCodigoAlimentario);
            this.Controls.Add(this.txtNormProvincial);
            this.Controls.Add(this.txtCodAlimentario);
            this.Controls.Add(this.lblNombreAnalisis);
            this.Controls.Add(this.lblCodAlimentarioLimite);
            this.Controls.Add(this.lblNormProvincial);
            this.Controls.Add(this.gpbBusquedas);
            this.Controls.Add(this.lblCodAlimentario);
            this.Controls.Add(this.dgvParametros);
            this.Controls.Add(this.btnPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmParametros";
            this.Load += new System.EventHandler(this.frmParametros_Load_1);
            this.gpbBusquedas.ResumeLayout(false);
            this.gpbBusquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLimiteNormProvincial;
        private System.Windows.Forms.Label lblNormProvincialLimite;
        private System.Windows.Forms.ComboBox cboNombreAnalisis;
        private System.Windows.Forms.TextBox txtLimiteCodigoAlimentario;
        private System.Windows.Forms.TextBox txtNormProvincial;
        private System.Windows.Forms.TextBox txtCodAlimentario;
        private System.Windows.Forms.Label lblNombreAnalisis;
        private System.Windows.Forms.Label lblCodAlimentarioLimite;
        private System.Windows.Forms.Label lblNormProvincial;
        private System.Windows.Forms.GroupBox gpbBusquedas;
        private System.Windows.Forms.Label lblBuscarAnalisis;
        private System.Windows.Forms.Label lblCodAlimentario;
        private System.Windows.Forms.DataGridView dgvParametros;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreanalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoanalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_alimentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_alimentario_limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn norm_provincial;
        private System.Windows.Forms.DataGridViewTextBoxColumn norm_provincial_limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_NombreAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_TipoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Parametro;
        private System.Windows.Forms.TextBox txtBuscarAnalisis;
        private System.Windows.Forms.ToolTip Agregar;
        private System.Windows.Forms.ToolTip Modificar;
        private System.Windows.Forms.ToolTip Eliminar;
        private System.Windows.Forms.ToolTip Buscar;
        private System.Windows.Forms.ToolTip Imprimir;
        private System.Windows.Forms.ToolTip Aceptar;
        private System.Windows.Forms.ToolTip Cancelar;
        private System.Windows.Forms.ToolTip Salir;
    }
}