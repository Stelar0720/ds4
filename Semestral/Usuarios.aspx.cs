using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace Semestral
{
    public partial class Usuarios : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarUsuarios();
            }
        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string emailUsuario = txtEmailUsuario.Text;

            string connectionString = "Server=localhost\\sqlexpress;Database=SistemaRiego;TrustServerCertificate=true;Integrated Security=SSPI;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (Nombre, Email) VALUES (@Nombre, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                cmd.Parameters.AddWithValue("@Email", emailUsuario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            txtNombreUsuario.Text = "";
            txtEmailUsuario.Text = "";
            CargarUsuarios();
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

                gvUsuarios.DataSource = dt;
                gvUsuarios.DataBind();
            }
        }
    }
}
