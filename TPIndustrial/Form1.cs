using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Industrial2;
using WindowsFormsApplication8;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using TPIndustrial;

namespace Industrial2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

                conectar.Open();
                MySqlCommand comandoFecha = new MySqlCommand("SELECT distinct Fecha FROM carga WHERE Fecha NOT LIKE 'NULL' ", conectar);
                MySqlDataReader almacenaFecha = comandoFecha.ExecuteReader();

                while (almacenaFecha.Read())
                {
                    cboFecha.Refresh();
                    cboFecha.Items.Add(almacenaFecha.GetValue(0).ToString());
                }
                conectar.Close();

                conectar.Open();
                MySqlCommand comando = new MySqlCommand("SELECT distinct Producto FROM carga ORDER BY Producto ASC", conectar);
                MySqlDataReader almacena = comando.ExecuteReader();

                while (almacena.Read())
                {
                    cboElementosProducto.Refresh();
                    cboElementosProducto.Items.Add(almacena.GetValue(0).ToString());                   
                }
                conectar.Close();

                conectar.Open();
                MySqlCommand comando2 = new MySqlCommand("SELECT Description_str FROM tipo_design WHERE Description_str LIKE 'Producto Final' ", conectar);
                MySqlDataReader almacena2 = comando2.ExecuteReader();

                while (almacena2.Read())
                {
                    cboElementosTipo.Refresh();
                    cboElementosTipo.Items.Add(almacena2.GetValue(0).ToString());
                }
                conectar.Close();

                conectar.Open();
                MySqlCommand comando3 = new MySqlCommand("SELECT distinct Producto FROM carga", conectar);
                MySqlDataReader almacena3 = comando3.ExecuteReader();

                while (almacena3.Read())
                {
                    cboComprasProducto.Refresh();
                    cboComprasProducto.Items.Add(almacena3.GetValue(0).ToString());
                }
                conectar.Close();

                conectar.Open();
                MySqlCommand comando4 = new MySqlCommand("SELECT distinct Componente FROM carga ORDER BY Componente ASC", conectar);
                MySqlDataReader almacena4 = comando4.ExecuteReader();

                while (almacena4.Read())
                {
                    cboDiseño.Refresh();
                    cboDiseño.Items.Add(almacena4.GetValue(0).ToString());
                }
                conectar.Close();

                conectar.Open();
                MySqlCommand comando5 = new MySqlCommand("SELECT Description_str FROM tipo_design WHERE Description_str LIKE 'Producto Final' OR Description_str = 'Intermedio Make' ", conectar);
                MySqlDataReader almacena5 = comando5.ExecuteReader();

                while (almacena5.Read())
                {
                    CboComprasTipo.Refresh();
                    CboComprasTipo.Items.Add(almacena5.GetValue(0).ToString());
                }
                conectar.Close();
               

            }
            catch(MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            
            if (radiobtnComponen.Checked)
            {
                string elementosProducto = cboElementosProducto.GetItemText(cboElementosProducto.SelectedItem);
                string elementosTipo = cboElementosTipo.GetItemText(cboElementosTipo.SelectedItem);
                using (Elementos frmElementos = new Elementos(elementosProducto, elementosTipo))
                    frmElementos.ShowDialog();
            }
                
            if (radiobtnCompras.Checked)
            {
                string productoCompras = cboComprasProducto.GetItemText(cboComprasProducto.SelectedItem);
                string tipoCompras = CboComprasTipo.GetItemText(CboComprasTipo.SelectedItem);
                int cantidad = 1;
                cantidad = Convert.ToInt32(txtCantidad.Text);

                using (Compras frmCompras = new Compras(productoCompras,tipoCompras,cantidad))
                    frmCompras.ShowDialog();
            }
                
            if (radiobtnDiseño.Checked)
            {
                string productoDiseño = cboDiseño.GetItemText(cboDiseño.SelectedItem);
                using (Diseño frmDiseño = new Diseño(productoDiseño))
                    frmDiseño.ShowDialog();
            }
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            if (radiobtnComponen.Checked)
            {
                cboComprasProducto.SelectedItem=null;//en evento radiobtn
                CboComprasTipo.Enabled = false;
                cboDiseño.Enabled = false;
            }
            if (radiobtnCompras.Checked)
            {
                cboElementosProducto.Enabled = false;
                cboElementosTipo.Enabled = false;
                cboDiseño.Enabled = false;
            }
            if (radiobtnDiseño.Checked)
            {
                cboComprasProducto.Enabled = false;
                CboComprasTipo.Enabled = false;
                cboElementosProducto.Enabled = false;
                cboElementosTipo.Enabled = false;
            }

            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ver que el indice mayor a cero. aca se marca el radiobutton
            cboComprasProducto.SelectedItem = null;
            CboComprasTipo.SelectedItem = null;
            cboDiseño.SelectedItem = null;
            radiobtnComponen.Checked = true;

        }

        private void dataGridViewA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void cboComprasProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboDiseño_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        

        private void cboElementosProducto_Click(object sender, EventArgs e)
        {
            cboDiseño.SelectedItem = null;
            cboComprasProducto.SelectedItem = null;
            CboComprasTipo.SelectedItem = null;
            radiobtnComponen.Checked = true;

        }
        private void cboComprasProducto_Click(object sender, EventArgs e)
        {
            

        }

        private void cboComprasProducto_Click_1(object sender, EventArgs e)
        {

            cboElementosProducto.SelectedItem = null;
            cboElementosTipo.SelectedItem = null;
            cboDiseño.SelectedItem = null;
            radiobtnCompras.Checked = true;
        }

        private void cboDiseño_Click_1(object sender, EventArgs e)
        {
            radiobtnDiseño.Checked = true;
            radiobtnCompras.Checked = false;
            radiobtnComponen.Checked = false;
            cboElementosProducto.SelectedItem = null;
            cboElementosTipo.SelectedItem = null;
            cboComprasProducto.SelectedItem = null;
            CboComprasTipo.SelectedItem = null;
            
        }

        private void radiobtnComponen_Click(object sender, EventArgs e)
        {
            cboDiseño.SelectedItem = null;
            cboComprasProducto.SelectedItem = null;
            CboComprasTipo.SelectedItem = null;
            radiobtnComponen.Checked = true;
        }

        private void radiobtnCompras_Click(object sender, EventArgs e)
        {
            cboElementosProducto.SelectedItem = null;
            cboElementosTipo.SelectedItem = null;
            cboDiseño.SelectedItem = null;
            radiobtnCompras.Checked = true;
        }

        private void radiobtnDiseño_Click(object sender, EventArgs e)
        {
            radiobtnDiseño.Checked = true;;
            cboElementosProducto.SelectedItem = null;
            cboElementosTipo.SelectedItem = null;
            cboComprasProducto.SelectedItem = null;
            CboComprasTipo.SelectedItem = null;
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            using (ABM frmBOM = new ABM())
                frmBOM.ShowDialog();
        }
    }
}
