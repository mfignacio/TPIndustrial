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
    public partial class Editar : MetroForm
    {
        public Editar()
        {
            InitializeComponent();
        }

        public Editar(string producto, string componenteSeleccionado, string cantidadSeleccionado, string unidadSeleccionado)
        {
            InitializeComponent();

            txtCantidadEditar.Text = cantidadSeleccionado;
            txtComponenteEditar.Text = componenteSeleccionado;
            txtProductoEditar.Text = producto;
            

            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("SELECT Unidad FROM diseño_medida WHERE description_std LIKE  '" + componenteSeleccionado + "'", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();


            while (almacena.Read())
            {
                cboUnidadesDisponiblesEditar.Refresh();
                cboUnidadesDisponiblesEditar.Items.Add(almacena.GetValue(0).ToString());

            }
            conectar.Close();

            cboUnidadesDisponiblesEditar.SelectedItem = unidadSeleccionado;
        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void btnHecho_Click(object sender, EventArgs e)
        {
            string componente = txtComponenteEditar.Text;
            string producto = txtProductoEditar.Text;
            string unidad = cboUnidadesDisponiblesEditar.SelectedItem.ToString();
            float cantidad = float.Parse(txtCantidadEditar.Text);

            List<string> id = new List<string> { };

            MySqlConnection conectar3 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectar3.Open();
            MySqlCommand comando3 = new MySqlCommand("SELECT distinct id_carga FROM carga WHERE Producto = '" + producto + "' AND Componente = '" + componente + "'   ", conectar3);
            MySqlDataReader almacena3 = comando3.ExecuteReader();
            while (almacena3.Read())
            {
                id.Add(almacena3.GetValue(0).ToString());
            };
            string idSeleccionado = id[0];


            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectar.Open();
            MySqlCommand comando = new MySqlCommand("UPDATE carga SET Producto='" + producto + "', Componente='" + componente + "', Unidad='" + unidad + "', Cantidad='" + cantidad + "' WHERE id_carga= '" + idSeleccionado + "'", conectar);
            //("INSERT INTO carga (Producto, Componente, Unidad, Cantidad) VALUES ('" + producto + "'  , '" + componente + "', '" + unidad + "', '" + cantidad + "')", conectar);
            //UPDATE Customers SET ContactName = 'Juan' WHERE Country = 'Mexico';
            MySqlDataReader almacena = comando.ExecuteReader();
            

            this.Close();
        }
    }
}
