using consultaBD.Negocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo6
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ePInicioSesion.Clear();
            ConsultaDatos();
        }

        private void ConsultaDatos() {             
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            String passwordDB = null;
            String tipoUsuarioDB = null;

            MySqlDataReader readerData = null;

            String dataDB = "SELECT contrasenia, tipoUsuario FROM Usuarios WHERE nombreUsuario LIKE '" + usuario + "' LIMIT 1";            
            MySqlConnection con = Conexion.conexion();


            try
            {
                MySqlCommand consultaData = new MySqlCommand(dataDB, con);
                readerData = consultaData.ExecuteReader();

                if (readerData.HasRows)
                {
                    while (readerData.Read()) { 
                        passwordDB = readerData[0].ToString();
                        tipoUsuarioDB = readerData[1].ToString();
                    }

                    if (passwordDB != password)
                    {
                        ePInicioSesion.SetError(txtPassword, "Contraseña invalida");
                    }
                    else
                    {
                        MessageBox.Show("El usuario es: " + tipoUsuarioDB);
                        if (tipoUsuarioDB == "Administrador")
                        {
                            Administracion abrirForm = new Administracion();
                            abrirForm.Visible = true;
                            Visible = false;
                        }
                        else {
                            MessageBox.Show("Aquí se abre la ventana para el usuario de Venta");
                            //--------------------------------------------------------------------------------------------<<
                        }

                    }

                }
                else
                {
                    ePInicioSesion.SetError(txtUsuario, "Este usuario no existe");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally {
                con.Close();
            }
             
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
