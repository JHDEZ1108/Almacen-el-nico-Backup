using consultaBD.Negocio;
using MySql.Data.MySqlClient;
using System.Data;


namespace ConsultaBD.Negocio
{
    class MantenimientoTablaUsuarios : Conexion
    {
        public DataTable QuerySelect(string query)
        {

            MySqlDataAdapter adp = new MySqlDataAdapter(query, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
            return consulta;

        }
        public DataTable QuerySearch(string nombreUsuario)
        {
            string query = string.Format("SELECT id_Usuarios,nombreUsuario,contrasenia,tipoUsuario FROM Usuarios WHERE(nombreUsuario) LIKE '%{0}%' and (estadoUsuario) LIKE 1", nombreUsuario);
            MySqlDataAdapter adp = new MySqlDataAdapter(query, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
            return consulta;

        }

        public DataTable QuerySearchUser(string nombreUsuario)
        {
            string query = string.Format("SELECT nombreUsuario FROM Usuarios WHERE(nombreUsuario) LIKE '%{0}%' AND (estadoUsuario) LIKE 1", nombreUsuario);
            MySqlDataAdapter adp = new MySqlDataAdapter(query, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
            return consulta;

        }

        public static int QueryInsert(DUsuarios Usuario)
        {
            int retorno = 0;
            MySqlCommand insertar = new MySqlCommand(string.Format("INSERT INTO Usuarios(nombreUsuario,contrasenia,tipoUsuario,estadoUsuario) VALUES('{0}','{1}','{2}','{3}')", Usuario.NombreUsuario, Usuario.Password, Usuario.TipoUsuario, Usuario.EstadoUsuario), Conexion.conexion());
            retorno = insertar.ExecuteNonQuery();
            return retorno;
        }
        public static int QueryUpdate(DUsuarios Usuario)
        {
            int retorno = 0;
            MySqlCommand actualizar = new MySqlCommand(string.Format("UPDATE Usuarios SET nombreUsuario = '{0}', contrasenia = '{1}',tipoUsuario='{2}' WHERE(nombreUsuario = '{3}')", Usuario.NombreUsuario, Usuario.Password, Usuario.TipoUsuario, Usuario.NombreUsuario), Conexion.conexion());
            retorno = actualizar.ExecuteNonQuery();
            return retorno;
        }

        public static int QueryDelete(string nombre)
        {
            int retorno = 0;
            MySqlCommand eliminar = new MySqlCommand(string.Format("UPDATE Usuarios SET estadoUsuario = 0 WHERE(nombreUsuario='{0}')", nombre), Conexion.conexion());
            retorno = eliminar.ExecuteNonQuery();
            return retorno;
        }
    }
}

