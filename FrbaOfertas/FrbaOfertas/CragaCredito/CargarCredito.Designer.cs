namespace FrbaOfertas.CragaCredito
{
    partial class CargarCredito
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monto = new System.Windows.Forms.NumericUpDown();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnInfoCLiente = new System.Windows.Forms.Button();
            this.btnAgregarTarjeta = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.comboTarjeta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Elija su tarjeta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.monto);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(23, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 159);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Carga";
            // 
            // monto
            // 
            this.monto.DecimalPlaces = 2;
            this.monto.Location = new System.Drawing.Point(12, 49);
            this.monto.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(183, 20);
            this.monto.TabIndex = 31;
            this.monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(151, 254);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(183, 36);
            this.btnCargar.TabIndex = 30;
            this.btnCargar.Text = "Cargar Credito";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboTarjeta);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.btnAgregarTarjeta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(220, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 122);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Monto (en pesos)";
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(272, 28);
            this.btnSeleccionarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(81, 24);
            this.btnSeleccionarCliente.TabIndex = 105;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsuario.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(31, 9);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(111, 15);
            this.labelUsuario.TabIndex = 106;
            this.labelUsuario.Text = "Usuario del Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(34, 28);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(211, 20);
            this.txtCliente.TabIndex = 104;
            // 
            // btnInfoCLiente
            // 
            this.btnInfoCLiente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnInfoCLiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoCLiente.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfoCLiente.FlatAppearance.BorderSize = 0;
            this.btnInfoCLiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoCLiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoCLiente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInfoCLiente.Location = new System.Drawing.Point(34, 52);
            this.btnInfoCLiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfoCLiente.Name = "btnInfoCLiente";
            this.btnInfoCLiente.Size = new System.Drawing.Size(216, 33);
            this.btnInfoCLiente.TabIndex = 107;
            this.btnInfoCLiente.TabStop = false;
            this.btnInfoCLiente.Text = "Ver información del cliente";
            this.btnInfoCLiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoCLiente.UseVisualStyleBackColor = false;
            this.btnInfoCLiente.Click += new System.EventHandler(this.btnInfoCLiente_Click);
            // 
            // btnAgregarTarjeta
            // 
            this.btnAgregarTarjeta.Location = new System.Drawing.Point(98, 92);
            this.btnAgregarTarjeta.Name = "btnAgregarTarjeta";
            this.btnAgregarTarjeta.Size = new System.Drawing.Size(103, 23);
            this.btnAgregarTarjeta.TabIndex = 27;
            this.btnAgregarTarjeta.Text = "+ Agregar Tarjeta";
            this.btnAgregarTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 45);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 28;
            this.lblNumero.Text = "Numero";
            // 
            // comboTarjeta
            // 
            this.comboTarjeta.FormattingEnabled = true;
            this.comboTarjeta.Location = new System.Drawing.Point(80, 42);
            this.comboTarjeta.Name = "comboTarjeta";
            this.comboTarjeta.Size = new System.Drawing.Size(121, 21);
            this.comboTarjeta.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(42, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 24);
            this.button1.TabIndex = 108;
            this.button1.TabStop = false;
            this.button1.Text = "Ver informacion de la tarjeta";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CargarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(499, 308);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnInfoCLiente);
            this.Controls.Add(this.groupBox1);
            this.Name = "CargarCredito";
            this.Text = "CargarCredito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnInfoCLiente;
        private System.Windows.Forms.NumericUpDown monto;
        private System.Windows.Forms.Button btnAgregarTarjeta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboTarjeta;
        private System.Windows.Forms.Label lblNumero;
    }
}