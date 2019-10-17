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
            ((System.ComponentModel.ISupportInitialize)(this.tablaOfertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaOfertas
            // 
            this.tablaOfertas.AllowUserToAddRows = false;
            this.tablaOfertas.AllowUserToDeleteRows = false;
            this.tablaOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaOfertas.Location = new System.Drawing.Point(12, 65);
            this.tablaOfertas.MultiSelect = false;
            this.tablaOfertas.Name = "tablaOfertas";
            this.tablaOfertas.ReadOnly = true;
            this.tablaOfertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaOfertas.Size = new System.Drawing.Size(639, 214);
            this.tablaOfertas.TabIndex = 0;
            this.tablaOfertas.SelectionChanged += new System.EventHandler(this.tablaOfertas_SelectionChanged);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(341, 295);
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
            this.cantidad.Size = new System.Drawing.Size(60, 20);
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
            this.btnComprar.Location = new System.Drawing.Point(181, 321);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(282, 45);
            this.btnComprar.TabIndex = 23;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
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
            this.labelBienvenida.Location = new System.Drawing.Point(255, 25);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(179, 25);
            this.labelBienvenida.TabIndex = 25;
            this.labelBienvenida.Text = "Ofertas disponibles";
            this.labelBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VentanaComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(663, 378);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.tablaOfertas);
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
    }
}