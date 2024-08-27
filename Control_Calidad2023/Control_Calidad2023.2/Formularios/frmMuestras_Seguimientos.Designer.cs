namespace Control_Calidad_2023.form
{
    partial class frmMuestras_Seguimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuestras_Seguimientos));
            this.dgvURL = new System.Windows.Forms.DataGridView();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.LinkLabel();
            this.dtpFechAnalisis = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraAnalisis = new System.Windows.Forms.DateTimePicker();
            this.lblHoraAnalisis = new System.Windows.Forms.Label();
            this.lblFechaAnalisis = new System.Windows.Forms.Label();
            this.id_Muestras_Seguimientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Seguimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvURL)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvURL
            // 
            this.dgvURL.AllowUserToAddRows = false;
            this.dgvURL.AllowUserToDeleteRows = false;
            this.dgvURL.AllowUserToResizeColumns = false;
            this.dgvURL.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvURL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvURL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvURL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvURL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Muestras_Seguimientos,
            this.id_Muestra,
            this.id_Seguimiento,
            this.fecha,
            this.hora,
            this.seguimiento});
            this.dgvURL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvURL.Location = new System.Drawing.Point(12, 12);
            this.dgvURL.MultiSelect = false;
            this.dgvURL.Name = "dgvURL";
            this.dgvURL.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvURL.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvURL.RowHeadersVisible = false;
            this.dgvURL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvURL.Size = new System.Drawing.Size(353, 167);
            this.dgvURL.StandardTab = true;
            this.dgvURL.TabIndex = 137;
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPanel.Controls.Add(this.btnBorrar);
            this.btnPanel.Controls.Add(this.btnSalir);
            this.btnPanel.Controls.Add(this.btnCancelar);
            this.btnPanel.Controls.Add(this.btnAceptar);
            this.btnPanel.Controls.Add(this.btnModificar);
            this.btnPanel.Controls.Add(this.btnAgregar);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 262);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(532, 58);
            this.btnPanel.TabIndex = 136;
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
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(475, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip6.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(320, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(269, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
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
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(380, 117);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(129, 16);
            this.lblURL.TabIndex = 140;
            this.lblURL.TabStop = true;
            this.lblURL.Text = "Enlace a Google Drive";
            // 
            // dtpFechAnalisis
            // 
            this.dtpFechAnalisis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechAnalisis.Location = new System.Drawing.Point(383, 88);
            this.dtpFechAnalisis.Name = "dtpFechAnalisis";
            this.dtpFechAnalisis.Size = new System.Drawing.Size(118, 20);
            this.dtpFechAnalisis.TabIndex = 141;
            // 
            // dtpHoraAnalisis
            // 
            this.dtpHoraAnalisis.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraAnalisis.Location = new System.Drawing.Point(383, 42);
            this.dtpHoraAnalisis.Name = "dtpHoraAnalisis";
            this.dtpHoraAnalisis.Size = new System.Drawing.Size(118, 20);
            this.dtpHoraAnalisis.TabIndex = 142;
            // 
            // lblHoraAnalisis
            // 
            this.lblHoraAnalisis.AutoSize = true;
            this.lblHoraAnalisis.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAnalisis.Location = new System.Drawing.Point(383, 23);
            this.lblHoraAnalisis.Name = "lblHoraAnalisis";
            this.lblHoraAnalisis.Size = new System.Drawing.Size(114, 17);
            this.lblHoraAnalisis.TabIndex = 143;
            this.lblHoraAnalisis.Text = "Hora del Análisis:";
            // 
            // lblFechaAnalisis
            // 
            this.lblFechaAnalisis.AutoSize = true;
            this.lblFechaAnalisis.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAnalisis.Location = new System.Drawing.Point(383, 69);
            this.lblFechaAnalisis.Name = "lblFechaAnalisis";
            this.lblFechaAnalisis.Size = new System.Drawing.Size(118, 17);
            this.lblFechaAnalisis.TabIndex = 144;
            this.lblFechaAnalisis.Text = "Fecha del Análisis:";
            // 
            // id_Muestras_Seguimientos
            // 
            this.id_Muestras_Seguimientos.DataPropertyName = "id_Muestras_Seguimientos";
            this.id_Muestras_Seguimientos.HeaderText = "id_Muestras_Seguimientos";
            this.id_Muestras_Seguimientos.Name = "id_Muestras_Seguimientos";
            this.id_Muestras_Seguimientos.ReadOnly = true;
            this.id_Muestras_Seguimientos.Visible = false;
            // 
            // id_Muestra
            // 
            this.id_Muestra.DataPropertyName = "id_Muestra";
            this.id_Muestra.HeaderText = "id_Muestra";
            this.id_Muestra.Name = "id_Muestra";
            this.id_Muestra.ReadOnly = true;
            this.id_Muestra.Visible = false;
            // 
            // id_Seguimiento
            // 
            this.id_Seguimiento.DataPropertyName = "id_Seguimiento";
            this.id_Seguimiento.HeaderText = "id_Seguimiento";
            this.id_Seguimiento.Name = "id_Seguimiento";
            this.id_Seguimiento.ReadOnly = true;
            this.id_Seguimiento.Visible = false;
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
            // seguimiento
            // 
            this.seguimiento.DataPropertyName = "seguimiento";
            this.seguimiento.HeaderText = "URL de Seguimiento";
            this.seguimiento.Name = "seguimiento";
            this.seguimiento.ReadOnly = true;
            this.seguimiento.Width = 150;
            // 
            // frmMuestras_Seguimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 320);
            this.Controls.Add(this.lblFechaAnalisis);
            this.Controls.Add(this.lblHoraAnalisis);
            this.Controls.Add(this.dtpHoraAnalisis);
            this.Controls.Add(this.dtpFechAnalisis);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.dgvURL);
            this.Controls.Add(this.btnPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMuestras_Seguimientos";
            this.Text = "frmMuestras_Seguimientos";
            this.Load += new System.EventHandler(this.frmMuestras_Seguimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvURL)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvURL;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.LinkLabel lblURL;
        private System.Windows.Forms.DateTimePicker dtpFechAnalisis;
        private System.Windows.Forms.DateTimePicker dtpHoraAnalisis;
        private System.Windows.Forms.Label lblHoraAnalisis;
        private System.Windows.Forms.Label lblFechaAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Muestras_Seguimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Seguimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguimiento;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}