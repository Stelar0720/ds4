using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace Semestral
{
    public partial class TiposPlanta : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPlantas();
            }
        }

        protected void btnRegistrarTipoPlanta_Click(object sender, EventArgs e)
        {
            string nombrePlanta = txtTipoPlanta.Text;

            string connectionString = "Server=localhost\\sqlexpress;Database=SistemaRiego;TrustServerCertificate=true;Integrated Security=SSPI;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Plantas (Nombre, FrecuenciaRiego) VALUES (@Nombre, @FrecuenciaRiego)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombrePlanta);
                cmd.Parameters.AddWithValue("@FrecuenciaRiego", 7); // Frecuencia de riego por defecto, puedes modificarlo

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            txtTipoPlanta.Text = "";
            CargarPlantas();
        }

        private void CargarPlantas()
        {
            string connectionString = "Server=localhost\\sqlexpress;Database=SistemaRiego;TrustServerCertificate=true;Integrated Security=SSPI;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Plantas";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                gvTiposPlanta.DataSource = dt;
                gvTiposPlanta.DataBind();
            }
        }
    }
}

