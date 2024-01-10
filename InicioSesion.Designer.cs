namespace Ayuntamiento
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImpresion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelReservas = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.rdPuesto3 = new System.Windows.Forms.RadioButton();
            this.rdPuesto2 = new System.Windows.Forms.RadioButton();
            this.rdPuesto1 = new System.Windows.Forms.RadioButton();
            this.cmbPuesto3 = new System.Windows.Forms.ComboBox();
            this.cmbPuesto2 = new System.Windows.Forms.ComboBox();
            this.btnSesion = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbImpresion = new System.Windows.Forms.ComboBox();
            this.cmbPuesto1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.panelInformacion.SuspendLayout();
            this.panelReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.btnSalir);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtContra);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(227, 151);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(493, 175);
            this.panelLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(320, 127);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 46);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(91, 127);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 46);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(184, 59);
            this.txtContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(277, 35);
            this.txtContra.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(184, 9);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(277, 35);
            this.txtUsuario.TabIndex = 2;
            // 
            // panelInformacion
            // 
            this.panelInformacion.BackColor = System.Drawing.Color.Gainsboro;
            this.panelInformacion.Controls.Add(this.lblCodigo);
            this.panelInformacion.Controls.Add(this.lblPrecio);
            this.panelInformacion.Controls.Add(this.lblImpresion);
            this.panelInformacion.Controls.Add(this.lblTitulo);
            this.panelInformacion.Controls.Add(this.label7);
            this.panelInformacion.Controls.Add(this.label8);
            this.panelInformacion.Controls.Add(this.label9);
            this.panelInformacion.Controls.Add(this.btnOK);
            this.panelInformacion.Controls.Add(this.lblHora);
            this.panelInformacion.Controls.Add(this.lblPuesto);
            this.panelInformacion.Controls.Add(this.lblNombre);
            this.panelInformacion.Controls.Add(this.label6);
            this.panelInformacion.Location = new System.Drawing.Point(248, 49);
            this.panelInformacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(441, 423);
            this.panelInformacion.TabIndex = 3;
            this.panelInformacion.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(229, 236);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(91, 26);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(309, 297);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(80, 26);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "label4";
            // 
            // lblImpresion
            // 
            this.lblImpresion.AutoSize = true;
            this.lblImpresion.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpresion.Location = new System.Drawing.Point(31, 297);
            this.lblImpresion.Name = "lblImpresion";
            this.lblImpresion.Size = new System.Drawing.Size(80, 26);
            this.lblImpresion.TabIndex = 9;
            this.lblImpresion.Text = "label4";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(19, 236);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(130, 26);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Impresión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Puesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Hora";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(83, 356);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(251, 53);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(241, 178);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(80, 26);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "label7";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(241, 123);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(80, 26);
            this.lblPuesto.TabIndex = 2;
            this.lblPuesto.Text = "label7";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(241, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 26);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reserva Realizada";
            // 
            // panelReservas
            // 
            this.panelReservas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelReservas.Controls.Add(this.lblUsuario);
            this.panelReservas.Controls.Add(this.rdPuesto3);
            this.panelReservas.Controls.Add(this.rdPuesto2);
            this.panelReservas.Controls.Add(this.rdPuesto1);
            this.panelReservas.Controls.Add(this.cmbPuesto3);
            this.panelReservas.Controls.Add(this.cmbPuesto2);
            this.panelReservas.Controls.Add(this.btnSesion);
            this.panelReservas.Controls.Add(this.btnAceptar);
            this.panelReservas.Controls.Add(this.label5);
            this.panelReservas.Controls.Add(this.cmbImpresion);
            this.panelReservas.Controls.Add(this.cmbPuesto1);
            this.panelReservas.Location = new System.Drawing.Point(147, 51);
            this.panelReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelReservas.Name = "panelReservas";
            this.panelReservas.Size = new System.Drawing.Size(621, 421);
            this.panelReservas.TabIndex = 2;
            this.panelReservas.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(25, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 26);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "label3";
            // 
            // rdPuesto3
            // 
            this.rdPuesto3.AutoSize = true;
            this.rdPuesto3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPuesto3.Location = new System.Drawing.Point(36, 206);
            this.rdPuesto3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPuesto3.Name = "rdPuesto3";
            this.rdPuesto3.Size = new System.Drawing.Size(115, 27);
            this.rdPuesto3.TabIndex = 13;
            this.rdPuesto3.TabStop = true;
            this.rdPuesto3.Text = "Puesto 3";
            this.rdPuesto3.UseVisualStyleBackColor = true;
            this.rdPuesto3.CheckedChanged += new System.EventHandler(this.rdPuesto3_CheckedChanged);
            // 
            // rdPuesto2
            // 
            this.rdPuesto2.AutoSize = true;
            this.rdPuesto2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPuesto2.Location = new System.Drawing.Point(36, 133);
            this.rdPuesto2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPuesto2.Name = "rdPuesto2";
            this.rdPuesto2.Size = new System.Drawing.Size(109, 27);
            this.rdPuesto2.TabIndex = 12;
            this.rdPuesto2.TabStop = true;
            this.rdPuesto2.Text = "Puesto2";
            this.rdPuesto2.UseVisualStyleBackColor = true;
            this.rdPuesto2.CheckedChanged += new System.EventHandler(this.rdPuesto2_CheckedChanged);
            // 
            // rdPuesto1
            // 
            this.rdPuesto1.AutoSize = true;
            this.rdPuesto1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPuesto1.Location = new System.Drawing.Point(36, 67);
            this.rdPuesto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPuesto1.Name = "rdPuesto1";
            this.rdPuesto1.Size = new System.Drawing.Size(109, 27);
            this.rdPuesto1.TabIndex = 11;
            this.rdPuesto1.TabStop = true;
            this.rdPuesto1.Text = "Puesto1";
            this.rdPuesto1.UseVisualStyleBackColor = true;
            this.rdPuesto1.CheckedChanged += new System.EventHandler(this.rdPuesto1_CheckedChanged);
            // 
            // cmbPuesto3
            // 
            this.cmbPuesto3.Enabled = false;
            this.cmbPuesto3.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto3.FormattingEnabled = true;
            this.cmbPuesto3.Location = new System.Drawing.Point(184, 204);
            this.cmbPuesto3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPuesto3.Name = "cmbPuesto3";
            this.cmbPuesto3.Size = new System.Drawing.Size(407, 29);
            this.cmbPuesto3.TabIndex = 10;
            // 
            // cmbPuesto2
            // 
            this.cmbPuesto2.Enabled = false;
            this.cmbPuesto2.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto2.FormattingEnabled = true;
            this.cmbPuesto2.Location = new System.Drawing.Point(184, 131);
            this.cmbPuesto2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPuesto2.Name = "cmbPuesto2";
            this.cmbPuesto2.Size = new System.Drawing.Size(407, 29);
            this.cmbPuesto2.TabIndex = 8;
            // 
            // btnSesion
            // 
            this.btnSesion.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.Location = new System.Drawing.Point(321, 308);
            this.btnSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(221, 79);
            this.btnSesion.TabIndex = 3;
            this.btnSesion.Text = "Cerrar sesión";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(57, 308);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(221, 79);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Impresión";
            // 
            // cmbImpresion
            // 
            this.cmbImpresion.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImpresion.FormattingEnabled = true;
            this.cmbImpresion.Location = new System.Drawing.Point(201, 256);
            this.cmbImpresion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbImpresion.Name = "cmbImpresion";
            this.cmbImpresion.Size = new System.Drawing.Size(357, 29);
            this.cmbImpresion.TabIndex = 4;
            // 
            // cmbPuesto1
            // 
            this.cmbPuesto1.Enabled = false;
            this.cmbPuesto1.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto1.FormattingEnabled = true;
            this.cmbPuesto1.Location = new System.Drawing.Point(184, 65);
            this.cmbPuesto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPuesto1.Name = "cmbPuesto1";
            this.cmbPuesto1.Size = new System.Drawing.Size(407, 29);
            this.cmbPuesto1.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 553);
            this.Controls.Add(this.panelInformacion);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuntamiento de Rucandio: Central de reservas";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            this.panelReservas.ResumeLayout(false);
            this.panelReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panelReservas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbImpresion;
        private System.Windows.Forms.ComboBox cmbPuesto1;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPuesto3;
        private System.Windows.Forms.ComboBox cmbPuesto2;
        private System.Windows.Forms.RadioButton rdPuesto3;
        private System.Windows.Forms.RadioButton rdPuesto2;
        private System.Windows.Forms.RadioButton rdPuesto1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImpresion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCodigo;
    }
}

