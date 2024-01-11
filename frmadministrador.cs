using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Recursos_Humanos
{
    public partial class frmadministrador : MaterialSkin.Controls.MaterialForm
    {
        private validacion Validador = new validacion();
        public frmadministrador()
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

        private void frmadministrador_Load(object sender, EventArgs e)
        {
            CargarTipoUsuarios();

        }

        private void btnconsultausuario_Click(object sender, EventArgs e)
        {
            frmadminconsultausuario formConsultaUsuario = new frmadminconsultausuario();
            formConsultaUsuario.ShowDialog();
        }

        private void btnagregarusuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtusuario.Text;
            string clave = txtclave.Text;
            string tipoUsuario = cbotipousuario.Text;  

            InsertarUsuario(nombreUsuario, clave, tipoUsuario);

            MessageBox.Show("Usuario registrado correctamente.");
        }
        private void InsertarUsuario(string nombreUsuario, string clave, string tipoUsuario)
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("REGISTRAR_USUARIO", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Clave", clave);
                        cmd.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el usuario: " + ex.Message);
            }
        }
        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsalario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnconsultacedula_Click(object sender, EventArgs e)
        {
            cbocalificacion.Enabled = false;
            txtcomentario.Enabled = false;
            btnregistrarevaluacion.Enabled = false;
            ConsultarCedula();

        }

        private void btnregistrarevaluacion_Click(object sender, EventArgs e)
        {
            RegistrarEvaluacion();
        }
        private void ConsultarCedula()
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_EMPLEADO", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CedulaEmpleado", Convert.ToInt32(txtcedulaempleado.Text));

                        SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Int);
                        resultadoParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(resultadoParam);

                        cmd.ExecuteNonQuery();

                        int resultado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);

                        if (resultado == 1)
                        {
                            cbocalificacion.Enabled = true;
                            txtcomentario.Enabled = true;
                            btnregistrarevaluacion.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Empleado no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void RegistrarEvaluacion()
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("REGISTRA_EVALUACION", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CedulaEmpleado", Convert.ToInt32(txtcedulaempleado.Text));
                        cmd.Parameters.AddWithValue("@Calificacion", Convert.ToInt32(cbocalificacion.SelectedItem));
                        cmd.Parameters.AddWithValue("@Comentario", txtcomentario.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Evaluación registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalirdesempeno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvvacaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewColumn aprobarColumn = dgvvacaciones.Columns["Aprobar"];
                    DataGridViewColumn reprobarColumn = dgvvacaciones.Columns["Reprobar"];

                    // Verificar que las columnas existan
                    if (aprobarColumn != null && reprobarColumn != null)
                    {
                        int solicitudID = 0;

                        // Verificar que la columna "ID" exista y tenga un valor
                        DataGridViewCell idCell = dgvvacaciones.Rows[e.RowIndex].Cells["ID"];
                        if (idCell != null && idCell.Value != null)
                        {
                            solicitudID = Convert.ToInt32(idCell.Value);

                            if (dgvvacaciones.Columns[e.ColumnIndex] == aprobarColumn)
                            {
                                AprobarSolicitudVacaciones(solicitudID);
                                MessageBox.Show("Usted aprobó la solicitud.", "Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            if (dgvvacaciones.Columns[e.ColumnIndex] == reprobarColumn)
                            {
                                ReprobarSolicitudVacaciones(solicitudID);
                                MessageBox.Show("Usted reprobó la solicitud.", "Reprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            CargarDatosVacaciones();
                        }
                        else
                        {
                            MessageBox.Show("La columna 'ID' no existe o no tiene un valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las columnas 'Aprobar' o 'Reprobar' no existen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AprobarSolicitudVacaciones(int solicitudID)
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("APROBAR_SOLICITUD_VACACIONES", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SolicitudID", solicitudID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}\nNúmero de error: {ex.Number}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReprobarSolicitudVacaciones(int solicitudID)
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("REPROBAR_SOLICITUD_VACACIONES", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SolicitudID", solicitudID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}\nNúmero de error: {ex.Number}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosVacaciones()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SolicitudesVacaciones", conexion.conectar());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataGridViewButtonColumn aprobarColumn = dgvvacaciones.Columns.Cast<DataGridViewColumn>().FirstOrDefault(col => col.Name == "Aprobar") as DataGridViewButtonColumn;
                DataGridViewButtonColumn reprobarColumn = dgvvacaciones.Columns.Cast<DataGridViewColumn>().FirstOrDefault(col => col.Name == "Reprobar") as DataGridViewButtonColumn;

                if (aprobarColumn == null)
                {
                    aprobarColumn = new DataGridViewButtonColumn();
                    aprobarColumn.Name = "Aprobar";
                    aprobarColumn.HeaderText = "Aprobar";
                    aprobarColumn.Text = "Aprobar";
                    aprobarColumn.UseColumnTextForButtonValue = true;
                    dgvvacaciones.Columns.Add(aprobarColumn);
                }

                if (reprobarColumn == null)
                {
                    reprobarColumn = new DataGridViewButtonColumn();
                    reprobarColumn.Name = "Reprobar";
                    reprobarColumn.HeaderText = "Reprobar";
                    reprobarColumn.Text = "Reprobar";
                    reprobarColumn.UseColumnTextForButtonValue = true;
                    dgvvacaciones.Columns.Add(reprobarColumn);
                }

                dgvvacaciones.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}\nNúmero de error: {ex.Number}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnversolicitudes_Click(object sender, EventArgs e)
        {
            CargarDatosVacaciones();
        }

        private void btninformacionconsul_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpde.Value.Date;
                DateTime fechaFin = dtphasta.Value.Date;

                DataTable resultados = new DataTable();

                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.CONSULTA_FECHA_PANEL(@FechaInicio, @FechaFin)", cn))
                    {
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(resultados);
                        }
                    }
                }

                dgvconsultainfor.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnregistrarempleado_Click(object sender, EventArgs e)
        {
            try
            {
                int cedula = Convert.ToInt32(txtcedula.Text);
                string nombre = txtnombre.Text;
                decimal salario = Convert.ToDecimal(txtsalario.Text);

                // Obtener el TipoUsuarioID seleccionado del ComboBox
                int tipoUsuarioID = ((KeyValuePair<int, string>)cbotipousuarioid.SelectedItem).Key;

                // Llamada al procedimiento almacenado
                InsertarEmpleado(cedula, nombre, salario, tipoUsuarioID);

                MessageBox.Show("Empleado registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertarEmpleado(int cedula, string nombre, decimal salario, int tipoUsuarioID)
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERTAR_EMPLEADOS", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Salario", salario);
                        cmd.Parameters.AddWithValue("@TipoUsuarioID", tipoUsuarioID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
        }
        private void CargarTipoUsuarios()
        {
            try
            {
                using (SqlConnection cn = conexion.conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT UsuarioID, TipoUsuario FROM Usuarios", cn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int usuarioID = Convert.ToInt32(reader["UsuarioID"]);
                                string tipoUsuario = reader["TipoUsuario"].ToString();
                                cbotipousuarioid.Items.Add(new KeyValuePair<int, string>(usuarioID, tipoUsuario));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int codigoASCII = (int)e.KeyChar;
            if (Validador.validarTexto(codigoASCII))
            {
                e.Handled = true;
            }
        }

        private void txtcedula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            int codigoASCII = (int)e.KeyChar;

            if (Validador.validarNumero(codigoASCII))
            {
                e.Handled = true;
            }

            if (txtcedula.Text.Length >= 10 && codigoASCII != 8) // 8 es el código ASCII de la tecla "Backspace"
            {
                e.Handled = true;
            }
        }

        private void txtsalario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            int codigoASCII = (int)e.KeyChar;

            if (Validador.validarMoneda(codigoASCII, txtsalario.Text))
            {
                e.Handled = true;
            }
        }

        private void txtcedulaempleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            int codigoASCII = (int)e.KeyChar;
            if (Validador.validarNumero(codigoASCII))
            {
                e.Handled = true;
            }
            if (txtcedulaempleado.Text.Length >= 10 && codigoASCII != 8)
            {
                e.Handled = true;
            }
        }
    }
}



