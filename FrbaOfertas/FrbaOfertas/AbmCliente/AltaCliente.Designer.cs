﻿namespace FrbaOfertas.AbmCliente
{
    partial class AltaCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApe = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNuevoUser = new System.Windows.Forms.Button();
            this.txtNoTieneUser = new System.Windows.Forms.TextBox();
            this.textIdUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.signinbutton = new System.Windows.Forms.Button();
            this.errorUserId = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserId)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtLocalidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDom);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(424, 159);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(376, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de domicilio";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidad.Location = new System.Drawing.Point(13, 69);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(320, 25);
            this.txtLocalidad.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Localidad";
            // 
            // txtCodP
            // 
            this.txtCodP.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodP.Location = new System.Drawing.Point(13, 135);
            this.txtCodP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodP.Name = "txtCodP";
            this.txtCodP.Size = new System.Drawing.Size(320, 25);
            this.txtCodP.TabIndex = 7;
            this.txtCodP.Leave += new System.EventHandler(this.txtCodP_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Domicilio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Codigo Postal";
            // 
            // txtDom
            // 
            this.txtDom.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDom.Location = new System.Drawing.Point(13, 201);
            this.txtDom.Margin = new System.Windows.Forms.Padding(4);
            this.txtDom.Name = "txtDom";
            this.txtDom.Size = new System.Drawing.Size(320, 25);
            this.txtDom.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.fechaNac);
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtApe);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(385, 537);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos personales";
            // 
            // fechaNac
            // 
            this.fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNac.Location = new System.Drawing.Point(8, 479);
            this.fechaNac.Margin = new System.Windows.Forms.Padding(4);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(347, 28);
            this.fechaNac.TabIndex = 5;
            this.fechaNac.Value = new System.DateTime(2019, 10, 13, 0, 0, 0, 0);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(8, 219);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(297, 25);
            this.txtDni.TabIndex = 2;
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "DNI";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(8, 69);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(297, 25);
            this.txtNom.TabIndex = 0;
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 457);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha de nacimiento";
            // 
            // txtApe
            // 
            this.txtApe.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApe.Location = new System.Drawing.Point(8, 146);
            this.txtApe.Margin = new System.Windows.Forms.Padding(4);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(297, 25);
            this.txtApe.TabIndex = 1;
            this.txtApe.Leave += new System.EventHandler(this.txtApe_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Apellido";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(8, 304);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(297, 25);
            this.txtTel.TabIndex = 3;
            this.txtTel.Leave += new System.EventHandler(this.txtTel_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 370);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 282);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Telefono";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(8, 393);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(297, 25);
            this.txtMail.TabIndex = 4;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApe
            // 
            this.errorApe.ContainerControl = this;
            // 
            // errorDni
            // 
            this.errorDni.ContainerControl = this;
            // 
            // errorTel
            // 
            this.errorTel.ContainerControl = this;
            // 
            // errorCodP
            // 
            this.errorCodP.ContainerControl = this;
            // 
            // btnNuevoUser
            // 
            this.btnNuevoUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUser.ForeColor = System.Drawing.Color.White;
            this.btnNuevoUser.Location = new System.Drawing.Point(579, 102);
            this.btnNuevoUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoUser.Name = "btnNuevoUser";
            this.btnNuevoUser.Size = new System.Drawing.Size(175, 34);
            this.btnNuevoUser.TabIndex = 3;
            this.btnNuevoUser.Text = "Nuevo Usuario";
            this.btnNuevoUser.UseVisualStyleBackColor = false;
            this.btnNuevoUser.Click += new System.EventHandler(this.btnNuevoUser_Click);
            // 
            // txtNoTieneUser
            // 
            this.txtNoTieneUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoTieneUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTieneUser.Location = new System.Drawing.Point(491, 102);
            this.txtNoTieneUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoTieneUser.Multiline = true;
            this.txtNoTieneUser.Name = "txtNoTieneUser";
            this.txtNoTieneUser.Size = new System.Drawing.Size(97, 49);
            this.txtNoTieneUser.TabIndex = 27;
            this.txtNoTieneUser.Text = "¿No tiene usuario?";
            // 
            // textIdUsuario
            // 
            this.textIdUsuario.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdUsuario.Location = new System.Drawing.Point(448, 46);
            this.textIdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textIdUsuario.Name = "textIdUsuario";
            this.textIdUsuario.Size = new System.Drawing.Size(305, 25);
            this.textIdUsuario.TabIndex = 2;
            this.textIdUsuario.Leave += new System.EventHandler(this.textIdUsuario_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(444, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Usuario vinculado";
            // 
            // signinbutton
            // 
            this.signinbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.signinbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.signinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signinbutton.Location = new System.Drawing.Point(424, 446);
            this.signinbutton.Margin = new System.Windows.Forms.Padding(4);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(376, 55);
            this.signinbutton.TabIndex = 4;
            this.signinbutton.Text = "New Cliente";
            this.signinbutton.UseVisualStyleBackColor = false;
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click);
            // 
            // errorUserId
            // 
            this.errorUserId.ContainerControl = this;
            // 
            // AltaCliente
            // 
            this.AcceptButton = this.signinbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.signinbutton);
            this.Controls.Add(this.btnNuevoUser);
            this.Controls.Add(this.textIdUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNoTieneUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApe;
        private System.Windows.Forms.ErrorProvider errorDni;
        private System.Windows.Forms.ErrorProvider errorTel;
        private System.Windows.Forms.ErrorProvider errorCodP;
        private System.Windows.Forms.Button btnNuevoUser;
        private System.Windows.Forms.TextBox txtNoTieneUser;
        private System.Windows.Forms.TextBox textIdUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.ErrorProvider errorUserId;
    }
}