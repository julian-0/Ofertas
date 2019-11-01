namespace FrbaOfertas.EntregarOferta
{
    partial class Cupones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProvExistentes = new System.Windows.Forms.GroupBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comprador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tablaCupones = new System.Windows.Forms.DataGridView();
            this.ProvExistentes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCupones)).BeginInit();
            this.SuspendLayout();
            // 
            // ProvExistentes
            // 
            this.ProvExistentes.Controls.Add(this.btnSeleccion);
            this.ProvExistentes.Controls.Add(this.groupBox2);
            this.ProvExistentes.Controls.Add(this.tablaCupones);
            this.ProvExistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvExistentes.Location = new System.Drawing.Point(16, 62);
            this.ProvExistentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProvExistentes.Name = "ProvExistentes";
            this.ProvExistentes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProvExistentes.Size = new System.Drawing.Size(1281, 586);
            this.ProvExistentes.TabIndex = 57;
            this.ProvExistentes.TabStop = false;
            this.ProvExistentes.Text = "Cupones Existentes";
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.Lime;
            this.btnSeleccion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSeleccion.Location = new System.Drawing.Point(1065, 481);
            this.btnSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(156, 46);
            this.btnSeleccion.TabIndex = 36;
            this.btnSeleccion.Text = "Seleccionar";
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comprador);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(339, 437);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(691, 129);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(258, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 25);
            this.button1.TabIndex = 56;
            this.button1.Text = "Elegir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comprador
            // 
            this.comprador.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprador.Location = new System.Drawing.Point(21, 88);
            this.comprador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comprador.Name = "comprador";
            this.comprador.Size = new System.Drawing.Size(231, 25);
            this.comprador.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Comprador";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(21, 41);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 25);
            this.txtNombre.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Codigo Oferta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(551, 25);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 43);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tablaCupones
            // 
            this.tablaCupones.AllowUserToAddRows = false;
            this.tablaCupones.AllowUserToDeleteRows = false;
            this.tablaCupones.AllowUserToResizeRows = false;
            this.tablaCupones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaCupones.BackgroundColor = System.Drawing.Color.White;
            this.tablaCupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCupones.EnableHeadersVisualStyles = false;
            this.tablaCupones.Location = new System.Drawing.Point(27, 48);
            this.tablaCupones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaCupones.MultiSelect = false;
            this.tablaCupones.Name = "tablaCupones";
            this.tablaCupones.ReadOnly = true;
            this.tablaCupones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaCupones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaCupones.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaCupones.RowTemplate.Height = 24;
            this.tablaCupones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCupones.Size = new System.Drawing.Size(1219, 362);
            this.tablaCupones.TabIndex = 0;
            this.tablaCupones.SelectionChanged += new System.EventHandler(this.tablaCupones_SelectionChanged);
            // 
            // Cupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 652);
            this.Controls.Add(this.ProvExistentes);
            this.Name = "Cupones";
            this.Text = "Cupones";
            this.ProvExistentes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCupones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProvExistentes;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox comprador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView tablaCupones;
        private System.Windows.Forms.Button button1;
    }
}