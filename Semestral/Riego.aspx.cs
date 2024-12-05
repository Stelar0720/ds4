using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace Semestral
{
    public partial class Riego : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarUsuarios();
                CargarPlantas();
            }
        }

        protected void btnRegistrarRiego_Click(object sender, EventArgs e)
        {
            int usuarioID = Convert.ToInt32(ddlUsuarios.SelectedValue);
            int plantaID = Convert.ToInt32(ddlPlantas.SelectedValue);

            string connectionString = "Server=localhost\\sqlexpress;Database=SistemaRiego;TrustServerCertificate=true;Integrated Security=SSPI;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "EXEC RegistrarRiego @UsuarioID, @PlantaID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.Parameters.AddWithValue("@PlantaID", plantaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            CargarRiegos();
        }

        private void CargarUsuarios()
        {
            string connectionString = "Server=localhost\\sqlexpress;Database=SistemaRiego;TrustServerCertificate=true;Integrated Security=SSPI;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuarios";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                ddlUsuarios.DataSource = dt;
                ddlUsuarios.DataTextField = "Nombre";
                ddlUsuarios.DataValueField = "UsuarioID";
                ddlUsuarios.DataBind();
            }
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

                ddlPlantas.DataSource = dt;
                ddlPlantas.DataTextField = "Nombre";
                ddlPlantas.DataValueField = "PlantaID";
                ddlPlantas.DataBind();
            }
        }

        private void CargarRiegos()
        {
            string connectionString = "Server=localhost\\sqlexpress;Database=SistemaRiego;TrustServerCertificate=true;Integrated Security=SSPI;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT r.RiegoID, u.Nombre AS Usuario, p.Nombre AS Planta, r.FechaRiego " +
                               "FROM Riegos r " +
                               "INNER JOIN Usuarios u ON r.UsuarioID = u.UsuarioID " +
                               "INNER JOIN Plantas p ON r.PlantaID = p.PlantaID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                gvRiegos.DataSource = dt;
                gvRiegos.DataBind();
            }
        }
    }
}
