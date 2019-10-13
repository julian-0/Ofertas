namespace FrbaOfertas.AbmCliente
{
    partial class GestionarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAlta = new System.Windows.Forms.Button();
            this.groupMasFiltros = new System.Windows.Forms.GroupBox();
            this.mostrarHabilitados = new System.Windows.Forms.CheckBox();
            this.mostrarInhabilitados = new System.Windows.Forms.CheckBox();
            this.localidad = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.nombre_de_contacto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProvExistentes = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.razonSocial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rubro = new System.Windows.Forms.ComboBox();
            this.cuit = new System.Windows.Forms.TextBox();
            this.mostrarMas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupMasFiltros.SuspendLayout();
            this.ProvExistentes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(698, 23);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(236, 52);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "+ NUEVO CLIENTE";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // groupMasFiltros
            // 
            this.groupMasFiltros.BackColor = System.Drawing.Color.White;
            this.groupMasFiltros.Controls.Add(this.mostrarHabilitados);
            this.groupMasFiltros.Controls.Add(this.mostrarInhabilitados);
            this.groupMasFiltros.Controls.Add(this.localidad);
            this.groupMasFiltros.Controls.Add(this.email);
            this.groupMasFiltros.Controls.Add(this.label11);
            this.groupMasFiltros.Controls.Add(this.ciudad);
            this.groupMasFiltros.Controls.Add(this.telefono);
            this.groupMasFiltros.Controls.Add(this.nombre_de_contacto);
            this.groupMasFiltros.Controls.Add(this.label4);
            this.groupMasFiltros.Controls.Add(this.label8);
            this.groupMasFiltros.Controls.Add(this.text3);
            this.groupMasFiltros.Controls.Add(this.label5);
            this.groupMasFiltros.Location = new System.Drawing.Point(11, 570);
            this.groupMasFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.groupMasFiltros.Name = "groupMasFiltros";
            this.groupMasFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.groupMasFiltros.Size = new System.Drawing.Size(961, 124);
            this.groupMasFiltros.TabIndex = 55;
            this.groupMasFiltros.TabStop = false;
            // 
            // mostrarHabilitados
            // 
            this.mostrarHabilitados.AutoSize = true;
            this.mostrarHabilitados.Checked = true;
            this.mostrarHabilitados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarHabilitados.Location = new System.Drawing.Point(800, 56);
            this.mostrarHabilitados.Margin = new System.Windows.Forms.Padding(2);
            this.mostrarHabilitados.Name = "mostrarHabilitados";
            this.mostrarHabilitados.Size = new System.Drawing.Size(116, 17);
            this.mostrarHabilitados.TabIndex = 50;
            this.mostrarHabilitados.Text = "Mostrar Habilitados";
            this.mostrarHabilitados.UseVisualStyleBackColor = true;
            // 
            // mostrarInhabilitados
            // 
            this.mostrarInhabilitados.AutoSize = true;
            this.mostrarInhabilitados.Location = new System.Drawing.Point(800, 78);
            this.mostrarInhabilitados.Margin = new System.Windows.Forms.Padding(2);
            this.mostrarInhabilitados.Name = "mostrarInhabilitados";
            this.mostrarInhabilitados.Size = new System.Drawing.Size(123, 17);
            this.mostrarInhabilitados.TabIndex = 49;
            this.mostrarInhabilitados.Text = "Mostrar Inhabilitados";
            this.mostrarInhabilitados.UseVisualStyleBackColor = true;
            // 
            // localidad
            // 
            this.localidad.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidad.Location = new System.Drawing.Point(564, 38);
            this.localidad.Margin = new System.Windows.Forms.Padding(2);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(174, 22);
            this.localidad.TabIndex = 46;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(349, 38);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(174, 22);
            this.email.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(346, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ciudad";
            // 
            // ciudad
            // 
            this.ciudad.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad.Location = new System.Drawing.Point(350, 80);
            this.ciudad.Margin = new System.Windows.Forms.Padding(2);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(174, 22);
            this.ciudad.TabIndex = 43;
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(140, 36);
            this.telefono.Margin = new System.Windows.Forms.Padding(2);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(174, 22);
            this.telefono.TabIndex = 36;
            // 
            // nombre_de_contacto
            // 
            this.nombre_de_contacto.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_de_contacto.Location = new System.Drawing.Point(140, 80);
            this.nombre_de_contacto.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_de_contacto.Name = "nombre_de_contacto";
            this.nombre_de_contacto.Size = new System.Drawing.Size(174, 22);
            this.nombre_de_contacto.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Localidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Usuario";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.text3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(138, 21);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(55, 15);
            this.text3.TabIndex = 35;
            this.text3.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Codigo Postal";
            // 
            // ProvExistentes
            // 
            this.ProvExistentes.Controls.Add(this.button4);
            this.ProvExistentes.Controls.Add(this.button3);
            this.ProvExistentes.Controls.Add(this.groupBox2);
            this.ProvExistentes.Controls.Add(this.dataGridView1);
            this.ProvExistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvExistentes.Location = new System.Drawing.Point(11, 96);
            this.ProvExistentes.Margin = new System.Windows.Forms.Padding(2);
            this.ProvExistentes.Name = "ProvExistentes";
            this.ProvExistentes.Padding = new System.Windows.Forms.Padding(2);
            this.ProvExistentes.Size = new System.Drawing.Size(961, 465);
            this.ProvExistentes.TabIndex = 56;
            this.ProvExistentes.TabStop = false;
            this.ProvExistentes.Text = "Clientes Existentes";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(20, 419);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 32);
            this.button4.TabIndex = 35;
            this.button4.Text = "Eliminar Seleccionado";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(20, 375);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 32);
            this.button3.TabIndex = 34;
            this.button3.Text = "Modificar Seleccionado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.razonSocial);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.rubro);
            this.groupBox2.Controls.Add(this.cuit);
            this.groupBox2.Controls.Add(this.mostrarMas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(254, 355);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(518, 105);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // razonSocial
            // 
            this.razonSocial.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razonSocial.Location = new System.Drawing.Point(16, 35);
            this.razonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(174, 22);
            this.razonSocial.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(400, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 35);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rubro
            // 
            this.rubro.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(16, 72);
            this.rubro.Margin = new System.Windows.Forms.Padding(2);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(174, 23);
            this.rubro.TabIndex = 41;
            // 
            // cuit
            // 
            this.cuit.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuit.Location = new System.Drawing.Point(208, 74);
            this.cuit.Margin = new System.Windows.Forms.Padding(2);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(174, 22);
            this.cuit.TabIndex = 37;
            // 
            // mostrarMas
            // 
            this.mostrarMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarMas.Location = new System.Drawing.Point(400, 76);
            this.mostrarMas.Margin = new System.Windows.Forms.Padding(2);
            this.mostrarMas.Name = "mostrarMas";
            this.mostrarMas.Size = new System.Drawing.Size(94, 19);
            this.mostrarMas.TabIndex = 51;
            this.mostrarMas.Text = "▼  Más filtros";
            this.mostrarMas.UseVisualStyleBackColor = true;
            this.mostrarMas.Click += new System.EventHandler(this.mostrarMas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Apellido";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(208, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 22);
            this.textBox1.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(206, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "DNI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // GestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(979, 609);
            this.Controls.Add(this.groupMasFiltros);
            this.Controls.Add(this.ProvExistentes);
            this.Controls.Add(this.btnAlta);
            this.Name = "GestionarClientes";
            this.Text = "ABM Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionarClientes_FormClosed);
            this.Load += new System.EventHandler(this.GestionarClientes_Load);
            this.groupMasFiltros.ResumeLayout(false);
            this.groupMasFiltros.PerformLayout();
            this.ProvExistentes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.GroupBox groupMasFiltros;
        private System.Windows.Forms.CheckBox mostrarHabilitados;
        private System.Windows.Forms.CheckBox mostrarInhabilitados;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox nombre_de_contacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox ProvExistentes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox razonSocial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox rubro;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.Button mostrarMas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}