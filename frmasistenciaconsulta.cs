using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recursos_Humanos
{
    public partial class frmasistenciaconsulta : MaterialForm
    {
        public frmasistenciaconsulta()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500,
                Primary.Teal700,
                Primary.Teal200,
                Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void frmasistenciaconsulta_Load(object sender, EventArgs e)
        {
            CargarAsistenciaUsuario();

        }
        private void CargarAsistenciaUsuario()
        {
            try
            {
                string nombreUsuario = conexion.NombreUsuarioActual;

                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT A.* FROM Asistencia A INNER JOIN Empleados E ON A.CedulaEmpleado = E.Cedula INNER JOIN Usuarios U ON E.TipoUsuarioID = U.UsuarioID WHERE U.NombreUsuario = @NombreUsuario", cn))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvasistencia.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asistencia del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
