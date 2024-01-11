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
    public partial class frmadminconsultausuario : MaterialSkin.Controls.MaterialForm
    {
        public string NuevoNombreUsuario { get; private set; }
        public string NuevaClave { get; private set; }
        public string NuevoTipoUsuario { get; private set; }
        public frmadminconsultausuario()
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

        private void frmadminconsultausuario_Load(object sender, EventArgs e)
        {
            CargarDatosUsuarios();

        }
        private void CargarDatosUsuarios()
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT UsuarioID, NombreUsuario, Clave, TipoUsuario FROM Usuarios", cn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dt.Columns.Add("Editar", typeof(Image));
                        dt.Columns.Add("Eliminar", typeof(Image));

                        dgvusuarios.DataSource = dt;

                        for (int i = 0; i < dgvusuarios.Rows.Count; i++)
                        {
                            dgvusuarios.Rows[i].Cells["Editar"].Value = Properties.Resources.ic_editar;
                            dgvusuarios.Rows[i].Cells["Eliminar"].Value = Properties.Resources.ic_eliminar;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de usuarios: " + ex.Message);
            }
        }

        private void dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int usuarioID = Convert.ToInt32(dgvusuarios.Rows[e.RowIndex].Cells["UsuarioID"].Value);

                if (e.ColumnIndex == dgvusuarios.Columns["Editar"].Index)
                {
                    frmeditarusuario editarForm = new frmeditarusuario();
                    editarForm.ShowDialog();
                    CargarDatosUsuarios();
                }

                if (e.ColumnIndex == dgvusuarios.Columns["Eliminar"].Index)
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ELIMINAR_USUARIO(usuarioID);
                        CargarDatosUsuarios();
                    }
                }
            }
        }
        // En tu formulario principal
        private void ELIMINAR_USUARIO(int usuarioID)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EliminarUsuarioEnBD(usuarioID);
            }
        }

        private void EliminarUsuarioEnBD(int usuarioID)
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("ELIMINAR_USUARIO", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            txtcaracter.Clear();
            CargarDatosUsuarios();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuarioBusqueda = txtcaracter.Text;

                DataTable resultados = new DataTable();

                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("BUSCAR_USUARIO", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuarioBusqueda", nombreUsuarioBusqueda);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(resultados);
                        }
                    }
                }

                dgvusuarios.DataSource = resultados; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
