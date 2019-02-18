namespace WinApp
{
    partial class ucCitasP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCitasP));
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbMostrarNota = new System.Windows.Forms.CheckBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.ColFechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label95 = new System.Windows.Forms.Label();
            this.panelDatosPersonales = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpHoraCita = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotaCita = new WinApp.TextBoxValidable();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCirtaNo = new WinApp.TextBoxValidable();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.txtMotivo = new WinApp.TextBoxValidable();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnProgramarCita = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTipoPaciente = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscarP = new WinApp.TextBoxValidable();
            this.label103 = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.txtExpediente = new WinApp.TextBoxValidable();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.panelDatosPersonales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(434, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Programar una Cita";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.cbMostrarNota);
            this.panel3.Controls.Add(this.dgvCitas);
            this.panel3.Controls.Add(this.label95);
            this.panel3.Location = new System.Drawing.Point(49, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 376);
            this.panel3.TabIndex = 50;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // cbMostrarNota
            // 
            this.cbMostrarNota.AutoSize = true;
            this.cbMostrarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbMostrarNota.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbMostrarNota.Location = new System.Drawing.Point(456, 19);
            this.cbMostrarNota.Name = "cbMostrarNota";
            this.cbMostrarNota.Size = new System.Drawing.Size(104, 20);
            this.cbMostrarNota.TabIndex = 63;
            this.cbMostrarNota.Text = "Mostrar Nota";
            this.cbMostrarNota.UseVisualStyleBackColor = true;
            this.cbMostrarNota.Click += new System.EventHandler(this.cbMostrarNota_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToOrderColumns = true;
            this.dgvCitas.AllowUserToResizeColumns = false;
            this.dgvCitas.AllowUserToResizeRows = false;
            this.dgvCitas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCitas.ColumnHeadersHeight = 40;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFechaCita,
            this.ColMotivo,
            this.colNota});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCitas.Location = new System.Drawing.Point(10, 45);
            this.dgvCitas.MultiSelect = false;
            this.dgvCitas.Name = "dgvCitas";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.RowHeadersWidth = 15;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.dgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCitas.RowTemplate.Height = 35;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(554, 322);
            this.dgvCitas.TabIndex = 62;
            // 
            // ColFechaCita
            // 
            this.ColFechaCita.FillWeight = 50F;
            this.ColFechaCita.HeaderText = "Fecha de Cita";
            this.ColFechaCita.Name = "ColFechaCita";
            this.ColFechaCita.Width = 130;
            // 
            // ColMotivo
            // 
            this.ColMotivo.HeaderText = "Motivo de Cita";
            this.ColMotivo.Name = "ColMotivo";
            this.ColMotivo.Width = 400;
            // 
            // colNota
            // 
            this.colNota.HeaderText = "Nota";
            this.colNota.Name = "colNota";
            this.colNota.Visible = false;
            this.colNota.Width = 250;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label95.Location = new System.Drawing.Point(6, 5);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(242, 20);
            this.label95.TabIndex = 35;
            this.label95.Text = "Listado de Citas del paciente";
            // 
            // panelDatosPersonales
            // 
            this.panelDatosPersonales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDatosPersonales.Controls.Add(this.label14);
            this.panelDatosPersonales.Controls.Add(this.dtpHoraCita);
            this.panelDatosPersonales.Controls.Add(this.label7);
            this.panelDatosPersonales.Controls.Add(this.txtNotaCita);
            this.panelDatosPersonales.Controls.Add(this.label6);
            this.panelDatosPersonales.Controls.Add(this.txtCirtaNo);
            this.panelDatosPersonales.Controls.Add(this.label22);
            this.panelDatosPersonales.Controls.Add(this.dtpFechaCita);
            this.panelDatosPersonales.Controls.Add(this.txtMotivo);
            this.panelDatosPersonales.Controls.Add(this.label17);
            this.panelDatosPersonales.Controls.Add(this.label19);
            this.panelDatosPersonales.Controls.Add(this.label20);
            this.panelDatosPersonales.Location = new System.Drawing.Point(646, 228);
            this.panelDatosPersonales.Name = "panelDatosPersonales";
            this.panelDatosPersonales.Size = new System.Drawing.Size(560, 376);
            this.panelDatosPersonales.TabIndex = 63;
            this.panelDatosPersonales.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDatosPersonales_MouseMove);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label14.Location = new System.Drawing.Point(117, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Hora :";
            // 
            // dtpHoraCita
            // 
            this.dtpHoraCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraCita.Location = new System.Drawing.Point(181, 169);
            this.dtpHoraCita.MinDate = new System.DateTime(2018, 4, 16, 0, 0, 0, 0);
            this.dtpHoraCita.Name = "dtpHoraCita";
            this.dtpHoraCita.ShowUpDown = true;
            this.dtpHoraCita.Size = new System.Drawing.Size(129, 24);
            this.dtpHoraCita.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(328, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = " ";
            // 
            // txtNotaCita
            // 
            this.txtNotaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaCita.Location = new System.Drawing.Point(181, 225);
            this.txtNotaCita.Multiline = true;
            this.txtNotaCita.Name = "txtNotaCita";
            this.txtNotaCita.Size = new System.Drawing.Size(328, 114);
            this.txtNotaCita.TabIndex = 19;
            this.txtNotaCita.Validar = false;
            this.txtNotaCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotaCita_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(118, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nota :";
            // 
            // txtCirtaNo
            // 
            this.txtCirtaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCirtaNo.Location = new System.Drawing.Point(404, 30);
            this.txtCirtaNo.Name = "txtCirtaNo";
            this.txtCirtaNo.ReadOnly = true;
            this.txtCirtaNo.Size = new System.Drawing.Size(106, 21);
            this.txtCirtaNo.TabIndex = 17;
            this.txtCirtaNo.Validar = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label22.Location = new System.Drawing.Point(401, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 16);
            this.label22.TabIndex = 16;
            this.label22.Text = "Cita No. :";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(181, 121);
            this.dtpFechaCita.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFechaCita.MinDate = new System.DateTime(2018, 4, 16, 0, 0, 0, 0);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(129, 24);
            this.dtpFechaCita.TabIndex = 8;
            this.dtpFechaCita.DropDown += new System.EventHandler(this.dtpFechaCita_DropDown);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(181, 72);
            this.txtMotivo.MaxLength = 60;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(328, 21);
            this.txtMotivo.TabIndex = 5;
            this.txtMotivo.Validar = false;
            this.txtMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotivo_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label17.Location = new System.Drawing.Point(55, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Fechade la cita :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label19.Location = new System.Drawing.Point(62, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Motivo de Cita :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label20.Location = new System.Drawing.Point(13, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "Datos de la cita";
            // 
            // btnProgramarCita
            // 
            this.btnProgramarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.btnProgramarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnProgramarCita.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProgramarCita.Location = new System.Drawing.Point(1077, 616);
            this.btnProgramarCita.Name = "btnProgramarCita";
            this.btnProgramarCita.Size = new System.Drawing.Size(129, 35);
            this.btnProgramarCita.TabIndex = 68;
            this.btnProgramarCita.Text = "Programar Cita";
            this.btnProgramarCita.UseVisualStyleBackColor = false;
            this.btnProgramarCita.Click += new System.EventHandler(this.btnProgramarCita_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Location = new System.Drawing.Point(50, 616);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 35);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.txtBuscarP);
            this.panel1.Controls.Add(this.label103);
            this.panel1.Controls.Add(this.btnBuscarPaciente);
            this.panel1.Location = new System.Drawing.Point(49, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 150);
            this.panel1.TabIndex = 70;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEstadoCivil);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnEditarPaciente);
            this.groupBox3.Controls.Add(this.lblCedula);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblZona);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblTipoPaciente);
            this.groupBox3.Controls.Add(this.lblGenero);
            this.groupBox3.Controls.Add(this.lblEdad);
            this.groupBox3.Controls.Add(this.lblApellido);
            this.groupBox3.Controls.Add(this.lblNombre);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Location = new System.Drawing.Point(11, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(901, 89);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos previos del paciente";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEstadoCivil.Location = new System.Drawing.Point(754, 52);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(116, 18);
            this.lblEstadoCivil.TabIndex = 41;
            this.lblEstadoCivil.Text = "------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(656, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Estado Civil :";
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarPaciente.FlatAppearance.BorderSize = 0;
            this.btnEditarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPaciente.Image")));
            this.btnEditarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPaciente.Location = new System.Drawing.Point(865, 13);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(30, 28);
            this.btnEditarPaciente.TabIndex = 39;
            this.btnEditarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPaciente.UseVisualStyleBackColor = false;
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click);
            this.btnEditarPaciente.MouseHover += new System.EventHandler(this.btnEditarPaciente_MouseHover);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCedula.Location = new System.Drawing.Point(754, 34);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(116, 18);
            this.lblCedula.TabIndex = 35;
            this.lblCedula.Text = "------------------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(684, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "Cedula :";
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblZona.Location = new System.Drawing.Point(547, 51);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(92, 18);
            this.lblZona.TabIndex = 33;
            this.lblZona.Text = "--------------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(493, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Zona :";
            // 
            // lblTipoPaciente
            // 
            this.lblTipoPaciente.AutoSize = true;
            this.lblTipoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPaciente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTipoPaciente.Location = new System.Drawing.Point(547, 29);
            this.lblTipoPaciente.Name = "lblTipoPaciente";
            this.lblTipoPaciente.Size = new System.Drawing.Size(92, 18);
            this.lblTipoPaciente.TabIndex = 31;
            this.lblTipoPaciente.Text = "--------------";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblGenero.Location = new System.Drawing.Point(340, 54);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(92, 18);
            this.lblGenero.TabIndex = 30;
            this.lblGenero.Text = "--------------";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEdad.Location = new System.Drawing.Point(340, 26);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(56, 18);
            this.lblEdad.TabIndex = 25;
            this.lblEdad.Text = "--------";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblApellido.Location = new System.Drawing.Point(87, 53);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(176, 18);
            this.lblApellido.TabIndex = 24;
            this.lblApellido.Text = "----------------------------";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNombre.Location = new System.Drawing.Point(87, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(176, 18);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "----------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(438, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tipo Paciente :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(270, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Genero :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(16, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nombre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(15, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Apellido :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(284, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Edad :";
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Location = new System.Drawing.Point(170, 14);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(227, 20);
            this.txtBuscarP.TabIndex = 36;
            this.txtBuscarP.Validar = false;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label103.Location = new System.Drawing.Point(15, 17);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(139, 16);
            this.label103.TabIndex = 37;
            this.label103.Text = "Expediente o Cedula :";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPaciente.Image")));
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(403, 10);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(30, 28);
            this.btnBuscarPaciente.TabIndex = 38;
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // txtExpediente
            // 
            this.txtExpediente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpediente.Location = new System.Drawing.Point(1089, 47);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.ReadOnly = true;
            this.txtExpediente.Size = new System.Drawing.Size(113, 24);
            this.txtExpediente.TabIndex = 72;
            this.txtExpediente.Validar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(981, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 71;
            this.label10.Text = "Expediente :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucCitasP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProgramarCita);
            this.Controls.Add(this.panelDatosPersonales);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Name = "ucCitasP";
            this.Size = new System.Drawing.Size(1250, 660);
            this.Load += new System.EventHandler(this.ucCitasP_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucCitasP_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.panelDatosPersonales.ResumeLayout(false);
            this.panelDatosPersonales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Label label95;
        internal System.Windows.Forms.Panel panelDatosPersonales;
        private TextBoxValidable txtCirtaNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private TextBoxValidable txtMotivo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private TextBoxValidable txtNotaCita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProgramarCita;
        private System.Windows.Forms.DateTimePicker dtpHoraCita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnEditarPaciente;
        internal System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label lblTipoPaciente;
        internal System.Windows.Forms.Label lblGenero;
        internal System.Windows.Forms.Label lblEdad;
        internal System.Windows.Forms.Label lblApellido;
        internal System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        internal TextBoxValidable txtBuscarP;
        private System.Windows.Forms.Label label103;
        internal System.Windows.Forms.Button btnBuscarPaciente;
        internal TextBoxValidable txtExpediente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota;
        private System.Windows.Forms.CheckBox cbMostrarNota;
    }
}
