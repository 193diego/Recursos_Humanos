using System.Data.SqlClient;

namespace Recursos_Humanos
{
    class conexion
    {
        public static string NombreUsuarioActual { get; set; }

        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-P821MMUI;database=RCHUMANOS;integrated security=true;");
            cn.Open();
            return cn;
        }
    }
}
