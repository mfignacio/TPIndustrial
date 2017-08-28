﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace Industrial2
{
    public partial class Compras : MetroForm
    {
        public Compras(string producto, string tipo, int cantidad)
        {
            InitializeComponent();
            string productoSolicitado = producto;
            string tipoSolicitado = tipo;
            int cantSolicitada = cantidad;
            this.BindGrid(productoSolicitado,cantidad);
           // dataGridViewCompras.Rows.RemoveAt(0);

        }

        private void BindGrid(string productoSolicitado, int cantidad)
        {
            string conString = @"Data Source=localhost;port=3306;Initial Catalog=industrial;User Id=root;password=root";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT Componente, (Cantidad * '"+cantidad+"') 'Cantidad Total', Unidad FROM carga WHERE Producto LIKE '" + productoSolicitado + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridViewCompras.DataSource = dt;
                            dataGridViewCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            if (dataGridViewCompras.RowCount > 1)
            { dataGridViewCompras.Rows.RemoveAt(0); }
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }
    }
}
