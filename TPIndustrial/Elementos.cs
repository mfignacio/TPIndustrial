using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Industrial2
{
    public partial class Elementos : MetroForm
    {
        public Elementos(string elementosProducto, string elementosTipo)
        {
            InitializeComponent(); 
            string producto = elementosProducto;
            string tipo = elementosTipo;
            this.BindGrid(elementosProducto);
           // dataGridViewElementos.Rows.RemoveAt(0);
        }

        private void Elementos_Load(object sender, EventArgs e)
        {
           
        }   

        private void BindGrid(string productoBuscado) 
        {
            string conString = @"Data Source=localhost;port=3306;Initial Catalog=industrial;User Id=root;password=root";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT Componente FROM carga WHERE Producto LIKE '"+ productoBuscado+"'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridViewElementos.DataSource = dt;
                            dataGridViewElementos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }

            if (dataGridViewElementos.RowCount > 1)
            { dataGridViewElementos.Rows.RemoveAt(0); }
        }

    }
    
}
