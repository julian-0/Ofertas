namespace FrbaOfertas.Menu
{
    partial class VentanaMenu
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
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnAbmCli = new System.Windows.Forms.Button();
            this.btnAbmPro = new System.Windows.Forms.Button();
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnOfertar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnEst = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.botonEntregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.Location = new System.Drawing.Point(245, 20);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(109, 25);
            this.labelBienvenida.TabIndex = 1;
            this.labelBienvenida.Text = "Bienvenide";
            this.labelBienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(21, 63);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(141, 23);
            this.btnRoles.TabIndex = 2;
            this.btnRoles.Text = "Gestionar Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnAbmCli
            // 
            this.btnAbmCli.Location = new System.Drawing.Point(229, 63);
            this.btnAbmCli.Name = "btnAbmCli";
            this.btnAbmCli.Size = new System.Drawing.Size(141, 23);
            this.btnAbmCli.TabIndex = 3;
            this.btnAbmCli.Text = "Gestionar Clientes";
            this.btnAbmCli.UseVisualStyleBackColor = true;
            this.btnAbmCli.Click += new System.EventHandler(this.btnAbmCli_Click);
            // 
            // btnAbmPro
            // 
            this.btnAbmPro.Location = new System.Drawing.Point(413, 63);
            this.btnAbmPro.Name = "btnAbmPro";
            this.btnAbmPro.Size = new System.Drawing.Size(141, 23);
            this.btnAbmPro.TabIndex = 4;
            this.btnAbmPro.Text = "Gestionar Proveedores";
            this.btnAbmPro.UseVisualStyleBackColor = true;
            this.btnAbmPro.Click += new System.EventHandler(this.btnAbmPro_Click);
            // 
            // btnRegis
            // 
            this.btnRegis.Location = new System.Drawing.Point(21, 108);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(141, 23);
            this.btnRegis.TabIndex = 5;
            this.btnRegis.Text = "Gestionar Usuarios";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(229, 108);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(141, 23);
            this.btnCarga.TabIndex = 6;
            this.btnCarga.Text = "Cargar credito";
            this.btnCarga.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(413, 108);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(141, 23);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar oferta";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnOfertar
            // 
            this.btnOfertar.Location = new System.Drawing.Point(21, 151);
            this.btnOfertar.Name = "btnOfertar";
            this.btnOfertar.Size = new System.Drawing.Size(141, 23);
            this.btnOfertar.TabIndex = 8;
            this.btnOfertar.Text = "Confeccionar oferta";
            this.btnOfertar.UseVisualStyleBackColor = true;
            this.btnOfertar.Click += new System.EventHandler(this.btnOfertar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(229, 151);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(141, 23);
            this.btnFacturar.TabIndex = 9;
            this.btnFacturar.Text = "Facturacion a proveedor";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnEst
            // 
            this.btnEst.Location = new System.Drawing.Point(413, 151);
            this.btnEst.Name = "btnEst";
            this.btnEst.Size = new System.Drawing.Size(141, 23);
            this.btnEst.TabIndex = 10;
            this.btnEst.Text = "Listado estadistico";
            this.btnEst.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(413, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // botonEntregar
            // 
            this.botonEntregar.Location = new System.Drawing.Point(21, 188);
            this.botonEntregar.Name = "botonEntregar";
            this.botonEntregar.Size = new System.Drawing.Size(141, 23);
            this.botonEntregar.TabIndex = 12;
            this.botonEntregar.Text = "Entregar oferta";
            this.botonEntregar.UseVisualStyleBackColor = true;
            // 
            // VentanaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 228);
            this.Controls.Add(this.botonEntregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEst);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnOfertar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.btnAbmPro);
            this.Controls.Add(this.btnAbmCli);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.labelBienvenida);
            this.Name = "VentanaMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaMenu_FormClosed);
            this.Load += new System.EventHandler(this.VentanaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnAbmCli;
        private System.Windows.Forms.Button btnAbmPro;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnOfertar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnEst;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button botonEntregar;

    }
}