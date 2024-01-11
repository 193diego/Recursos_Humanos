using System;
using System.Windows.Forms;

namespace Recursos_Humanos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string nombreUsuarioActual = ObtenerNombreUsuarioActual();
            Application.Run(new frmlogin(nombreUsuarioActual));
        }
        static string ObtenerNombreUsuarioActual()
        {
            return conexion.NombreUsuarioActual;
        }
    }
}
