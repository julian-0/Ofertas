namespace FrbaOfertas.gestionUsuarios
{
    partial class ABMUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.UsuExistentes = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mostrarHabilitados = new System.Windows.Forms.CheckBox();
            this.mostrarInhabilitados = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gD2C2019DataSet = new FrbaOfertas.GD2C2019DataSet();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolTableAdapter = new FrbaOfertas.GD2C2019DataSetTableAdapters.RolTableAdapter();
            this.UsuExistentes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(925, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = " + NUEVO USUARIO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsuExistentes
            // 
            this.UsuExistentes.Controls.Add(this.button4);
            this.UsuExistentes.Controls.Add(this.button3);
            this.UsuExistentes.Controls.Add(this.groupBox2);
            this.UsuExistentes.Controls.Add(this.dataGridView1);
            this.UsuExistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuExistentes.Location = new System.Drawing.Point(-5, 126);
            this.UsuExistentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsuExistentes.Name = "UsuExistentes";
            this.UsuExistentes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsuExistentes.Size = new System.Drawing.Size(1281, 572);
            this.UsuExistentes.TabIndex = 1;
            this.UsuExistentes.TabStop = false;
            this.UsuExistentes.Text = "Usuarios Existentes";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(27, 516);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(291, 39);
            this.button4.TabIndex = 1;
            this.button4.Text = "Eliminar Seleccionado";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(27, 462);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 39);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ver datos del seleccionado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mostrarHabilitados);
            this.groupBox2.Controls.Add(this.mostrarInhabilitados);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.rol);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.usuario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(339, 437);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(691, 129);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // mostrarHabilitados
            // 
            this.mostrarHabilitados.AutoSize = true;
            this.mostrarHabilitados.Checked = true;
            this.mostrarHabilitados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarHabilitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarHabilitados.Location = new System.Drawing.Point(339, 43);
            this.mostrarHabilitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mostrarHabilitados.Name = "mostrarHabilitados";
            this.mostrarHabilitados.Size = new System.Drawing.Size(159, 22);
            this.mostrarHabilitados.TabIndex = 3;
            this.mostrarHabilitados.Text = "Mostrar Habilitados";
            this.mostrarHabilitados.UseVisualStyleBackColor = true;
            // 
            // mostrarInhabilitados
            // 
            this.mostrarInhabilitados.AutoSize = true;
            this.mostrarInhabilitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarInhabilitados.Location = new System.Drawing.Point(339, 70);
            this.mostrarInhabilitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mostrarInhabilitados.Name = "mostrarInhabilitados";
            this.mostrarInhabilitados.Size = new System.Drawing.Size(167, 22);
            this.mostrarInhabilitados.TabIndex = 4;
            this.mostrarInhabilitados.Text = "Mostrar Inhabilitados";
            this.mostrarInhabilitados.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 43);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rol
            // 
            this.rol.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol.FormattingEnabled = true;
            this.rol.Location = new System.Drawing.Point(21, 89);
            this.rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(231, 27);
            this.rol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Rol";
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(21, 39);
            this.usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(231, 25);
            this.usuario.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Usuario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(27, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1219, 362);
            this.dataGridView1.TabIndex = 2;
            // 
            // gD2C2019DataSet
            // 
            this.gD2C2019DataSet.DataSetName = "GD2C2019DataSet";
            this.gD2C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.gD2C2019DataSet;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // ABMUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 709);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UsuExistentes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ABMUsuarios";
            this.Text = "AMBUsuarios";
            this.Load += new System.EventHandler(this.ABMUsuarios_Load);
            this.UsuExistentes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox UsuExistentes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox mostrarHabilitados;
        private System.Windows.Forms.CheckBox mostrarInhabilitados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD2C2019DataSet gD2C2019DataSet;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private GD2C2019DataSetTableAdapters.RolTableAdapter rolTableAdapter;
    }
}