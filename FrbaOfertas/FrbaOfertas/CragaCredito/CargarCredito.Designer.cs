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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monto = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnInfoTarjeta = new System.Windows.Forms.Button();
            this.comboNumero = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAgregarTarjeta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnInfoCLiente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.monto);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(31, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(628, 242);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Carga";
            // 
            // monto
            // 
            this.monto.DecimalPlaces = 2;
            this.monto.Location = new System.Drawing.Point(15, 114);
            this.monto.Margin = new System.Windows.Forms.Padding(4);
            this.monto.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(244, 22);
            this.monto.TabIndex = 31;
            this.monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboTipo);
            this.groupBox2.Controls.Add(this.lblTipo);
            this.groupBox2.Controls.Add(this.btnInfoTarjeta);
            this.groupBox2.Controls.Add(this.comboNumero);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.btnAgregarTarjeta);
            this.groupBox2.Location = new System.Drawing.Point(293, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(312, 212);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la tarjeta";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.comboTipo.Location = new System.Drawing.Point(103, 91);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(160, 24);
            this.comboTipo.TabIndex = 110;
            this.comboTipo.SelectionChangeCommitted += new System.EventHandler(this.comboTipo_SelectionChangeCommitted);
            this.comboTipo.DropDownClosed += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(31, 95);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 109;
            this.lblTipo.Text = "Tipo";
            // 
            // btnInfoTarjeta
            // 
            this.btnInfoTarjeta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnInfoTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfoTarjeta.FlatAppearance.BorderSize = 0;
            this.btnInfoTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoTarjeta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInfoTarjeta.Location = new System.Drawing.Point(55, 156);
            this.btnInfoTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfoTarjeta.Name = "btnInfoTarjeta";
            this.btnInfoTarjeta.Size = new System.Drawing.Size(229, 30);
            this.btnInfoTarjeta.TabIndex = 108;
            this.btnInfoTarjeta.TabStop = false;
            this.btnInfoTarjeta.Text = "Ver informacion de la tarjeta";
            this.btnInfoTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoTarjeta.UseVisualStyleBackColor = false;
            this.btnInfoTarjeta.Click += new System.EventHandler(this.btnInfoTarjeta_Click);
            // 
            // comboNumero
            // 
            this.comboNumero.FormattingEnabled = true;
            this.comboNumero.Location = new System.Drawing.Point(103, 124);
            this.comboNumero.Margin = new System.Windows.Forms.Padding(4);
            this.comboNumero.Name = "comboNumero";
            this.comboNumero.Size = new System.Drawing.Size(160, 24);
            this.comboNumero.TabIndex = 29;
            this.comboNumero.SelectedIndexChanged += new System.EventHandler(this.comboNumero_SelectedIndexChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(31, 128);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 28;
            this.lblNumero.Text = "Numero";
            // 
            // btnAgregarTarjeta
            // 
            this.btnAgregarTarjeta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTarjeta.Location = new System.Drawing.Point(128, 23);
            this.btnAgregarTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTarjeta.Name = "btnAgregarTarjeta";
            this.btnAgregarTarjeta.Size = new System.Drawing.Size(176, 40);
            this.btnAgregarTarjeta.TabIndex = 27;
            this.btnAgregarTarjeta.Text = "+ Nueva Tarjeta";
            this.btnAgregarTarjeta.UseVisualStyleBackColor = false;
            this.btnAgregarTarjeta.Click += new System.EventHandler(this.btnAgregarTarjeta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Monto (en pesos)";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(204, 359);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(262, 47);
            this.btnCargar.TabIndex = 30;
            this.btnCargar.Text = "Cargar Credito";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(358, 29);
            this.btnSeleccionarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(108, 30);
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
            this.labelUsuario.Location = new System.Drawing.Point(41, 11);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(60, 20);
            this.labelUsuario.TabIndex = 106;
            this.labelUsuario.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(45, 34);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(280, 22);
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
            this.btnInfoCLiente.Location = new System.Drawing.Point(45, 64);
            this.btnInfoCLiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfoCLiente.Name = "btnInfoCLiente";
            this.btnInfoCLiente.Size = new System.Drawing.Size(288, 41);
            this.btnInfoCLiente.TabIndex = 107;
            this.btnInfoCLiente.TabStop = false;
            this.btnInfoCLiente.Text = "Ver información del cliente";
            this.btnInfoCLiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoCLiente.UseVisualStyleBackColor = false;
            this.btnInfoCLiente.Click += new System.EventHandler(this.btnInfoCLiente_Click);
            // 
            // CargarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(665, 417);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnInfoCLiente);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnInfoTarjeta;
        private System.Windows.Forms.ComboBox comboNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}