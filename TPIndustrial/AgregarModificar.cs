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
            DateTime fecha = DateTime.Now;
            string fechita = fecha.ToString("yyyy-MM-dd hh:mm:ss");
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO carga (Producto, Componente, Unidad, Cantidad, Fecha) VALUES ('" + producto + "'  , '" + componente + "', '" + unidad + "', '" + cantidad + "', '" + fechita + "')", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();
            conectar.Close();

            /*
            MySqlConnection conectar2 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar2.Open();
            MySqlCommand comando2 = new MySqlCommand("INSERT INTO carga (Producto, Componente, Unidad, Cantidad, Fecha) VALUES ('" + producto + "'  , '" + componente + "', '" + unidad + "', '" + cantidad + "', '" + fechita + "')", conectar2);
            MySqlDataReader almacena2 = comando2.ExecuteReader();
            conectar2.Close();
            */

           // int bandera = 0;
            List<string> listaNulos = new List<string> { };
            MySqlConnection conectarNulos = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectarNulos.Open();
            MySqlCommand comandoNulos = new MySqlCommand("SELECT id_carga FROM carga WHERE Componente IS NULL", conectarNulos);
            MySqlDataReader almacenaNulos = comandoNulos.ExecuteReader();
            


            while (almacenaNulos.Read())
            {
                listaNulos.Add(almacenaNulos.GetValue(0).ToString());
            }
            conectarNulos.Close();

            if (listaNulos.Count()>=1)
            {
                conectar.Open();
                MySqlCommand comandoListaNulos = new MySqlCommand("DELETE FROM carga WHERE Componente IS NULL", conectar);
                MySqlDataReader almacenaListaNulos = comandoListaNulos.ExecuteReader();
                conectar.Close();
            }

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
