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
    public partial class ABM : MetroForm
    {
        public ABM()
        {
            InitializeComponent();
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("SELECT distinct Description_std FROM diseños WHERE Tipo_id=1 OR Tipo_id=3", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();

            while (almacena.Read())
            {
                cboProductos.Refresh();
                cboProductos.Items.Add(almacena.GetValue(0).ToString());
            }
            conectar.Close();

            
        }

        private void ABM_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = cboProductos.SelectedItem.ToString();
            string componente = cboComponentes.SelectedItem.ToString();
            using (AgregarModificar frmBOM = new AgregarModificar(producto, componente))
                    { frmBOM.ShowDialog(); }
            cboProductos.SelectedItem = producto;
            cboComponentes.SelectedItem = componente;
            listarComponentes();
        }

        private void listarComponentes()
        {
            string producto = cboProductos.SelectedItem.ToString();
            string conString = @"Data Source=localhost;port=3306;Initial Catalog=industrial;User Id=root;password=root";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT Componente, Cantidad, Unidad FROM carga WHERE Producto LIKE  '" + producto + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridViewABM.DataSource = dt;
                                dataGridViewABM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                        }
                    }
                }
            }

            //DataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            if (dataGridViewABM.RowCount > 1)
            { dataGridViewABM.Rows.RemoveAt(0); }
            
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listaFinales = new List<string> { };
            int bandera = 0;
            string seleccionado = cboProductos.SelectedItem.ToString();

            MySqlConnection conectarFinales = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectarFinales.Open();
            MySqlCommand comandoFinales = new MySqlCommand("SELECT Description_std FROM diseños WHERE Tipo_id=1", conectarFinales);
            MySqlDataReader almacenaFinales = comandoFinales.ExecuteReader();

            while (almacenaFinales.Read())
            {
                listaFinales.Add(almacenaFinales.GetValue(0).ToString());
            }
            conectarFinales.Close();


            if (listaFinales.Contains(seleccionado))
            { bandera = 1; }

            if (bandera == 1)//seleccione un producto final, mostrame los intermedios buy make y bruto
            {
                MySqlConnection conectar2 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

                conectar2.Open();
                MySqlCommand comando2 = new MySqlCommand("SELECT distinct Description_std FROM diseños WHERE Tipo_id = 2 OR Tipo_id = 3 OR Tipo_id = 4", conectar2);
                MySqlDataReader almacena2 = comando2.ExecuteReader();

                while (almacena2.Read())
                {
                    cboComponentes.Refresh();
                    cboComponentes.Items.Add(almacena2.GetValue(0).ToString());
                }
                conectar2.Close();
                bandera = 0;
            }
            else // no era producto final, era un intermedio make: mostrame los intermedios buy y bruto
            {
                MySqlConnection conectar3 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

                conectar3.Open();
                MySqlCommand comando3 = new MySqlCommand("SELECT distinct Description_std FROM diseños WHERE Tipo_id = 2 OR Tipo_id = 4", conectar3);
                MySqlDataReader almacena3 = comando3.ExecuteReader();

                while (almacena3.Read())
                {
                    cboComponentes.Refresh();
                    cboComponentes.Items.Add(almacena3.GetValue(0).ToString());
                }
                conectar3.Close();
                bandera = 0;
            }

            listarComponentes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string producto = cboProductos.SelectedItem.ToString();
            int rowindex = dataGridViewABM.CurrentCell.RowIndex;
            int columnindex = 0;
            string componenteSeleccionado = dataGridViewABM.Rows[rowindex].Cells[columnindex].Value.ToString();
            int rowindex2 = dataGridViewABM.CurrentCell.RowIndex;
            int columnindex2 = 1;
            string cantidadSeleccionado = dataGridViewABM.Rows[rowindex2].Cells[columnindex2].Value.ToString();
            int rowindex3 = dataGridViewABM.CurrentCell.RowIndex;
            int columnindex3 = 2;
            string unidadSeleccionado = dataGridViewABM.Rows[rowindex3].Cells[columnindex3].Value.ToString();
            
                   
            using (Editar frmEditar = new Editar(producto, componenteSeleccionado, cantidadSeleccionado, unidadSeleccionado))
            { frmEditar.ShowDialog(); }
            listarComponentes();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string producto = cboProductos.SelectedItem.ToString();
            int rowindex = dataGridViewABM.CurrentCell.RowIndex;
            int columnindex = 0;
            string componenteSeleccionado = dataGridViewABM.Rows[rowindex].Cells[columnindex].Value.ToString();
            int rowindex2 = dataGridViewABM.CurrentCell.RowIndex;
            int columnindex2 = 1;
            string cantidadSeleccionado = dataGridViewABM.Rows[rowindex2].Cells[columnindex2].Value.ToString();
            int rowindex3 = dataGridViewABM.CurrentCell.RowIndex;
            int columnindex3 = 2;
            string unidadSeleccionado = dataGridViewABM.Rows[rowindex3].Cells[columnindex3].Value.ToString();

            List<string> id = new List<string> { };

            MySqlConnection conectar3 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectar3.Open();
            MySqlCommand comando3 = new MySqlCommand("SELECT distinct id_carga FROM carga WHERE Producto = '" + producto + "' AND Componente = '" + componenteSeleccionado + "' AND Cantidad = '" + cantidadSeleccionado + "' AND Unidad = '" + unidadSeleccionado + "'  ", conectar3);
            MySqlDataReader almacena3 = comando3.ExecuteReader();
            while (almacena3.Read())
            {
                id.Add(almacena3.GetValue(0).ToString());
            };
            string idSeleccionado = id[0];
            MySqlConnection conectar4 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectar4.Open();
            MySqlCommand comando4 = new MySqlCommand("DELETE FROM carga WHERE id_carga = '" + idSeleccionado + "'  ", conectar4);
            MySqlDataReader almacena4 = comando4.ExecuteReader();
            listarComponentes();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            using (NuevoProducto frmNuevoProducto = new NuevoProducto())
            { frmNuevoProducto.ShowDialog(); }
            this.Close();
        }
    }
}
