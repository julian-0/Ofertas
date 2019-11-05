namespace FrbaOfertas.CambioContrasenia
{
    partial class Contrasenia
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
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cambiarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contraseniaTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(29, 63);
            this.usuarioTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(316, 22);
            this.usuarioTxt.TabIndex = 0;
            this.usuarioTxt.TextChanged += new System.EventHandler(this.usuarioTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Contraseña:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cambiarButton
            // 
            this.cambiarButton.BackColor = System.Drawing.Color.LimeGreen;
            this.cambiarButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.cambiarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cambiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cambiarButton.Location = new System.Drawing.Point(196, 217);
            this.cambiarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cambiarButton.Name = "cambiarButton";
            this.cambiarButton.Size = new System.Drawing.Size(151, 55);
            this.cambiarButton.TabIndex = 2;
            this.cambiarButton.Text = "Aceptar";
            this.cambiarButton.UseVisualStyleBackColor = false;
            this.cambiarButton.Click += new System.EventHandler(this.cambiarButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(29, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contraseniaTxt
            // 
            this.contraseniaTxt.Location = new System.Drawing.Point(29, 158);
            this.contraseniaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contraseniaTxt.Name = "contraseniaTxt";
            this.contraseniaTxt.Size = new System.Drawing.Size(316, 22);
            this.contraseniaTxt.TabIndex = 1;
            // 
            // Contrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.contraseniaTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cambiarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Contrasenia";
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cambiarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox contraseniaTxt;
    }
}