namespace WinApp
{
    partial class Form_BuscarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BuscarPaciente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label96 = new System.Windows.Forms.Label();
            this.dgvResultadoBusquedaP = new System.Windows.Forms.DataGridView();
            this.colNoExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGeneroP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedulaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefonoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelularP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZonaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcalleP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectorP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudadP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvinciaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_Filtro = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label97 = new System.Windows.Forms.Label();
            this.Zona_Paciente = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label102 = new System.Windows.Forms.Label();
            this.cbbTipoPaciente = new System.Windows.Forms.ComboBox();
            this.label103 = new System.Windows.Forms.Label();
            this.txtBuscarP = new WinApp.TextBoxValidable();
            this.label1 = new System.Windows.Forms.Label();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusquedaP)).BeginInit();
            this.panel_Filtro.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1143, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 31);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel19.Controls.Add(this.label96);
            this.panel19.Controls.Add(this.dgvResultadoBusquedaP);
            this.panel19.Location = new System.Drawing.Point(9, 160);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1154, 466);
            this.panel19.TabIndex = 48;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label96.Location = new System.Drawing.Point(3, 2);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(200, 20);
            this.label96.TabIndex = 4;
            this.label96.Text = "Resultado de busqueda";
            // 
            // dgvResultadoBusquedaP
            // 
            this.dgvResultadoBusquedaP.AllowUserToAddRows = false;
            this.dgvResultadoBusquedaP.AllowUserToDeleteRows = false;
            this.dgvResultadoBusquedaP.AllowUserToOrderColumns = true;
            this.dgvResultadoBusquedaP.AllowUserToResizeColumns = false;
            this.dgvResultadoBusquedaP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvResultadoBusquedaP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultadoBusquedaP.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvResultadoBusquedaP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultadoBusquedaP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadoBusquedaP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultadoBusquedaP.ColumnHeadersHeight = 40;
            this.dgvResultadoBusquedaP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNoExp,
            this.colNombreP,
            this.colApellidoP,
            this.colGeneroP,
            this.colTipoP,
            this.colFechaNacP,
            this.colFechaAlta,
            this.colCedulaP,
            this.colTelefonoP,
            this.colCelularP,
            this.colEstadoCivil,
            this.colEmailP,
            this.colZonaP,
            this.colcalleP,
            this.colNumeroP,
            this.colSectorP,
            this.colCiudadP,
            this.colProvinciaP});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultadoBusquedaP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultadoBusquedaP.Location = new System.Drawing.Point(5, 49);
            this.dgvResultadoBusquedaP.MultiSelect = false;
            this.dgvResultadoBusquedaP.Name = "dgvResultadoBusquedaP";
            this.dgvResultadoBusquedaP.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadoBusquedaP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultadoBusquedaP.RowHeadersWidth = 30;
            this.dgvResultadoBusquedaP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.dgvResultadoBusquedaP.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultadoBusquedaP.RowTemplate.Height = 35;
            this.dgvResultadoBusquedaP.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultadoBusquedaP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoBusquedaP.Size = new System.Drawing.Size(1143, 411);
            this.dgvResultadoBusquedaP.TabIndex = 0;
            // 
            // colNoExp
            // 
            this.colNoExp.HeaderText = "EXPEDIENTE";
            this.colNoExp.Name = "colNoExp";
            this.colNoExp.ReadOnly = true;
            // 
            // colNombreP
            // 
            this.colNombreP.HeaderText = "NOMBRE";
            this.colNombreP.Name = "colNombreP";
            this.colNombreP.ReadOnly = true;
            this.colNombreP.Width = 130;
            // 
            // colApellidoP
            // 
            this.colApellidoP.HeaderText = "APELLIDO";
            this.colApellidoP.Name = "colApellidoP";
            this.colApellidoP.ReadOnly = true;
            this.colApellidoP.Width = 130;
            // 
            // colGeneroP
            // 
            this.colGeneroP.HeaderText = "GENERO";
            this.colGeneroP.Name = "colGeneroP";
            this.colGeneroP.ReadOnly = true;
            // 
            // colTipoP
            // 
            this.colTipoP.HeaderText = "TIPO PACIENTE";
            this.colTipoP.Name = "colTipoP";
            this.colTipoP.ReadOnly = true;
            this.colTipoP.Width = 160;
            // 
            // colFechaNacP
            // 
            this.colFechaNacP.HeaderText = "EDAD";
            this.colFechaNacP.Name = "colFechaNacP";
            this.colFechaNacP.ReadOnly = true;
            this.colFechaNacP.Width = 105;
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.HeaderText = "FECHA REGISTRO";
            this.colFechaAlta.Name = "colFechaAlta";
            this.colFechaAlta.ReadOnly = true;
            // 
            // colCedulaP
            // 
            this.colCedulaP.HeaderText = "CEDULA";
            this.colCedulaP.Name = "colCedulaP";
            this.colCedulaP.ReadOnly = true;
            // 
            // colTelefonoP
            // 
            this.colTelefonoP.HeaderText = "TELEFONO";
            this.colTelefonoP.Name = "colTelefonoP";
            this.colTelefonoP.ReadOnly = true;
            this.colTelefonoP.Width = 101;
            // 
            // colCelularP
            // 
            this.colCelularP.HeaderText = "CELULAR";
            this.colCelularP.Name = "colCelularP";
            this.colCelularP.ReadOnly = true;
            // 
            // colEstadoCivil
            // 
            this.colEstadoCivil.HeaderText = "ESTADO CIVIL";
            this.colEstadoCivil.Name = "colEstadoCivil";
            this.colEstadoCivil.ReadOnly = true;
            // 
            // colEmailP
            // 
            this.colEmailP.HeaderText = "EMAIL";
            this.colEmailP.Name = "colEmailP";
            this.colEmailP.ReadOnly = true;
            this.colEmailP.Width = 200;
            // 
            // colZonaP
            // 
            this.colZonaP.HeaderText = "ZONA";
            this.colZonaP.Name = "colZonaP";
            this.colZonaP.ReadOnly = true;
            // 
            // colcalleP
            // 
            this.colcalleP.HeaderText = "CALLE";
            this.colcalleP.Name = "colcalleP";
            this.colcalleP.ReadOnly = true;
            this.colcalleP.Visible = false;
            // 
            // colNumeroP
            // 
            this.colNumeroP.HeaderText = "NO.";
            this.colNumeroP.Name = "colNumeroP";
            this.colNumeroP.ReadOnly = true;
            this.colNumeroP.Visible = false;
            // 
            // colSectorP
            // 
            this.colSectorP.HeaderText = "SECTOR";
            this.colSectorP.Name = "colSectorP";
            this.colSectorP.ReadOnly = true;
            this.colSectorP.Visible = false;
            // 
            // colCiudadP
            // 
            this.colCiudadP.HeaderText = "CIUDAD";
            this.colCiudadP.Name = "colCiudadP";
            this.colCiudadP.ReadOnly = true;
            this.colCiudadP.Visible = false;
            // 
            // colProvinciaP
            // 
            this.colProvinciaP.HeaderText = "PROVINCIA";
            this.colProvinciaP.Name = "colProvinciaP";
            this.colProvinciaP.ReadOnly = true;
            this.colProvinciaP.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirmar.Location = new System.Drawing.Point(1034, 637);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(129, 35);
            this.btnConfirmar.TabIndex = 66;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(9, 637);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 35);
            this.button2.TabIndex = 67;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_Filtro
            // 
            this.panel_Filtro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_Filtro.Controls.Add(this.groupBox3);
            this.panel_Filtro.Location = new System.Drawing.Point(9, 40);
            this.panel_Filtro.Name = "panel_Filtro";
            this.panel_Filtro.Size = new System.Drawing.Size(995, 105);
            this.panel_Filtro.TabIndex = 68;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label97);
            this.groupBox3.Controls.Add(this.Zona_Paciente);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.label102);
            this.groupBox3.Controls.Add(this.cbbTipoPaciente);
            this.groupBox3.Controls.Add(this.label103);
            this.groupBox3.Controls.Add(this.txtBuscarP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Location = new System.Drawing.Point(24, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 85);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro de busqueda";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label97.Location = new System.Drawing.Point(571, 23);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(116, 16);
            this.label97.TabIndex = 22;
            this.label97.Text = "Zona del paciente";
            // 
            // Zona_Paciente
            // 
            this.Zona_Paciente.DisplayMember = "Zo_Nombre";
            this.Zona_Paciente.FormattingEnabled = true;
            this.Zona_Paciente.Location = new System.Drawing.Point(574, 44);
            this.Zona_Paciente.Name = "Zona_Paciente";
            this.Zona_Paciente.Size = new System.Drawing.Size(121, 24);
            this.Zona_Paciente.TabIndex = 21;
            this.Zona_Paciente.ValueMember = "Zo_ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(373, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 28);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label102.Location = new System.Drawing.Point(435, 24);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(110, 16);
            this.label102.TabIndex = 7;
            this.label102.Text = "Tipo de paciente";
            // 
            // cbbTipoPaciente
            // 
            this.cbbTipoPaciente.DisplayMember = "TP_Descripcion";
            this.cbbTipoPaciente.FormattingEnabled = true;
            this.cbbTipoPaciente.Location = new System.Drawing.Point(438, 45);
            this.cbbTipoPaciente.Name = "cbbTipoPaciente";
            this.cbbTipoPaciente.Size = new System.Drawing.Size(121, 24);
            this.cbbTipoPaciente.TabIndex = 6;
            this.cbbTipoPaciente.ValueMember = "TP_ID";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label103.Location = new System.Drawing.Point(13, 24);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(50, 16);
            this.label103.TabIndex = 2;
            this.label103.Text = "Buscar";
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Location = new System.Drawing.Point(16, 47);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(351, 22);
            this.txtBuscarP.TabIndex = 0;
            this.txtBuscarP.Validar = false;
            this.txtBuscarP.TextChanged += new System.EventHandler(this.txtBuscarP_TextChanged);
            this.txtBuscarP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(443, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Busqueda rapida de Pacientes";
            // 
            // Form_BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1184, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Filtro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_BuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BuscarPaciente";
            this.Load += new System.EventHandler(this.Form_BuscarPaciente_Load);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusquedaP)).EndInit();
            this.panel_Filtro.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        internal System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.DataGridView dgvResultadoBusquedaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeneroP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedulaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelularP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZonaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcalleP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectorP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudadP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvinciaP;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Panel panel_Filtro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label97;
        internal System.Windows.Forms.ComboBox Zona_Paciente;
        internal System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label102;
        internal System.Windows.Forms.ComboBox cbbTipoPaciente;
        private System.Windows.Forms.Label label103;
        private TextBoxValidable txtBuscarP;
        private System.Windows.Forms.Label label1;
    }
}