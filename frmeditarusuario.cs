using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursos_Humanos
{
    public partial class frmeditarusuario : MaterialSkin.Controls.MaterialForm
    {
        public string NuevoNombreUsuario { get; private set; }
        public string NuevaClave { get; private set; }
        public string NuevoTipoUsuario { get; private set; }
        public frmeditarusuario()
        {
            InitializeComponent();
        }

        private void frmeditarusuario_Load(object sender, EventArgs e)
        {
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los nuevos valores desde los controles
                string nuevoNombreUsuario = txtusuario.Text;
                string nuevaClave = txtclave.Text;
                string nuevoTipoUsuario = cbotipousuario.Text;

                int usuarioID = ObtenerUsuarioID();

                EditarUsuarioEnBD(usuarioID, nuevoNombreUsuario, nuevaClave, nuevoTipoUsuario);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar usuario: " + ex.Message);
            }
        }

        private int ObtenerUsuarioID()
        {

            return 1;
        }
        private void EditarUsuarioEnBD(int usuarioID, string nuevoNombreUsuario, string nuevaClave, string nuevoTipoUsuario)
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("EDITAR_USUARIO", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                        cmd.Parameters.AddWithValue("@NombreUsuario", nuevoNombreUsuario);
                        cmd.Parameters.AddWithValue("@Clave", nuevaClave);
                        cmd.Parameters.AddWithValue("@TipoUsuario", nuevoTipoUsuario);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar usuario: " + ex.Message);
            }
        }
    }
}
