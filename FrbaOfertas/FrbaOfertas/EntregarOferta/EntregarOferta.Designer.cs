namespace FrbaOfertas.EntregarOferta
{
    partial class EntregaOferta
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
            this.cupon = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.buttonConsumirCupon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cupon
            // 
            this.cupon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cupon.Location = new System.Drawing.Point(11, 52);
            this.cupon.Margin = new System.Windows.Forms.Padding(2);
            this.cupon.Name = "cupon";
            this.cupon.ReadOnly = true;
            this.cupon.Size = new System.Drawing.Size(262, 20);
            this.cupon.TabIndex = 1;
            this.cupon.TextChanged += new System.EventHandler(this.cupon_TextChanged);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.White;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(8, 24);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(222, 15);
            this.labelUsuario.TabIndex = 11;
            this.labelUsuario.Text = "Ingrese el codigo de cupon consumido:";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese código del cliente que lo consumió:";
            // 
            // cliente
            // 
            this.cliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cliente.Location = new System.Drawing.Point(11, 119);
            this.cliente.Margin = new System.Windows.Forms.Padding(2);
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Size = new System.Drawing.Size(262, 20);
            this.cliente.TabIndex = 13;
            // 
            // buttonConsumirCupon
            // 
            this.buttonConsumirCupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConsumirCupon.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConsumirCupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonConsumirCupon.ForeColor = System.Drawing.Color.White;
            this.buttonConsumirCupon.Location = new System.Drawing.Point(11, 202);
            this.buttonConsumirCupon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsumirCupon.Name = "buttonConsumirCupon";
            this.buttonConsumirCupon.Size = new System.Drawing.Size(262, 37);
            this.buttonConsumirCupon.TabIndex = 14;
            this.buttonConsumirCupon.Text = "Consumir";
            this.buttonConsumirCupon.UseVisualStyleBackColor = false;
            this.buttonConsumirCupon.Click += new System.EventHandler(this.buttonConsumirCupon_Click);
            // 
            // EntregaOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonConsumirCupon);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.cupon);
            this.Name = "EntregaOferta";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cupon;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Button buttonConsumirCupon;

    }
}