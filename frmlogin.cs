using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recursos_Humanos
{
    public partial class frmlogin : MaterialForm
    {
        public string NombreUsuarioIngresado => txtusuario.Text;
        public string NombreUsuario { get; private set; }
        public frmlogin(string NombreUsuario)
        {
            InitializeComponent();
            txtclave.PasswordChar = '*';
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

        private void frmlogin_Load(object sender, EventArgs e)
        {


        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string tipoUsuario = string.Empty;
            string nombreUsuario = txtusuario.Text;
            string clave = txtclave.Text;

            using (SqlConnection cn = conexion.conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("VERIFICAR_USUARIOS", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@NombreUsuario", SqlDbType.VarChar, 50) { Value = nombreUsuario });
                        cmd.Parameters.Add(new SqlParameter("@Clave", SqlDbType.VarChar, 50) { Value = clave });

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tipoUsuario = reader["TipoUsuario"].ToString();
                                MessageBox.Show("Bienvenido, " + nombreUsuario + " - Tipo de Usuario: " + tipoUsuario);
                                if (tipoUsuario == "Empleado")
                                {
                                    conexion.NombreUsuarioActual = nombreUsuario;
                                    NombreUsuario = txtusuario.Text.Trim();
                                    frmempleadomenu formEmpleadoMenu = new frmempleadomenu();
                                    formEmpleadoMenu.ShowDialog();
                                }
                                else if (tipoUsuario == "Administrador")
                                {
                                    frmadministrador formAdministrador = new frmadministrador();
                                    formAdministrador.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Tipo de usuario no reconocido.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Acceso denegado. Usuario no reconocido.");
                            }
                            this.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el acceso: " + ex.Message);
                }
            }
        }
    }
}
