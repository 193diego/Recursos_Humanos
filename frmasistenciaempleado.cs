using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recursos_Humanos
{
    public partial class frmasistenciaempleado : MaterialForm
    {
        public frmasistenciaempleado()
        {
            InitializeComponent();
            string nombreUsuario = conexion.NombreUsuarioActual;
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

        private void frmasistenciaempleado_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconsultaasistencia_Click(object sender, EventArgs e)
        {
            frmasistenciaconsulta formAsistenciaConsulta = new frmasistenciaconsulta();
            formAsistenciaConsulta.ShowDialog();
        }

        private void btnmarcaentrada_Click(object sender, EventArgs e)
        {
            RegistrarAsistencia("Entrada");
            btnmarcaentrada.Enabled = false;
            btnmarcasalida.Enabled = true;

        }

        private void btnmarcasalida_Click(object sender, EventArgs e)
        {
            RegistrarAsistencia("Salida");
            btnmarcasalida.Enabled = false;
            btnmarcaentrada.Enabled = true;
        }
        private void RegistrarAsistencia(string tipoMarcado)
        {
            try
            {
                string nombreUsuario = conexion.NombreUsuarioActual;

                // Obtener la cédula del empleado
                int cedulaEmpleado = ObtenerCedulaPorNombreUsuario(nombreUsuario);

                using (SqlConnection cn = conexion.conectar())
                {
                    SqlCommand cmd = new SqlCommand("REGISTRAR_ASISTENCIA", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@CedulaEmpleado", cedulaEmpleado);
                    cmd.Parameters.AddWithValue("@TipoMarcado", tipoMarcado);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar asistencia: " + ex.Message);
            }
        }
        private int ObtenerCedulaPorNombreUsuario(string nombreUsuario)
        {
            int cedulaEmpleado = -1;
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    SqlCommand cmd = new SqlCommand("SELECT Cedula FROM Empleados WHERE Cedula = (SELECT Cedula FROM Usuarios WHERE NombreUsuario = @NombreUsuario)", cn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        cedulaEmpleado = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la cédula para el usuario: " + nombreUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener cédula: " + ex.Message);
            }

            return cedulaEmpleado;
        }
    }
}
