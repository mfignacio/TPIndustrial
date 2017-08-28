using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIndustrial
{
    public partial class AgregarModificar : MetroForm
    {
        public AgregarModificar(string productoSeleccionado, string componenteSeleccionado)
        {
            InitializeComponent();
            txtProducto.Text = productoSeleccionado;
            txtComponente.Text = componenteSeleccionado;
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("SELECT Unidad FROM diseño_medida WHERE description_std LIKE  '" + componenteSeleccionado + "'", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();
           

            while (almacena.Read())
            {
                cboUnidadesDisponibles.Refresh();
                cboUnidadesDisponibles.Items.Add(almacena.GetValue(0).ToString());

            }
            conectar.Close();
        }
        
        private void btnHecho_Click(object sender, EventArgs e)
        {
            string componente = txtComponente.Text;
            string producto = txtProducto.Text;
            string unidad = cboUnidadesDisponibles.SelectedItem.ToString();
            float cantidad = float.Parse(txtCantidad.Text);
            DateTime  fecha = DateTime.Now;
            string fechita = fecha.ToString("yyyy-MM-dd hh:mm:ss");
            //DateTime date = DateTime.ParseExact(fechita, "dd/MM/YYYY", CultureInfo.InvariantCulture);
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO carga (Producto, Componente, Unidad, Cantidad, Fecha) VALUES ('" +producto+ "'  , '" + componente + "', '" + unidad + "', '" + cantidad + "', '" + fechita + "')", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AgregarModificar_Load(object sender, EventArgs e)
        {

        }

        private void cboUnidadesDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
