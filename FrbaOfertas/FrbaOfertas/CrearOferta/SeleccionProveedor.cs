﻿using FrbaOfertas.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CrearOferta
{
    public partial class SeleccionProveedor : Form
    {

        DataTable dt = new DataTable();
        public List<string> datosFilaProveedor = new List<string>();
        private bool buscarWasClicked = false;

        public SeleccionProveedor()
        {
            InitializeComponent();
            this.updateHeadersStyle();
        }

        public string proveedorSeleccionado
        {
            get {
                return datosFilaProveedor[2].ToString();
                }
        }

        //Hay un bug que resetea la fuente de ColumnHeadersDefaultCellStyle con cada build
        private void updateHeadersStyle()
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarWasClicked = true;
            dt.Columns.Clear();
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT [proveedor_id],[rubro_id],[usuario_id],[razon_social],"
                +"[mail],[telefono],[domicilio],[localidad],[ciudad],[codigo_postal],[cuit],[nombre_contacto],"
                                                        +"[baja_logica] FROM NUNCA_INJOIN.Proveedor", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Conexiones.CerrarConexion();
        }

        private void mostrarMas_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void SeleccionProveedor_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            datosFilaProveedor.Clear();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                for (int i = 0; i < 10; i++)
                {
                    datosFilaProveedor.Add(dataGridView1.Columns[i].Name + ": ");
                    datosFilaProveedor.Add(row.Cells[i].Value.ToString() + "\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buscarWasClicked)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}