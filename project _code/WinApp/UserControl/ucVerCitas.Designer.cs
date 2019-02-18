namespace WinApp
{
    partial class ucVerCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVerCitas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label96 = new System.Windows.Forms.Label();
            this.dgvResuBusquedaP = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker11 = new System.Windows.Forms.DateTimePicker();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.dateTimePicker12 = new System.Windows.Forms.DateTimePicker();
            this.button18 = new System.Windows.Forms.Button();
            this.txtBuscarP = new WinApp.TextBoxValidable();
            this.cbbGenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResuBusquedaP)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(926, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 71;
            this.button1.Text = "Nueva Cita";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel19.Controls.Add(this.button4);
            this.panel19.Controls.Add(this.button3);
            this.panel19.Controls.Add(this.label96);
            this.panel19.Controls.Add(this.dgvResuBusquedaP);
            this.panel19.Controls.Add(this.button2);
            this.panel19.Location = new System.Drawing.Point(40, 155);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1116, 453);
            this.panel19.TabIndex = 70;
            this.panel19.Paint += new System.Windows.Forms.PaintEventHandler(this.panel19_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(758, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "Imprimir";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(943, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Editar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label96.Location = new System.Drawing.Point(3, 1);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(114, 20);
            this.label96.TabIndex = 4;
            this.label96.Text = "Listado Citas";
            // 
            // dgvResuBusquedaP
            // 
            this.dgvResuBusquedaP.AllowUserToAddRows = false;
            this.dgvResuBusquedaP.AllowUserToDeleteRows = false;
            this.dgvResuBusquedaP.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvResuBusquedaP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResuBusquedaP.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvResuBusquedaP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResuBusquedaP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResuBusquedaP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResuBusquedaP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResuBusquedaP.ColumnHeadersHeight = 43;
            this.dgvResuBusquedaP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConsulta,
            this.colPaciente,
            this.colFecha,
            this.colHoraCita,
            this.colMotivo,
            this.colNota});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResuBusquedaP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResuBusquedaP.Location = new System.Drawing.Point(8, 49);
            this.dgvResuBusquedaP.Name = "dgvResuBusquedaP";
            this.dgvResuBusquedaP.ReadOnly = true;
            this.dgvResuBusquedaP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResuBusquedaP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.dgvResuBusquedaP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResuBusquedaP.RowTemplate.Height = 40;
            this.dgvResuBusquedaP.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResuBusquedaP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResuBusquedaP.Size = new System.Drawing.Size(1100, 391);
            this.dgvResuBusquedaP.TabIndex = 0;
            this.dgvResuBusquedaP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResuBusquedaP_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(852, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eliminar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(549, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Buscar Citas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(40, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 93);
            this.panel1.TabIndex = 68;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker11);
            this.groupBox3.Controls.Add(this.label100);
            this.groupBox3.Controls.Add(this.label101);
            this.groupBox3.Controls.Add(this.dateTimePicker12);
            this.groupBox3.Controls.Add(this.button18);
            this.groupBox3.Controls.Add(this.txtBuscarP);
            this.groupBox3.Controls.Add(this.cbbGenero);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Location = new System.Drawing.Point(17, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(852, 75);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro de busqueda";
            // 
            // dateTimePicker11
            // 
            this.dateTimePicker11.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker11.Location = new System.Drawing.Point(677, 37);
            this.dateTimePicker11.Name = "dateTimePicker11";
            this.dateTimePicker11.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker11.TabIndex = 46;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label100.Location = new System.Drawing.Point(674, 17);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(44, 16);
            this.label100.TabIndex = 45;
            this.label100.Text = "Hasta";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label101.Location = new System.Drawing.Point(540, 17);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(49, 16);
            this.label101.TabIndex = 44;
            this.label101.Text = "Desde";
            // 
            // dateTimePicker12
            // 
            this.dateTimePicker12.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker12.Location = new System.Drawing.Point(543, 37);
            this.dateTimePicker12.Name = "dateTimePicker12";
            this.dateTimePicker12.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker12.TabIndex = 43;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(486, 38);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(26, 28);
            this.button18.TabIndex = 41;
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarP.Location = new System.Drawing.Point(263, 38);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(217, 24);
            this.txtBuscarP.TabIndex = 39;
            this.txtBuscarP.Validar = false;
            // 
            // cbbGenero
            // 
            this.cbbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenero.FormattingEnabled = true;
            this.cbbGenero.Location = new System.Drawing.Point(93, 38);
            this.cbbGenero.Name = "cbbGenero";
            this.cbbGenero.Size = new System.Drawing.Size(150, 26);
            this.cbbGenero.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Buscar por";
            // 
            // colConsulta
            // 
            this.colConsulta.FillWeight = 10.15228F;
            this.colConsulta.HeaderText = "Cita No.";
            this.colConsulta.Name = "colConsulta";
            this.colConsulta.ReadOnly = true;
            this.colConsulta.Width = 115;
            // 
            // colPaciente
            // 
            this.colPaciente.FillWeight = 10.15228F;
            this.colPaciente.HeaderText = "Paciente";
            this.colPaciente.Name = "colPaciente";
            this.colPaciente.ReadOnly = true;
            this.colPaciente.Width = 200;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 10.15228F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 150;
            // 
            // colHoraCita
            // 
            this.colHoraCita.HeaderText = "Hora";
            this.colHoraCita.Name = "colHoraCita";
            this.colHoraCita.ReadOnly = true;
            // 
            // colMotivo
            // 
            this.colMotivo.FillWeight = 369.5432F;
            this.colMotivo.HeaderText = "Motivo de Cita";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.ReadOnly = true;
            this.colMotivo.Width = 400;
            // 
            // colNota
            // 
            this.colNota.HeaderText = "Nota";
            this.colNota.Name = "colNota";
            this.colNota.ReadOnly = true;
            // 
            // ucVerCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "ucVerCitas";
            this.Size = new System.Drawing.Size(1184, 669);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucVerCitas_MouseMove);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResuBusquedaP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.DataGridView dgvResuBusquedaP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DateTimePicker dateTimePicker11;
        internal System.Windows.Forms.Label label100;
        internal System.Windows.Forms.Label label101;
        internal System.Windows.Forms.DateTimePicker dateTimePicker12;
        private System.Windows.Forms.Button button18;
        private TextBoxValidable txtBuscarP;
        private System.Windows.Forms.ComboBox cbbGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota;
    }
}
