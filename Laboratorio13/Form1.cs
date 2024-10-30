using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        private string connectionString =
    @"Server=localhost\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limpiar el ListBox antes de cargar los productos

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                string query = "SELECT ProductName FROM [dbo].[Products]";
                SqlCommand command = new SqlCommand(query, conexion);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["ProductName"].ToString());
                    }
                }

                MessageBox.Show("Productos cargados en el ListBox.");
            }
        }
    }
}

