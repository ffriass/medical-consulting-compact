namespace WinApp
{
    partial class ucVerConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVerConsultas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbIncluir = new System.Windows.Forms.CheckBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarConsulta = new System.Windows.Forms.Button();
            this.txtBuscarP = new WinApp.TextBoxValidable();
            this.cbbOpcioines = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.dgvListadoConsulta = new System.Windows.Forms.DataGridView();
            this.colConsultaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPa_NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicionConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label96 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(52, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 106);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbIncluir);
            this.groupBox3.Controls.Add(this.dtpHasta);
            this.groupBox3.Controls.Add(this.label100);
            this.groupBox3.Controls.Add(this.label101);
            this.groupBox3.Controls.Add(this.dtpDesde);
            this.groupBox3.Controls.Add(this.btnBuscarConsulta);
            this.groupBox3.Controls.Add(this.txtBuscarP);
            this.groupBox3.Controls.Add(this.cbbOpcioines);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Location = new System.Drawing.Point(17, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(843, 88);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro de busqueda";
            // 
            // cbIncluir
            // 
            this.cbIncluir.AutoSize = true;
            this.cbIncluir.Location = new System.Drawing.Point(571, 11);
            this.cbIncluir.Name = "cbIncluir";
            this.cbIncluir.Size = new System.Drawing.Size(61, 20);
            this.cbIncluir.TabIndex = 47;
            this.cbIncluir.Text = "Incluir";
            this.cbIncluir.UseVisualStyleBackColor = true;
            this.cbIncluir.Click += new System.EventHandler(this.cbIncluir_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(705, 55);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(110, 22);
            this.dtpHasta.TabIndex = 46;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label100.Location = new System.Drawing.Point(702, 35);
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
            this.label101.Location = new System.Drawing.Point(568, 35);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(49, 16);
            this.label101.TabIndex = 44;
            this.label101.Text = "Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(571, 55);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(110, 22);
            this.dtpDesde.TabIndex = 43;
            // 
            // btnBuscarConsulta
            // 
            this.btnBuscarConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarConsulta.FlatAppearance.BorderSize = 0;
            this.btnBuscarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarConsulta.Image")));
            this.btnBuscarConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarConsulta.Location = new System.Drawing.Point(486, 52);
            this.btnBuscarConsulta.Name = "btnBuscarConsulta";
            this.btnBuscarConsulta.Size = new System.Drawing.Size(26, 28);
            this.btnBuscarConsulta.TabIndex = 41;
            this.btnBuscarConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarConsulta.UseVisualStyleBackColor = false;
            this.btnBuscarConsulta.Click += new System.EventHandler(this.btnBuscarConsulta_Click);
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarP.Location = new System.Drawing.Point(263, 52);
            this.txtBuscarP.MaxLength = 11;
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(217, 24);
            this.txtBuscarP.TabIndex = 39;
            this.txtBuscarP.Validar = false;
            this.txtBuscarP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarP_KeyPress);
            // 
            // cbbOpcioines
            // 
            this.cbbOpcioines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOpcioines.FormattingEnabled = true;
            this.cbbOpcioines.Items.AddRange(new object[] {
            "Todo",
            "Expediente o Cedula"});
            this.cbbOpcioines.Location = new System.Drawing.Point(93, 52);
            this.cbbOpcioines.Name = "cbbOpcioines";
            this.cbbOpcioines.Size = new System.Drawing.Size(150, 26);
            this.cbbOpcioines.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Buscar por";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(433, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Buscar Consulta Medica";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel19.Controls.Add(this.dgvListadoConsulta);
            this.panel19.Controls.Add(this.button4);
            this.panel19.Controls.Add(this.button3);
            this.panel19.Controls.Add(this.label96);
            this.panel19.Controls.Add(this.button2);
            this.panel19.Location = new System.Drawing.Point(52, 159);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1075, 465);
            this.panel19.TabIndex = 48;
            this.panel19.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel19_MouseMove);
            // 
            // dgvListadoConsulta
            // 
            this.dgvListadoConsulta.AllowUserToAddRows = false;
            this.dgvListadoConsulta.AllowUserToDeleteRows = false;
            this.dgvListadoConsulta.AllowUserToResizeColumns = false;
            this.dgvListadoConsulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvListadoConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoConsulta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoConsulta.ColumnHeadersHeight = 40;
            this.dgvListadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListadoConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConsultaID,
            this.colPa_NombreCompleto,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.colCondicionConsulta});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoConsulta.Location = new System.Drawing.Point(9, 50);
            this.dgvListadoConsulta.MultiSelect = false;
            this.dgvListadoConsulta.Name = "dgvListadoConsulta";
            this.dgvListadoConsulta.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListadoConsulta.RowHeadersVisible = false;
            this.dgvListadoConsulta.RowHeadersWidth = 15;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.dgvListadoConsulta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListadoConsulta.RowTemplate.Height = 35;
            this.dgvListadoConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoConsulta.Size = new System.Drawing.Size(1056, 408);
            this.dgvListadoConsulta.TabIndex = 63;
            this.dgvListadoConsulta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvListadoConsulta_MouseMove);
            // 
            // colConsultaID
            // 
            this.colConsultaID.HeaderText = "Consulta No";
            this.colConsultaID.Name = "colConsultaID";
            this.colConsultaID.ReadOnly = true;
            this.colConsultaID.Width = 150;
            // 
            // colPa_NombreCompleto
            // 
            this.colPa_NombreCompleto.HeaderText = "Paciente";
            this.colPa_NombreCompleto.Name = "colPa_NombreCompleto";
            this.colPa_NombreCompleto.ReadOnly = true;
            this.colPa_NombreCompleto.Width = 210;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Motivo de consulta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 400;
            // 
            // colCondicionConsulta
            // 
            this.colCondicionConsulta.HeaderText = "Condicion";
            this.colCondicionConsulta.Name = "colCondicionConsulta";
            this.colCondicionConsulta.ReadOnly = true;
            this.colCondicionConsulta.Width = 150;
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
            this.button4.Location = new System.Drawing.Point(716, 13);
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
            this.button3.Location = new System.Drawing.Point(901, 13);
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
            this.label96.Size = new System.Drawing.Size(175, 20);
            this.label96.TabIndex = 4;
            this.label96.Text = "Listado de consultas";
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
            this.button2.Location = new System.Drawing.Point(810, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eliminar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.btnNuevaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnNuevaConsulta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNuevaConsulta.Location = new System.Drawing.Point(998, 630);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(129, 35);
            this.btnNuevaConsulta.TabIndex = 67;
            this.btnNuevaConsulta.Text = "Nueva Consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = false;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // ucVerConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.btnNuevaConsulta);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "ucVerConsultas";
            this.Size = new System.Drawing.Size(1184, 672);
            this.Load += new System.EventHandler(this.ucVerConsultas_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbOpcioines;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Button btnBuscarConsulta;
        private TextBoxValidable txtBuscarP;
        private System.Windows.Forms.Panel panel19;
        internal System.Windows.Forms.DateTimePicker dtpHasta;
        internal System.Windows.Forms.Label label100;
        internal System.Windows.Forms.Label label101;
        internal System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.DataGridView dgvListadoConsulta;
        private System.Windows.Forms.CheckBox cbIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsultaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPa_NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicionConsulta;
    }
}
