using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recursos_Humanos
{
    public partial class frmsolicitavacaciones : MaterialForm
    {
        public frmsolicitavacaciones()
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

        private void frmsolicitavacaciones_Load(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            frmestadosolicitudvacaciones formEstadoSolicitud = new frmestadosolicitudvacaciones();
            formEstadoSolicitud.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnenviarsolicitud_Click(object sender, EventArgs e)
        {
            string nombreUsuario = conexion.NombreUsuarioActual;
            DateTime fechaInicio = dtpdesde.Value; 
            DateTime fechaFin = dtphasta.Value;        
            string motivo = txtmotivo.Text;                        

            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("SOLICITAR_VACACIONES", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                        cmd.Parameters.AddWithValue("@Motivo", motivo);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Solicitud de vacaciones enviada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtmotivo.Clear();
                        dtpdesde.Value = DateTime.Now;
                        dtphasta.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al solicitar vacaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
