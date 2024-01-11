using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recursos_Humanos
{
    public partial class frmestadosolicitudvacaciones : MaterialForm
    {
        public frmestadosolicitudvacaciones()
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

        private void frmestadosolicitudvacaciones_Load(object sender, EventArgs e)
        {
            CargarSolicitudesVacaciones();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarSolicitudesVacaciones()
        {
            try
            {
                // Obtener el nombre de usuario actual desde la clase de conexión
                string nombreUsuario = conexion.NombreUsuarioActual;

                using (SqlConnection cn = conexion.conectar())
                {
                    // Ajustar la consulta para unir las tablas Usuarios y SolicitudesVacaciones
                    using (SqlCommand cmd = new SqlCommand("SELECT SV.ID, E.Cedula, SV.FechaInicio, SV.FechaFin, SV.Estado FROM SolicitudesVacaciones SV INNER JOIN Empleados E ON SV.CedulaEmpleado = E.Cedula INNER JOIN Usuarios U ON E.TipoUsuarioID = U.UsuarioID WHERE U.NombreUsuario = @NombreUsuario", cn))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvsolicitudvacaciones.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar solicitudes de vacaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvsolicitudvacaciones_SelectionChanged(object sender, EventArgs e)
        {
            // Manejar el evento de cambio de selección en el DataGridView
            MostrarComentarioAdmin();
        }

        private void MostrarComentarioAdmin()
        {
            // Obtener el ID de la solicitud seleccionada
            if (dgvsolicitudvacaciones.SelectedRows.Count > 0)
            {
                int idSolicitud = Convert.ToInt32(dgvsolicitudvacaciones.SelectedRows[0].Cells["ID"].Value);

                try
                {
                    using (SqlConnection cn = conexion.conectar())
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AdminComentario FROM SolicitudesVacaciones WHERE ID = @ID", cn))
                        {
                            cmd.Parameters.AddWithValue("@ID", idSolicitud);

                            object comentario = cmd.ExecuteScalar();
                            txtcomentarioadmin.Text = comentario != null ? comentario.ToString() : string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar comentario del administrador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Limpiar el TextBox si no hay ninguna fila seleccionada
                txtcomentarioadmin.Text = string.Empty;
            }
        }
    }
}
