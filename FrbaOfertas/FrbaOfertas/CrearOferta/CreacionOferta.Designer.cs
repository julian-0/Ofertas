namespace FrbaOfertas.CrearOferta
{
    partial class CreacionOferta
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
            this.components = new System.ComponentModel.Container();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.numericPrecioOferta = new System.Windows.Forms.NumericUpDown();
            this.numericPrecioOriginal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarProveedor = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.buttonInformacionProveedor = new System.Windows.Forms.Button();
            this.groupCant = new System.Windows.Forms.GroupBox();
            this.numericMaxUsuario = new System.Windows.Forms.NumericUpDown();
            this.numericStock = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupVigencia = new System.Windows.Forms.GroupBox();
            this.numericPlazo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCrearOferta = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioOriginal)).BeginInit();
            this.groupCant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).BeginInit();
            this.groupVigencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlazo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatos
            // 
            this.groupDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupDatos.AutoSize = true;
            this.groupDatos.Controls.Add(this.numericPrecioOferta);
            this.groupDatos.Controls.Add(this.numericPrecioOriginal);
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Controls.Add(this.textBoxDescripcion);
            this.groupDatos.Controls.Add(this.buttonSeleccionarProveedor);
            this.groupDatos.Controls.Add(this.labelUsuario);
            this.groupDatos.Controls.Add(this.textBoxProveedor);
            this.groupDatos.Controls.Add(this.buttonInformacionProveedor);
            this.groupDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatos.Location = new System.Drawing.Point(16, 32);
            this.groupDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDatos.Size = new System.Drawing.Size(382, 347);
            this.groupDatos.TabIndex = 0;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos";
            // 
            // numericPrecioOferta
            // 
            this.numericPrecioOferta.DecimalPlaces = 2;
            this.numericPrecioOferta.Location = new System.Drawing.Point(229, 298);
            this.numericPrecioOferta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericPrecioOferta.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numericPrecioOferta.Name = "numericPrecioOferta";
            this.numericPrecioOferta.Size = new System.Drawing.Size(104, 26);
            this.numericPrecioOferta.TabIndex = 4;
            this.numericPrecioOferta.ThousandsSeparator = true;
            // 
            // numericPrecioOriginal
            // 
            this.numericPrecioOriginal.DecimalPlaces = 2;
            this.numericPrecioOriginal.Location = new System.Drawing.Point(40, 297);
            this.numericPrecioOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericPrecioOriginal.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numericPrecioOriginal.Name = "numericPrecioOriginal";
            this.numericPrecioOriginal.Size = new System.Drawing.Size(104, 26);
            this.numericPrecioOriginal.TabIndex = 3;
            this.numericPrecioOriginal.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio Original ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Precio Oferta ($)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Descripción de la Oferta";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(40, 158);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(310, 97);
            this.textBoxDescripcion.TabIndex = 2;
            // 
            // buttonSeleccionarProveedor
            // 
            this.buttonSeleccionarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionarProveedor.Location = new System.Drawing.Point(268, 66);
            this.buttonSeleccionarProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSeleccionarProveedor.Name = "buttonSeleccionarProveedor";
            this.buttonSeleccionarProveedor.Size = new System.Drawing.Size(81, 24);
            this.buttonSeleccionarProveedor.TabIndex = 1;
            this.buttonSeleccionarProveedor.Text = "Seleccionar";
            this.buttonSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.buttonSeleccionarProveedor.Click += new System.EventHandler(this.buttonSeleccionarProveedor_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsuario.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(37, 47);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(130, 15);
            this.labelUsuario.TabIndex = 10;
            this.labelUsuario.Text = "Usuario del Proveedor";
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(40, 66);
            this.textBoxProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.ReadOnly = true;
            this.textBoxProveedor.Size = new System.Drawing.Size(211, 26);
            this.textBoxProveedor.TabIndex = 0;
            this.textBoxProveedor.TextChanged += new System.EventHandler(this.textBoxProveedor_TextChanged);
            // 
            // buttonInformacionProveedor
            // 
            this.buttonInformacionProveedor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonInformacionProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInformacionProveedor.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonInformacionProveedor.FlatAppearance.BorderSize = 0;
            this.buttonInformacionProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformacionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInformacionProveedor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInformacionProveedor.Location = new System.Drawing.Point(36, 86);
            this.buttonInformacionProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInformacionProveedor.Name = "buttonInformacionProveedor";
            this.buttonInformacionProveedor.Size = new System.Drawing.Size(216, 33);
            this.buttonInformacionProveedor.TabIndex = 99;
            this.buttonInformacionProveedor.TabStop = false;
            this.buttonInformacionProveedor.Text = "Ver información del proveedor";
            this.buttonInformacionProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInformacionProveedor.UseVisualStyleBackColor = false;
            this.buttonInformacionProveedor.Click += new System.EventHandler(this.buttonInformacionProveedor_Click);
            // 
            // groupCant
            // 
            this.groupCant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCant.AutoSize = true;
            this.groupCant.Controls.Add(this.numericMaxUsuario);
            this.groupCant.Controls.Add(this.numericStock);
            this.groupCant.Controls.Add(this.label5);
            this.groupCant.Controls.Add(this.label4);
            this.groupCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCant.Location = new System.Drawing.Point(424, 32);
            this.groupCant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupCant.Name = "groupCant";
            this.groupCant.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupCant.Size = new System.Drawing.Size(255, 171);
            this.groupCant.TabIndex = 1;
            this.groupCant.TabStop = false;
            this.groupCant.Text = "Cantidades";
            // 
            // numericMaxUsuario
            // 
            this.numericMaxUsuario.Location = new System.Drawing.Point(31, 117);
            this.numericMaxUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericMaxUsuario.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numericMaxUsuario.Name = "numericMaxUsuario";
            this.numericMaxUsuario.Size = new System.Drawing.Size(158, 26);
            this.numericMaxUsuario.TabIndex = 1;
            this.numericMaxUsuario.ThousandsSeparator = true;
            // 
            // numericStock
            // 
            this.numericStock.Location = new System.Drawing.Point(31, 58);
            this.numericStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericStock.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numericStock.Name = "numericStock";
            this.numericStock.Size = new System.Drawing.Size(158, 26);
            this.numericStock.TabIndex = 0;
            this.numericStock.ThousandsSeparator = true;
            this.numericStock.ValueChanged += new System.EventHandler(this.numericStock_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Compra máxima por usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock disponible (unidades)";
            // 
            // groupVigencia
            // 
            this.groupVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupVigencia.AutoSize = true;
            this.groupVigencia.Controls.Add(this.numericPlazo);
            this.groupVigencia.Controls.Add(this.label8);
            this.groupVigencia.Controls.Add(this.label7);
            this.groupVigencia.Controls.Add(this.label6);
            this.groupVigencia.Controls.Add(this.fechaHasta);
            this.groupVigencia.Controls.Add(this.fechaDesde);
            this.groupVigencia.Controls.Add(this.label9);
            this.groupVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupVigencia.Location = new System.Drawing.Point(424, 206);
            this.groupVigencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupVigencia.Name = "groupVigencia";
            this.groupVigencia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupVigencia.Size = new System.Drawing.Size(255, 172);
            this.groupVigencia.TabIndex = 2;
            this.groupVigencia.TabStop = false;
            this.groupVigencia.Text = "Vigencia";
            // 
            // numericPlazo
            // 
            this.numericPlazo.Location = new System.Drawing.Point(28, 123);
            this.numericPlazo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericPlazo.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericPlazo.Name = "numericPlazo";
            this.numericPlazo.Size = new System.Drawing.Size(113, 26);
            this.numericPlazo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Plazo entrega (días)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Desde";
            // 
            // fechaHasta
            // 
            this.fechaHasta.CustomFormat = "yyy-MM-dd";
            this.fechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaHasta.Location = new System.Drawing.Point(141, 61);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(86, 19);
            this.fechaHasta.TabIndex = 1;
            this.fechaHasta.ValueChanged += new System.EventHandler(this.fechaHasta_ValueChanged);
            // 
            // fechaDesde
            // 
            this.fechaDesde.CustomFormat = "yyy-MM-dd";
            this.fechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDesde.Location = new System.Drawing.Point(28, 61);
            this.fechaDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(84, 19);
            this.fechaDesde.TabIndex = 0;
            this.fechaDesde.Value = new System.DateTime(2019, 10, 25, 0, 0, 0, 0);
            this.fechaDesde.ValueChanged += new System.EventHandler(this.fechaDesde_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(7, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "ⓘ";
            this.toolTip1.SetToolTip(this.label9, "Cantidad de días desde la fecha de la compra\r\nque tiene el comprador para retirar" +
        " la Oferta");
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // buttonCrearOferta
            // 
            this.buttonCrearOferta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrearOferta.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCrearOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonCrearOferta.ForeColor = System.Drawing.Color.White;
            this.buttonCrearOferta.Location = new System.Drawing.Point(424, 395);
            this.buttonCrearOferta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCrearOferta.Name = "buttonCrearOferta";
            this.buttonCrearOferta.Size = new System.Drawing.Size(254, 37);
            this.buttonCrearOferta.TabIndex = 3;
            this.buttonCrearOferta.Text = "Crear Oferta";
            this.buttonCrearOferta.UseVisualStyleBackColor = false;
            this.buttonCrearOferta.Click += new System.EventHandler(this.buttonCrearOferta_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // CreacionOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 449);
            this.Controls.Add(this.buttonCrearOferta);
            this.Controls.Add(this.groupVigencia);
            this.Controls.Add(this.groupCant);
            this.Controls.Add(this.groupDatos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreacionOferta";
            this.Text = "Crear Oferta";
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioOriginal)).EndInit();
            this.groupCant.ResumeLayout(false);
            this.groupCant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).EndInit();
            this.groupVigencia.ResumeLayout(false);
            this.groupVigencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlazo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.GroupBox groupCant;
        private System.Windows.Forms.GroupBox groupVigencia;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonInformacionProveedor;
        private System.Windows.Forms.Button buttonSeleccionarProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCrearOferta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericPrecioOriginal;
        private System.Windows.Forms.NumericUpDown numericPrecioOferta;
        private System.Windows.Forms.NumericUpDown numericMaxUsuario;
        private System.Windows.Forms.NumericUpDown numericStock;
        private System.Windows.Forms.NumericUpDown numericPlazo;
    }
}