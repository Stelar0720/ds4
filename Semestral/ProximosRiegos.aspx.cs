using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace Semestral
{
    public partial class ProximosRiegos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarUsuarios();
            }
        }

        protected void btnVerProximosRiegos_Click(object sender, EventArgs e)
        {
            int usuarioID = Convert.ToInt32(ddlUsuarios.SelectedValue);
            MostrarProximosRiegos(usuarioID);
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

        private void MostrarProximosRiegos(int usuarioID)
        {
            string connectionString = "Server=localhost\\sqlexpress;Database=SistemaRiego;TrustServerCertificate=true;Integrated Security=SSPI;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "EXEC ObtenerProximosRiegos @UsuarioID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                gvProximosRiegos.DataSource = dt;
                gvProximosRiegos.DataBind();
            }
        }
    }
}
