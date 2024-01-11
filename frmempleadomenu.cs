using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace Recursos_Humanos
{
    public partial class frmempleadomenu : MaterialForm
    {
        public frmempleadomenu()
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

        private void frmempleadomenu_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnasistencia_Click(object sender, EventArgs e)
        {
            frmasistenciaempleado formAsistenciaEmpleado = new frmasistenciaempleado();
            formAsistenciaEmpleado.ShowDialog();
        }

        private void btnsolicitarvacaciones_Click(object sender, EventArgs e)
        {
            frmsolicitavacaciones formSolicitarVacaciones = new frmsolicitavacaciones();
            formSolicitarVacaciones.ShowDialog();
        }
    }
}
