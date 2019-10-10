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
            this.funcionalidadesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // funcionalidadesGrid
            // 
            this.funcionalidadesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionalidadesGrid.Location = new System.Drawing.Point(51, 66);
            this.funcionalidadesGrid.Name = "funcionalidadesGrid";
            this.funcionalidadesGrid.Size = new System.Drawing.Size(360, 150);
            this.funcionalidadesGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionalidades";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VentanaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.funcionalidadesGrid);
            this.Name = "VentanaMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.VentanaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView funcionalidadesGrid;
        private System.Windows.Forms.Label label1;

    }
}