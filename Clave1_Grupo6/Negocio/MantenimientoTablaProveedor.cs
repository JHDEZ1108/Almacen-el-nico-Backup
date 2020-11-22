using MySql.Data.MySqlClient;
using System.Data;

namespace consultaBD.Negocio
{
    class MantenimientoTablaProveedor : Conexion
    {

        public DataTable QuerySelect(string query)
        {

            MySqlDataAdapter adp = new MySqlDataAdapter(query, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
            return consulta;

        }
        public DataTable QuerySearch(string nombre)
        {
            string query = string.Format("SELECT id_Proveedor,nombreEmpresa,direccionProveedor,numeroProveedor FROM proveedores where(nombreEmpresa) like '%{0}%' and (estadoProveedor) like 1", nombre);
            MySqlDataAdapter adp = new MySqlDataAdapter(query, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
            return consulta;

        }

        public static int QueryInsert(DProveedores Proveedor)
        {
            int retorno = 0;
            MySqlCommand insertar = new MySqlCommand(string.Format("Insert into proveedores(nombreEmpresa,direccionProveedor,numeroProveedor,estadoProveedor)values('{0}','{1}','{2}','{3}')", Proveedor.Nombre, Proveedor.Direccion, Proveedor.Telefono, Proveedor.Estado), Conexion.conexion());
            retorno = insertar.ExecuteNonQuery();
            return retorno;
        }
        public static int QueryUpdate(DProveedores Proveedor, int codigo)
        {
            int retorno = 0;
            MySqlCommand actualizar = new MySqlCommand(string.Format("Update proveedores Set nombreEmpresa = '{0}',direccionProveedor = '{1}',numeroProveedor='{2}' Where(id_Proveedor = '{3}')", Proveedor.Nombre, Proveedor.Direccion, Proveedor.Telefono, codigo), Conexion.conexion());
            retorno = actualizar.ExecuteNonQuery();
            return retorno;
        }

        public static int QueryDelete(int codigo)
        {
            int retorno = 0;
            MySqlCommand eliminar = new MySqlCommand(string.Format("Update proveedores Set estadoProveedor = 0 where(id_Proveedor='{0}')", codigo), Conexion.conexion());
            retorno = eliminar.ExecuteNonQuery();
            return retorno;
        }

    }
}

