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
    public partial class Diseño : MetroForm
    {
        public Diseño(string elementoDiseño )
        {
            InitializeComponent();
            string diseño = elementoDiseño;
            this.BindGrid(diseño);
            
        }

        private void Diseño_Load(object sender, EventArgs e)
        {

        }

        private void BindGrid(string diseñoBuscado)
        {
            string conString = @"Data Source=localhost;port=3306;Initial Catalog=industrial;User Id=root;password=root";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT Description_std Descripción FROM diseños WHERE Design_id LIKE  '" + diseñoBuscado + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                DataGridViewDiseño.DataSource = dt;
                                DataGridViewDiseño.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                        }
                    }
                }
            }
            if (DataGridViewDiseño.RowCount > 1)
            { DataGridViewDiseño.Rows.RemoveAt(0); }
        }

    }
}
