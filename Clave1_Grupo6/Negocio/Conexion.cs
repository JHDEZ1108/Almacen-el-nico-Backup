using MySql.Data.MySqlClient;
using System;

namespace consultaBD.Negocio
{
    /// <summary>
    /// Esta clase establece la conexion con la base de datos 
    /// </summary>
    class Conexion
    {
        static MySqlConnection con;
        static string cadenaconex;
        public static MySqlConnection conexion()
        {
            cadenaconex = "server=localhost;Database=clave1_grupo6;uid=root;pwd=root;";

            try
            {
                con = new MySqlConnection(cadenaconex);
                return con;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            finally {
                con.Open();
            }
        }

        static void OpenCon()
        {
            con.Open();
        }
        protected void CloseCon()
        {
            con.Close();
        }
    }
}