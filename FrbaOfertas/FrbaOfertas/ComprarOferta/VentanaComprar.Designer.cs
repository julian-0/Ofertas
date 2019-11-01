namespace FrbaOfertas.ComprarOferta
{
    partial class VentanaComprar
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
            this.tablaOfertas = new System.Windows.Forms.DataGridView();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnInfoCLiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOfertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaOfertas
            // 
            this.tablaOfertas.AllowUserToAddRows = false;
            this.tablaOfertas.AllowUserToDeleteRows = false;
            this.tablaOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaOfertas.Location = new System.Drawing.Point(16, 80);
            this.tablaOfertas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaOfertas.MultiSelect = false;
            this.tablaOfertas.Name = "tablaOfertas";
            this.tablaOfertas.ReadOnly = true;
            this.tablaOfertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaOfertas.Size = new System.Drawing.Size(852, 263);
            this.tablaOfertas.TabIndex = 0;
            this.tablaOfertas.SelectionChanged += new System.EventHandler(this.tablaOfertas_SelectionChanged);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(693, 366);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidad.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(80, 22);
            this.cantidad.TabIndex = 2;
            this.cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComprar.Location = new System.Drawing.Point(480, 398);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(376, 55);
            this.btnComprar.TabIndex = 23;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 368);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cantidad";
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.Location = new System.Drawing.Point(340, 31);
            this.labelBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(230, 29);
            this.labelBienvenida.TabIndex = 25;
            this.labelBienvenida.Text = "Ofertas disponibles";
            this.labelBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(16, 412);
            this.btnSeleccionarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(108, 30);
            this.btnSeleccionarCliente.TabIndex = 101;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsuario.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(12, 359);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(161, 20);
            this.labelUsuario.TabIndex = 102;
            this.labelUsuario.Text = "Cliente seleccionado:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(16, 383);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(280, 22);
            this.txtCliente.TabIndex = 100;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
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
            this.btnInfoCLiente.Location = new System.Drawing.Point(9, 430);
            this.btnInfoCLiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfoCLiente.Name = "btnInfoCLiente";
            this.btnInfoCLiente.Size = new System.Drawing.Size(288, 41);
            this.btnInfoCLiente.TabIndex = 103;
            this.btnInfoCLiente.TabStop = false;
            this.btnInfoCLiente.Text = "Ver información del cliente";
            this.btnInfoCLiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoCLiente.UseVisualStyleBackColor = false;
            this.btnInfoCLiente.Click += new System.EventHandler(this.btnInfoCLiente_Click);
            // 
            // VentanaComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 465);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnInfoCLiente);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.tablaOfertas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaComprar";
            this.Text = "Comprar Oferta";
            this.Load += new System.EventHandler(this.ComprarOferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaOfertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaOfertas;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnInfoCLiente;
    }
}