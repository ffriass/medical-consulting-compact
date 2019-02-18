namespace WinApp
{
    partial class ucRegistroP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRegistroP));
            this.panelDatosPersonales = new System.Windows.Forms.Panel();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtEdad = new WinApp.TextBoxValidable();
            this.txtExpediente = new WinApp.TextBoxValidable();
            this.cbbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbGenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechNaci = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new WinApp.TextBoxValidable();
            this.txtNombre = new WinApp.TextBoxValidable();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelOtrosDatos = new System.Windows.Forms.Panel();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new WinApp.TextBoxValidable();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.cbbZona = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTipoPaciente = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelDomicilio = new System.Windows.Forms.Panel();
            this.txtDomi_ID = new WinApp.TextBoxValidable();
            this.txtNumero = new WinApp.TextBoxValidable();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSector = new WinApp.TextBoxValidable();
            this.cbbCiudad = new System.Windows.Forms.ComboBox();
            this.cbbProvincia = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCalle = new WinApp.TextBoxValidable();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardaryConsultar = new System.Windows.Forms.Button();
            this.btnSoloGuardarP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label103 = new System.Windows.Forms.Label();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.txtBuscarP = new WinApp.TextBoxValidable();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).BeginInit();
            this.panelDatosPersonales.SuspendLayout();
            this.panelOtrosDatos.SuspendLayout();
            this.panelDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorDatos
            // 
            this.ErrorDatos.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorDatos.Icon")));
            // 
            // panelDatosPersonales
            // 
            this.panelDatosPersonales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDatosPersonales.Controls.Add(this.txtCedula);
            this.panelDatosPersonales.Controls.Add(this.txtEdad);
            this.panelDatosPersonales.Controls.Add(this.txtExpediente);
            this.panelDatosPersonales.Controls.Add(this.cbbEstadoCivil);
            this.panelDatosPersonales.Controls.Add(this.label22);
            this.panelDatosPersonales.Controls.Add(this.label10);
            this.panelDatosPersonales.Controls.Add(this.cbbGenero);
            this.panelDatosPersonales.Controls.Add(this.label8);
            this.panelDatosPersonales.Controls.Add(this.dtpFechNaci);
            this.panelDatosPersonales.Controls.Add(this.txtApellido);
            this.panelDatosPersonales.Controls.Add(this.txtNombre);
            this.panelDatosPersonales.Controls.Add(this.label7);
            this.panelDatosPersonales.Controls.Add(this.label6);
            this.panelDatosPersonales.Controls.Add(this.label5);
            this.panelDatosPersonales.Controls.Add(this.label4);
            this.panelDatosPersonales.Controls.Add(this.label2);
            this.panelDatosPersonales.Location = new System.Drawing.Point(45, 66);
            this.panelDatosPersonales.Name = "panelDatosPersonales";
            this.panelDatosPersonales.Size = new System.Drawing.Size(540, 263);
            this.panelDatosPersonales.TabIndex = 1;
            this.panelDatosPersonales.MouseHover += new System.EventHandler(this.panelDatosPersonales_MouseHover);
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCedula.Location = new System.Drawing.Point(173, 181);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(145, 24);
            this.txtCedula.TabIndex = 4;
            this.txtCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(294, 142);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(73, 24);
            this.txtEdad.TabIndex = 150;
            this.txtEdad.Validar = false;
            this.txtEdad.WordWrap = false;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpediente.Location = new System.Drawing.Point(395, 30);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.ReadOnly = true;
            this.txtExpediente.Size = new System.Drawing.Size(106, 21);
            this.txtExpediente.TabIndex = 100;
            this.txtExpediente.Validar = false;
            this.txtExpediente.WordWrap = false;
            // 
            // cbbEstadoCivil
            // 
            this.cbbEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstadoCivil.FormattingEnabled = true;
            this.cbbEstadoCivil.Location = new System.Drawing.Point(173, 221);
            this.cbbEstadoCivil.Name = "cbbEstadoCivil";
            this.cbbEstadoCivil.Size = new System.Drawing.Size(145, 26);
            this.cbbEstadoCivil.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label22.Location = new System.Drawing.Point(392, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 16);
            this.label22.TabIndex = 16;
            this.label22.Text = "Expediente No :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(77, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Estado Civil :";
            // 
            // cbbGenero
            // 
            this.cbbGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenero.FormattingEnabled = true;
            this.cbbGenero.Location = new System.Drawing.Point(173, 105);
            this.cbbGenero.Name = "cbbGenero";
            this.cbbGenero.Size = new System.Drawing.Size(109, 26);
            this.cbbGenero.TabIndex = 2;
            this.cbbGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbGenero_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(103, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Genero :";
            // 
            // dtpFechNaci
            // 
            this.dtpFechNaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechNaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechNaci.Location = new System.Drawing.Point(173, 142);
            this.dtpFechNaci.MaxDate = new System.DateTime(2018, 4, 2, 0, 0, 0, 0);
            this.dtpFechNaci.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechNaci.Name = "dtpFechNaci";
            this.dtpFechNaci.Size = new System.Drawing.Size(109, 24);
            this.dtpFechNaci.TabIndex = 3;
            this.dtpFechNaci.Value = new System.DateTime(2018, 4, 2, 0, 0, 0, 0);
            this.dtpFechNaci.ValueChanged += new System.EventHandler(this.dtpFechNaci_ValueChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(173, 71);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(195, 24);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Validar = true;
            this.txtApellido.WordWrap = false;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
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
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(105, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cedula :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(39, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha Nacimiento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(98, 78);
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
            this.label4.Location = new System.Drawing.Point(99, 40);
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
            // panelOtrosDatos
            // 
            this.panelOtrosDatos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOtrosDatos.Controls.Add(this.bunifuCheckbox1);
            this.panelOtrosDatos.Controls.Add(this.label12);
            this.panelOtrosDatos.Controls.Add(this.txtEmail);
            this.panelOtrosDatos.Controls.Add(this.label18);
            this.panelOtrosDatos.Controls.Add(this.txtCelular);
            this.panelOtrosDatos.Controls.Add(this.txtTelefono);
            this.panelOtrosDatos.Controls.Add(this.cbbZona);
            this.panelOtrosDatos.Controls.Add(this.label1);
            this.panelOtrosDatos.Controls.Add(this.cbbTipoPaciente);
            this.panelOtrosDatos.Controls.Add(this.label16);
            this.panelOtrosDatos.Controls.Add(this.label17);
            this.panelOtrosDatos.Controls.Add(this.label20);
            this.panelOtrosDatos.Controls.Add(this.label15);
            this.panelOtrosDatos.Location = new System.Drawing.Point(607, 66);
            this.panelOtrosDatos.Name = "panelOtrosDatos";
            this.panelOtrosDatos.Size = new System.Drawing.Size(540, 263);
            this.panelOtrosDatos.TabIndex = 2;
            this.panelOtrosDatos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelOtrosDatos_MouseMove);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(198, 228);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(85, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 76;
            this.label12.Text = "Pacirnte Activo :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(197, 114);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 24);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Validar = false;
            this.txtEmail.WordWrap = false;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label18.Location = new System.Drawing.Point(140, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 19;
            this.label18.Text = "Email :";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCelular.Location = new System.Drawing.Point(197, 74);
            this.txtCelular.Mask = "000-000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(145, 24);
            this.txtCelular.TabIndex = 7;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.Location = new System.Drawing.Point(197, 34);
            this.txtTelefono.Mask = "000-000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 24);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbbZona
            // 
            this.cbbZona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbZona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbZona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbZona.FormattingEnabled = true;
            this.cbbZona.Location = new System.Drawing.Point(199, 190);
            this.cbbZona.Name = "cbbZona";
            this.cbbZona.Size = new System.Drawing.Size(143, 26);
            this.cbbZona.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(143, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Zona :";
            // 
            // cbbTipoPaciente
            // 
            this.cbbTipoPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTipoPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTipoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbTipoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoPaciente.FormattingEnabled = true;
            this.cbbTipoPaciente.Location = new System.Drawing.Point(198, 152);
            this.cbbTipoPaciente.Name = "cbbTipoPaciente";
            this.cbbTipoPaciente.Size = new System.Drawing.Size(144, 26);
            this.cbbTipoPaciente.TabIndex = 9;
            this.cbbTipoPaciente.Text = " ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label16.Location = new System.Drawing.Point(72, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Tipo de paciente :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label17.Location = new System.Drawing.Point(132, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "Celular :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label20.Location = new System.Drawing.Point(120, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 16);
            this.label20.TabIndex = 14;
            this.label20.Text = "Telefono :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(11, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 18);
            this.label15.TabIndex = 1;
            this.label15.Text = "Otros Datos ";
            // 
            // panelDomicilio
            // 
            this.panelDomicilio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDomicilio.Controls.Add(this.txtDomi_ID);
            this.panelDomicilio.Controls.Add(this.txtNumero);
            this.panelDomicilio.Controls.Add(this.label21);
            this.panelDomicilio.Controls.Add(this.txtSector);
            this.panelDomicilio.Controls.Add(this.cbbCiudad);
            this.panelDomicilio.Controls.Add(this.cbbProvincia);
            this.panelDomicilio.Controls.Add(this.label19);
            this.panelDomicilio.Controls.Add(this.label14);
            this.panelDomicilio.Controls.Add(this.label13);
            this.panelDomicilio.Controls.Add(this.txtCalle);
            this.panelDomicilio.Controls.Add(this.label11);
            this.panelDomicilio.Controls.Add(this.label9);
            this.panelDomicilio.Location = new System.Drawing.Point(45, 348);
            this.panelDomicilio.Name = "panelDomicilio";
            this.panelDomicilio.Size = new System.Drawing.Size(1102, 154);
            this.panelDomicilio.TabIndex = 3;
            // 
            // txtDomi_ID
            // 
            this.txtDomi_ID.Location = new System.Drawing.Point(1002, 39);
            this.txtDomi_ID.Name = "txtDomi_ID";
            this.txtDomi_ID.ReadOnly = true;
            this.txtDomi_ID.Size = new System.Drawing.Size(86, 20);
            this.txtDomi_ID.TabIndex = 73;
            this.txtDomi_ID.Validar = false;
            this.txtDomi_ID.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(1002, 87);
            this.txtNumero.MaxLength = 7;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(86, 24);
            this.txtNumero.TabIndex = 17;
            this.txtNumero.Validar = false;
            this.txtNumero.WordWrap = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label21.Location = new System.Drawing.Point(934, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 16);
            this.label21.TabIndex = 18;
            this.label21.Text = "Numero :";
            // 
            // txtSector
            // 
            this.txtSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSector.Location = new System.Drawing.Point(122, 90);
            this.txtSector.MaxLength = 60;
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(328, 24);
            this.txtSector.TabIndex = 15;
            this.txtSector.Validar = false;
            this.txtSector.WordWrap = false;
            this.txtSector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSector_KeyPress);
            // 
            // cbbCiudad
            // 
            this.cbbCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCiudad.FormattingEnabled = true;
            this.cbbCiudad.Location = new System.Drawing.Point(560, 41);
            this.cbbCiudad.Name = "cbbCiudad";
            this.cbbCiudad.Size = new System.Drawing.Size(357, 26);
            this.cbbCiudad.TabIndex = 14;
            this.cbbCiudad.SelectedValueChanged += new System.EventHandler(this.cbbCiudad_SelectedValueChanged);
            // 
            // cbbProvincia
            // 
            this.cbbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProvincia.FormattingEnabled = true;
            this.cbbProvincia.Location = new System.Drawing.Point(125, 39);
            this.cbbProvincia.Name = "cbbProvincia";
            this.cbbProvincia.Size = new System.Drawing.Size(328, 26);
            this.cbbProvincia.TabIndex = 13;
            this.cbbProvincia.SelectedValueChanged += new System.EventHandler(this.cbbProvincia_SelectedValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label19.Location = new System.Drawing.Point(46, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 16);
            this.label19.TabIndex = 16;
            this.label19.Text = "Provincia :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label14.Location = new System.Drawing.Point(63, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Sector :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(489, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ciudad :";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(560, 87);
            this.txtCalle.MaxLength = 60;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(357, 24);
            this.txtCalle.TabIndex = 16;
            this.txtCalle.Validar = false;
            this.txtCalle.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(501, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Calle :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(496, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Registro de Pacientes";
            // 
            // btnGuardaryConsultar
            // 
            this.btnGuardaryConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.btnGuardaryConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaryConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnGuardaryConsultar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardaryConsultar.Location = new System.Drawing.Point(867, 528);
            this.btnGuardaryConsultar.Name = "btnGuardaryConsultar";
            this.btnGuardaryConsultar.Size = new System.Drawing.Size(129, 35);
            this.btnGuardaryConsultar.TabIndex = 0;
            this.btnGuardaryConsultar.Text = "Guardar y Consultar";
            this.btnGuardaryConsultar.UseVisualStyleBackColor = false;
            this.btnGuardaryConsultar.Click += new System.EventHandler(this.btnGuardaryConsultar_Click);
            // 
            // btnSoloGuardarP
            // 
            this.btnSoloGuardarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.btnSoloGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoloGuardarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnSoloGuardarP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSoloGuardarP.Location = new System.Drawing.Point(1018, 528);
            this.btnSoloGuardarP.Name = "btnSoloGuardarP";
            this.btnSoloGuardarP.Size = new System.Drawing.Size(129, 35);
            this.btnSoloGuardarP.TabIndex = 1;
            this.btnSoloGuardarP.Text = "Solo Guardar";
            this.btnSoloGuardarP.UseVisualStyleBackColor = false;
            this.btnSoloGuardarP.Click += new System.EventHandler(this.butSoloGuardarP_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(45, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label103.Location = new System.Drawing.Point(42, 33);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(139, 16);
            this.label103.TabIndex = 69;
            this.label103.Text = "Expediente o Cedula :";
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarP.FlatAppearance.BorderSize = 0;
            this.btnBuscarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(184)))), ((int)(((byte)(73)))));
            this.btnBuscarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarP.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarP.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarP.Image")));
            this.btnBuscarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarP.Location = new System.Drawing.Point(430, 26);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(30, 28);
            this.btnBuscarP.TabIndex = 70;
            this.btnBuscarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarP.UseVisualStyleBackColor = false;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Location = new System.Drawing.Point(197, 30);
            this.txtBuscarP.MaxLength = 11;
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(227, 20);
            this.txtBuscarP.TabIndex = 68;
            this.txtBuscarP.Validar = false;
            this.txtBuscarP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarP_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(982, 26);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(1072, 26);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 72;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ucRegistroP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscarP);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSoloGuardarP);
            this.Controls.Add(this.btnGuardaryConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelDomicilio);
            this.Controls.Add(this.panelOtrosDatos);
            this.Controls.Add(this.panelDatosPersonales);
            this.Name = "ucRegistroP";
            this.Size = new System.Drawing.Size(1184, 571);
            this.Load += new System.EventHandler(this.ucRegistroP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).EndInit();
            this.panelDatosPersonales.ResumeLayout(false);
            this.panelDatosPersonales.PerformLayout();
            this.panelOtrosDatos.ResumeLayout(false);
            this.panelOtrosDatos.PerformLayout();
            this.panelDomicilio.ResumeLayout(false);
            this.panelDomicilio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxValidable txtEdad;
        private TextBoxValidable txtExpediente;
        private System.Windows.Forms.ComboBox cbbEstadoCivil;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechNaci;
        private TextBoxValidable txtApellido;
        private TextBoxValidable txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTipoPaciente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Panel panelDatosPersonales;
        internal System.Windows.Forms.Panel panelOtrosDatos;
        internal System.Windows.Forms.Panel panelDomicilio;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox cbbCiudad;
        internal System.Windows.Forms.ComboBox cbbProvincia;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox cbbZona;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardaryConsultar;
        private System.Windows.Forms.Button btnSoloGuardarP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        internal TextBoxValidable txtBuscarP;
        private System.Windows.Forms.Label label103;
        internal System.Windows.Forms.Button btnBuscarP;
        private TextBoxValidable txtEmail;
        private System.Windows.Forms.Label label18;
        private TextBoxValidable txtCalle;
        private TextBoxValidable txtNumero;
        internal System.Windows.Forms.Label label21;
        private TextBoxValidable txtSector;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private TextBoxValidable txtDomi_ID;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        internal System.Windows.Forms.Label label12;
    }
}
