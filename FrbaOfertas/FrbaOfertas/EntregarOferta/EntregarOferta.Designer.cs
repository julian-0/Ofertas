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
            this.components = new System.ComponentModel.Container();
            this.cupon = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.buttonConsumirCupon = new System.Windows.Forms.Button();
            this.errorCupon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorCupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // cupon
            // 
            this.cupon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cupon.Location = new System.Drawing.Point(12, 76);
            this.cupon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cupon.Name = "cupon";
            this.cupon.Size = new System.Drawing.Size(235, 22);
            this.cupon.TabIndex = 1;
            this.cupon.TextChanged += new System.EventHandler(this.cupon_TextChanged);
            this.cupon.Leave += new System.EventHandler(this.cupon_leave);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.White;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(9, 56);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(206, 18);
            this.labelUsuario.TabIndex = 11;
            this.labelUsuario.Text = "Codigo del cupon consumido:";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(11, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cliente que lo retira:";
            // 
            // cliente
            // 
            this.cliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cliente.Location = new System.Drawing.Point(14, 185);
            this.cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(233, 22);
            this.cliente.TabIndex = 13;
            this.cliente.Leave += new System.EventHandler(this.cliente_leave);
            // 
            // buttonConsumirCupon
            // 
            this.buttonConsumirCupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConsumirCupon.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConsumirCupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonConsumirCupon.ForeColor = System.Drawing.Color.White;
            this.buttonConsumirCupon.Location = new System.Drawing.Point(15, 249);
            this.buttonConsumirCupon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConsumirCupon.Name = "buttonConsumirCupon";
            this.buttonConsumirCupon.Size = new System.Drawing.Size(349, 46);
            this.buttonConsumirCupon.TabIndex = 14;
            this.buttonConsumirCupon.Text = "Consumir";
            this.buttonConsumirCupon.UseVisualStyleBackColor = false;
            this.buttonConsumirCupon.Click += new System.EventHandler(this.buttonConsumirCupon_Click);
            // 
            // errorCupon
            // 
            this.errorCupon.ContainerControl = this;
            // 
            // errorCliente
            // 
            this.errorCliente.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EntregaOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConsumirCupon);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.cupon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EntregaOferta";
            this.Text = "Entrega";
            ((System.ComponentModel.ISupportInitialize)(this.errorCupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cupon;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Button buttonConsumirCupon;
        private System.Windows.Forms.ErrorProvider errorCupon;
        private System.Windows.Forms.ErrorProvider errorCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}