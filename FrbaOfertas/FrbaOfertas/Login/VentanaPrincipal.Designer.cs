namespace FrbaOfertas
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.signinbutton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signinbutton
            // 
            this.signinbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.signinbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.signinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signinbutton.Location = new System.Drawing.Point(25, 195);
            this.signinbutton.Margin = new System.Windows.Forms.Padding(4);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(317, 55);
            this.signinbutton.TabIndex = 2;
            this.signinbutton.Text = "Sign in Cupones";
            this.signinbutton.UseVisualStyleBackColor = false;
            this.signinbutton.Click += new System.EventHandler(this.Signinbutton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(25, 141);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(316, 22);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.UsuarioTxt_TextChanged);
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(25, 56);
            this.usuarioTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(316, 22);
            this.usuarioTxt.TabIndex = 0;
            this.usuarioTxt.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(24, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear Cuenta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(368, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signinbutton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

