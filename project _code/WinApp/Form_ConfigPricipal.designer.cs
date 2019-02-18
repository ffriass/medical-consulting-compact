namespace WinApp
{
    partial class Form_ConfigPricipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ConfigPricipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPageRegistro = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTabRegistro = new System.Windows.Forms.Panel();
            this.panelOtrosDatos = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.cbbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxUsActivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageUser = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListadoEspecialidades = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.panelDatosPersonales = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDocCelular = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDocCedula = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tabPageconsultas = new System.Windows.Forms.TabPage();
            this.tabPageDatosClinicos = new System.Windows.Forms.TabPage();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.colTipoEspecialidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colEspecialidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtUserRepeatPassword = new WinApp.TextBoxValidable();
            this.txtUserPassword = new WinApp.TextBoxValidable();
            this.txtUserNombre = new WinApp.TextBoxValidable();
            this.txtDocID = new WinApp.TextBoxValidable();
            this.txtDocEmail = new WinApp.TextBoxValidable();
            this.txtDocCodigo = new WinApp.TextBoxValidable();
            this.txtDocNombre = new WinApp.TextBoxValidable();
            this.txtDocApellido = new WinApp.TextBoxValidable();
            this.textBoxValidable3 = new WinApp.TextBoxValidable();
            this.textBoxValidable2 = new WinApp.TextBoxValidable();
            this.textBoxValidable1 = new WinApp.TextBoxValidable();
            this.txtEmail = new WinApp.TextBoxValidable();
            this.txt = new WinApp.TextBoxValidable();
            this.txtApellido = new WinApp.TextBoxValidable();
            this.txtNombre = new WinApp.TextBoxValidable();
            this.tabPage.SuspendLayout();
            this.tabPageRegistro.SuspendLayout();
            this.panelTabRegistro.SuspendLayout();
            this.panelOtrosDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEspecialidades)).BeginInit();
            this.panelDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPageRegistro);
            this.tabPage.Controls.Add(this.tabPageconsultas);
            this.tabPage.Controls.Add(this.tabPageDatosClinicos);
            this.tabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage.Location = new System.Drawing.Point(7, 6);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(998, 622);
            this.tabPage.TabIndex = 23;
            // 
            // tabPageRegistro
            // 
            this.tabPageRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.tabPageRegistro.Controls.Add(this.button1);
            this.tabPageRegistro.Controls.Add(this.panelTabRegistro);
            this.tabPageRegistro.Controls.Add(this.btnConfirmar);
            this.tabPageRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRegistro.Location = new System.Drawing.Point(4, 24);
            this.tabPageRegistro.Name = "tabPageRegistro";
            this.tabPageRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistro.Size = new System.Drawing.Size(990, 594);
            this.tabPageRegistro.TabIndex = 0;
            this.tabPageRegistro.Text = "Registro de Doctores y Usuarios";
            this.tabPageRegistro.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tabPage1_Scroll);
            this.tabPageRegistro.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(3, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 70;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelTabRegistro
            // 
            this.panelTabRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.panelTabRegistro.Controls.Add(this.panelOtrosDatos);
            this.panelTabRegistro.Controls.Add(this.panel1);
            this.panelTabRegistro.Controls.Add(this.panelDatosPersonales);
            this.panelTabRegistro.Location = new System.Drawing.Point(1, 3);
            this.panelTabRegistro.Name = "panelTabRegistro";
            this.panelTabRegistro.Size = new System.Drawing.Size(986, 529);
            this.panelTabRegistro.TabIndex = 1;
            // 
            // panelOtrosDatos
            // 
            this.panelOtrosDatos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOtrosDatos.Controls.Add(this.label16);
            this.panelOtrosDatos.Controls.Add(this.btnBrowseImage);
            this.panelOtrosDatos.Controls.Add(this.cbbTipoUsuario);
            this.panelOtrosDatos.Controls.Add(this.label13);
            this.panelOtrosDatos.Controls.Add(this.checkBoxUsActivo);
            this.panelOtrosDatos.Controls.Add(this.txtUserRepeatPassword);
            this.panelOtrosDatos.Controls.Add(this.txtUserPassword);
            this.panelOtrosDatos.Controls.Add(this.txtUserNombre);
            this.panelOtrosDatos.Controls.Add(this.label3);
            this.panelOtrosDatos.Controls.Add(this.imageUser);
            this.panelOtrosDatos.Controls.Add(this.label6);
            this.panelOtrosDatos.Controls.Add(this.label8);
            this.panelOtrosDatos.Controls.Add(this.label20);
            this.panelOtrosDatos.Controls.Add(this.label15);
            this.panelOtrosDatos.Location = new System.Drawing.Point(10, 310);
            this.panelOtrosDatos.Name = "panelOtrosDatos";
            this.panelOtrosDatos.Size = new System.Drawing.Size(965, 209);
            this.panelOtrosDatos.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label16.Location = new System.Drawing.Point(816, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 16);
            this.label16.TabIndex = 79;
            this.label16.Text = "Foto";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.FlatAppearance.BorderSize = 0;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseImage.Image")));
            this.btnBrowseImage.Location = new System.Drawing.Point(818, 155);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(44, 43);
            this.btnBrowseImage.TabIndex = 78;
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // cbbTipoUsuario
            // 
            this.cbbTipoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTipoUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoUsuario.FormattingEnabled = true;
            this.cbbTipoUsuario.Location = new System.Drawing.Point(514, 81);
            this.cbbTipoUsuario.Name = "cbbTipoUsuario";
            this.cbbTipoUsuario.Size = new System.Drawing.Size(146, 26);
            this.cbbTipoUsuario.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(395, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 77;
            this.label13.Text = "Tipo de usuario :";
            // 
            // checkBoxUsActivo
            // 
            this.checkBoxUsActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.checkBoxUsActivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBoxUsActivo.Checked = true;
            this.checkBoxUsActivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.checkBoxUsActivo.ForeColor = System.Drawing.Color.White;
            this.checkBoxUsActivo.Location = new System.Drawing.Point(514, 47);
            this.checkBoxUsActivo.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUsActivo.Name = "checkBoxUsActivo";
            this.checkBoxUsActivo.Size = new System.Drawing.Size(20, 20);
            this.checkBoxUsActivo.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(401, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Usuario Activo :";
            // 
            // imageUser
            // 
            this.imageUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageUser.Image = ((System.Drawing.Image)(resources.GetObject("imageUser.Image")));
            this.imageUser.Location = new System.Drawing.Point(814, 26);
            this.imageUser.Name = "imageUser";
            this.imageUser.Size = new System.Drawing.Size(141, 125);
            this.imageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageUser.TabIndex = 69;
            this.imageUser.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(17, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Repetir Contraseña :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(64, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Contraseña :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label20.Location = new System.Drawing.Point(12, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 16);
            this.label20.TabIndex = 14;
            this.label20.Text = " Nombre de Usuario :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(11, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 18);
            this.label15.TabIndex = 1;
            this.label15.Text = "Otros Datos de Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dgvListadoEspecialidades);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(595, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 292);
            this.panel1.TabIndex = 6;
            // 
            // dgvListadoEspecialidades
            // 
            this.dgvListadoEspecialidades.AllowUserToDeleteRows = false;
            this.dgvListadoEspecialidades.AllowUserToResizeColumns = false;
            this.dgvListadoEspecialidades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvListadoEspecialidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoEspecialidades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListadoEspecialidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoEspecialidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoEspecialidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoEspecialidades.ColumnHeadersHeight = 40;
            this.dgvListadoEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipoEspecialidad,
            this.colEspecialidad});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoEspecialidades.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoEspecialidades.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListadoEspecialidades.Location = new System.Drawing.Point(1, 32);
            this.dgvListadoEspecialidades.MultiSelect = false;
            this.dgvListadoEspecialidades.Name = "dgvListadoEspecialidades";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoEspecialidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListadoEspecialidades.RowHeadersVisible = false;
            this.dgvListadoEspecialidades.RowHeadersWidth = 15;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.dgvListadoEspecialidades.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListadoEspecialidades.RowTemplate.Height = 35;
            this.dgvListadoEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoEspecialidades.Size = new System.Drawing.Size(378, 256);
            this.dgvListadoEspecialidades.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label14.Location = new System.Drawing.Point(5, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(221, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Registre sus Especialidades";
            // 
            // panelDatosPersonales
            // 
            this.panelDatosPersonales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDatosPersonales.Controls.Add(this.txtDocID);
            this.panelDatosPersonales.Controls.Add(this.txtDocEmail);
            this.panelDatosPersonales.Controls.Add(this.label11);
            this.panelDatosPersonales.Controls.Add(this.txtDocCodigo);
            this.panelDatosPersonales.Controls.Add(this.label9);
            this.panelDatosPersonales.Controls.Add(this.txtDocNombre);
            this.panelDatosPersonales.Controls.Add(this.txtDocApellido);
            this.panelDatosPersonales.Controls.Add(this.txtDocCelular);
            this.panelDatosPersonales.Controls.Add(this.label17);
            this.panelDatosPersonales.Controls.Add(this.txtDocCedula);
            this.panelDatosPersonales.Controls.Add(this.label22);
            this.panelDatosPersonales.Controls.Add(this.label7);
            this.panelDatosPersonales.Controls.Add(this.label5);
            this.panelDatosPersonales.Controls.Add(this.label4);
            this.panelDatosPersonales.Controls.Add(this.label2);
            this.panelDatosPersonales.Location = new System.Drawing.Point(9, 10);
            this.panelDatosPersonales.Name = "panelDatosPersonales";
            this.panelDatosPersonales.Size = new System.Drawing.Size(575, 292);
            this.panelDatosPersonales.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(99, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Email :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(89, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Codigo :";
            // 
            // txtDocCelular
            // 
            this.txtDocCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDocCelular.Location = new System.Drawing.Point(154, 214);
            this.txtDocCelular.Mask = "000-000-0000";
            this.txtDocCelular.Name = "txtDocCelular";
            this.txtDocCelular.Size = new System.Drawing.Size(146, 24);
            this.txtDocCelular.TabIndex = 31;
            this.txtDocCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label17.Location = new System.Drawing.Point(91, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Celular :";
            // 
            // txtDocCedula
            // 
            this.txtDocCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDocCedula.Location = new System.Drawing.Point(155, 126);
            this.txtDocCedula.Mask = "000-0000000-0";
            this.txtDocCedula.Name = "txtDocCedula";
            this.txtDocCedula.Size = new System.Drawing.Size(145, 24);
            this.txtDocCedula.TabIndex = 2;
            this.txtDocCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label22.Location = new System.Drawing.Point(446, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 16);
            this.label22.TabIndex = 16;
            this.label22.Text = "Expediente No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(90, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cedula :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(83, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellido :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(84, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos Personales";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirmar.Location = new System.Drawing.Point(859, 554);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(129, 35);
            this.btnConfirmar.TabIndex = 69;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tabPageconsultas
            // 
            this.tabPageconsultas.Location = new System.Drawing.Point(4, 24);
            this.tabPageconsultas.Name = "tabPageconsultas";
            this.tabPageconsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageconsultas.Size = new System.Drawing.Size(990, 594);
            this.tabPageconsultas.TabIndex = 1;
            this.tabPageconsultas.Text = "Consultar Usuarios del sistema";
            this.tabPageconsultas.UseVisualStyleBackColor = true;
            // 
            // tabPageDatosClinicos
            // 
            this.tabPageDatosClinicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDatosClinicos.Location = new System.Drawing.Point(4, 24);
            this.tabPageDatosClinicos.Name = "tabPageDatosClinicos";
            this.tabPageDatosClinicos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatosClinicos.Size = new System.Drawing.Size(990, 594);
            this.tabPageDatosClinicos.TabIndex = 2;
            this.tabPageDatosClinicos.Text = "Datos Clinicos";
            this.tabPageDatosClinicos.UseVisualStyleBackColor = true;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // colTipoEspecialidad
            // 
            this.colTipoEspecialidad.DropDownWidth = 5;
            this.colTipoEspecialidad.HeaderText = "Tipo";
            this.colTipoEspecialidad.MaxDropDownItems = 15;
            this.colTipoEspecialidad.Name = "colTipoEspecialidad";
            this.colTipoEspecialidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTipoEspecialidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEspecialidad
            // 
            this.colEspecialidad.HeaderText = "Especialidad";
            this.colEspecialidad.Items.AddRange(new object[] {
            "Especialidad 1",
            "Especialidad 2",
            "Especialidad 3",
            "Especialidad 4",
            "Especialidad 5",
            "Especialidad 6"});
            this.colEspecialidad.Name = "colEspecialidad";
            this.colEspecialidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEspecialidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEspecialidad.Width = 250;
            // 
            // txtUserRepeatPassword
            // 
            this.txtUserRepeatPassword.Location = new System.Drawing.Point(153, 130);
            this.txtUserRepeatPassword.Name = "txtUserRepeatPassword";
            this.txtUserRepeatPassword.Size = new System.Drawing.Size(214, 26);
            this.txtUserRepeatPassword.TabIndex = 74;
            this.txtUserRepeatPassword.Validar = true;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(153, 91);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(214, 26);
            this.txtUserPassword.TabIndex = 73;
            this.txtUserPassword.Validar = true;
            // 
            // txtUserNombre
            // 
            this.txtUserNombre.Location = new System.Drawing.Point(153, 37);
            this.txtUserNombre.Name = "txtUserNombre";
            this.txtUserNombre.Size = new System.Drawing.Size(214, 26);
            this.txtUserNombre.TabIndex = 34;
            this.txtUserNombre.Validar = true;
            // 
            // txtDocID
            // 
            this.txtDocID.Location = new System.Drawing.Point(445, 30);
            this.txtDocID.Name = "txtDocID";
            this.txtDocID.ReadOnly = true;
            this.txtDocID.Size = new System.Drawing.Size(108, 26);
            this.txtDocID.TabIndex = 38;
            this.txtDocID.Validar = false;
            // 
            // txtDocEmail
            // 
            this.txtDocEmail.Location = new System.Drawing.Point(154, 257);
            this.txtDocEmail.Name = "txtDocEmail";
            this.txtDocEmail.Size = new System.Drawing.Size(301, 26);
            this.txtDocEmail.TabIndex = 37;
            this.txtDocEmail.Validar = false;
            // 
            // txtDocCodigo
            // 
            this.txtDocCodigo.Location = new System.Drawing.Point(154, 169);
            this.txtDocCodigo.Name = "txtDocCodigo";
            this.txtDocCodigo.Size = new System.Drawing.Size(146, 26);
            this.txtDocCodigo.TabIndex = 3;
            this.txtDocCodigo.Validar = false;
            // 
            // txtDocNombre
            // 
            this.txtDocNombre.Location = new System.Drawing.Point(154, 38);
            this.txtDocNombre.Name = "txtDocNombre";
            this.txtDocNombre.Size = new System.Drawing.Size(214, 26);
            this.txtDocNombre.TabIndex = 0;
            this.txtDocNombre.Validar = true;
            // 
            // txtDocApellido
            // 
            this.txtDocApellido.Location = new System.Drawing.Point(155, 83);
            this.txtDocApellido.Name = "txtDocApellido";
            this.txtDocApellido.Size = new System.Drawing.Size(213, 26);
            this.txtDocApellido.TabIndex = 1;
            this.txtDocApellido.Validar = true;
            // 
            // textBoxValidable3
            // 
            this.textBoxValidable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValidable3.Location = new System.Drawing.Point(150, 123);
            this.textBoxValidable3.MaxLength = 60;
            this.textBoxValidable3.Name = "textBoxValidable3";
            this.textBoxValidable3.PasswordChar = '*';
            this.textBoxValidable3.Size = new System.Drawing.Size(222, 24);
            this.textBoxValidable3.TabIndex = 33;
            this.textBoxValidable3.Validar = false;
            this.textBoxValidable3.WordWrap = false;
            // 
            // textBoxValidable2
            // 
            this.textBoxValidable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValidable2.Location = new System.Drawing.Point(150, 80);
            this.textBoxValidable2.MaxLength = 60;
            this.textBoxValidable2.Name = "textBoxValidable2";
            this.textBoxValidable2.PasswordChar = '*';
            this.textBoxValidable2.Size = new System.Drawing.Size(222, 24);
            this.textBoxValidable2.TabIndex = 31;
            this.textBoxValidable2.Validar = false;
            this.textBoxValidable2.WordWrap = false;
            // 
            // textBoxValidable1
            // 
            this.textBoxValidable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValidable1.Location = new System.Drawing.Point(150, 38);
            this.textBoxValidable1.MaxLength = 60;
            this.textBoxValidable1.Name = "textBoxValidable1";
            this.textBoxValidable1.Size = new System.Drawing.Size(222, 24);
            this.textBoxValidable1.TabIndex = 18;
            this.textBoxValidable1.Validar = false;
            this.textBoxValidable1.WordWrap = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(172, 221);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 24);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.Validar = false;
            this.txtEmail.WordWrap = false;
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(406, 32);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(106, 24);
            this.txt.TabIndex = 16;
            this.txt.Validar = false;
            this.txt.WordWrap = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(173, 71);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(145, 24);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Validar = true;
            this.txtApellido.WordWrap = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(172, 33);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 24);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Validar = true;
            this.txtNombre.WordWrap = false;
            // 
            // Form_ConfigPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1011, 634);
            this.Controls.Add(this.tabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form_ConfigPricipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion y administracion del Sistema";
            this.Load += new System.EventHandler(this.Form_ConfigPricipal_Load);
            this.tabPage.ResumeLayout(false);
            this.tabPageRegistro.ResumeLayout(false);
            this.panelTabRegistro.ResumeLayout(false);
            this.panelOtrosDatos.ResumeLayout(false);
            this.panelOtrosDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEspecialidades)).EndInit();
            this.panelDatosPersonales.ResumeLayout(false);
            this.panelDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPageRegistro;
        private System.Windows.Forms.TabPage tabPageconsultas;
        private System.Windows.Forms.TabPage tabPageDatosClinicos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panelTabRegistro;
        internal System.Windows.Forms.Panel panelOtrosDatos;
        private System.Windows.Forms.PictureBox imageUser;
        private TextBoxValidable textBoxValidable3;
        private System.Windows.Forms.Label label6;
        private TextBoxValidable textBoxValidable2;
        private TextBoxValidable textBoxValidable1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListadoEspecialidades;
        private System.Windows.Forms.Label label14;
        private TextBoxValidable txtEmail;
        private TextBoxValidable txt;
        private TextBoxValidable txtApellido;
        private TextBoxValidable txtNombre;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Panel panelDatosPersonales;
        private System.Windows.Forms.MaskedTextBox txtDocCelular;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtDocCedula;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private TextBoxValidable txtUserRepeatPassword;
        private TextBoxValidable txtUserPassword;
        private TextBoxValidable txtUserNombre;
        private TextBoxValidable txtDocNombre;
        private TextBoxValidable txtDocApellido;
        private TextBoxValidable txtDocID;
        private TextBoxValidable txtDocEmail;
        private System.Windows.Forms.Label label11;
        private TextBoxValidable txtDocCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbTipoUsuario;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxUsActivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTipoEspecialidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn colEspecialidad;
    }
}