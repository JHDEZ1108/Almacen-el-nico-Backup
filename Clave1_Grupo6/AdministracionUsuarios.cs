using ConsultaBD.Negocio;
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using consultaBD.Negocio;

namespace Clave1_Grupo6
{
    public partial class AdministracionUsuarios : Form
    {
        MantenimientoTablaUsuarios contenedor = new MantenimientoTablaUsuarios();
        public AdministracionUsuarios()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtRepetirPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Este botón elimina o pone en "usuario desactivado" al usuario
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var opcion = MessageBox.Show("Realmente desea Eliminar el registro?", "Eliminar Registro",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                try
                {
                    string codigo = txtNombreUsuario.Text;
                    int eliminar = MantenimientoTablaUsuarios.QueryDelete(codigo);
                    if (eliminar == 1)
                    {
                        MessageBox.Show("Usuario Eliminado");
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe");
                    }
                    txtNombreUsuario.Clear();
                    txtPassword.Clear();
                    txtRepetirPassword.Clear();
                    ActualizarDataGrid();
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }
        /// <summary>
        /// Este botón me limpia todos los campos
        /// </summary>
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            txtBuscar.Clear();
            txtNombreUsuario.Clear();
            txtPassword.Clear();
            txtRepetirPassword.Clear();
            ePAdministracionUsuarios.Clear();

        }
        /// <summary>
        /// Este boton me modifica los datos de los usuarios
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            DUsuarios Usuario = new DUsuarios();
            
            if (ValidarPassword())
            {
                Usuario.NombreUsuario = txtNombreUsuario.Text;
                Usuario.Password = txtPassword.Text;
                Usuario.TipoUsuario = cBTipoUsuario.Text;
                Usuario.EstadoUsuario = 1;
                int actualizar = MantenimientoTablaUsuarios.QueryUpdate(Usuario);

                if (actualizar == 1)
                {
                    MessageBox.Show("Registro Actualizado");
                }
                else
                {
                    MessageBox.Show("El registro no fue actualizado");
                }

                txtNombreUsuario.Clear();
                txtPassword.Clear();
                txtRepetirPassword.Clear();
                ActualizarDataGrid();
            }
            else if (!ValidarUsuario())
            {
                ePAdministracionUsuarios.SetError(txtNombreUsuario, "Usuario ya existente");
            }
            else if (!ValidarPassword())
            {
                ePAdministracionUsuarios.SetError(txtPassword, "Las contraseñas no coinciden");
            }
        }
        /// <summary>
        /// Este borón me guarda los nuevos usuarios
        /// </summary>
        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            ePAdministracionUsuarios.Clear();
            DUsuarios Usuario = new DUsuarios();
            if (ValidarPassword() && ValidarUsuario())
            {
                Usuario.NombreUsuario = txtNombreUsuario.Text;
                Usuario.Password = txtPassword.Text;
                Usuario.TipoUsuario = cBTipoUsuario.Text;
                Usuario.EstadoUsuario = 1;
                int agregado = MantenimientoTablaUsuarios.QueryInsert(Usuario);

                if (agregado == 1)
                {
                    MessageBox.Show("Registro Agregado");
                }
                else
                {
                    MessageBox.Show("El registro fallo");
                }

                txtNombreUsuario.Clear();
                txtPassword.Clear();
                txtRepetirPassword.Clear();
                ActualizarDataGrid();
            }
            else if (!ValidarUsuario())
            {
                ePAdministracionUsuarios.SetError(txtNombreUsuario, "Usuario ya existente");
            }
            else if (!ValidarPassword()) {
                ePAdministracionUsuarios.SetError(txtRepetirPassword, "Las contraseñas no coinciden");
            }
        }

        /// <summary>
        /// Este boton busca el usuario que el administrador quiere encontrar
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dGVUsuarios.DataSource = contenedor.QuerySearch(txtBuscar.Text);
        }

        /// <summary>
        /// Este link label me manda a la ventana anterior
        /// </summary>
        private void lLAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Administracion abrirForm = new Administracion();
            abrirForm.Visible = true;
            Visible = false;
        }

        /// <summary>
        /// Aquí se cargan los campos
        /// </summary>
        private void AdministracionUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }
        /// <summary>
        /// Metodo para actualizar mi DataGridView
        /// </summary>
        private void ActualizarDataGrid()
        {
            dGVUsuarios.DataSource = contenedor.QuerySelect("SELECT id_Usuarios, nombreUsuario, contrasenia, tipoUsuario FROM usuarios WHERE estadoUsuario LIKE 1");
            dGVUsuarios.Columns[0].HeaderText = "ID";
            dGVUsuarios.Columns[1].HeaderText = lblNombreUsuario.Text;
            dGVUsuarios.Columns[2].HeaderText = lblPassword.Text;
            dGVUsuarios.Columns[3].HeaderText = lblTipoUsuario.Text;


        }
        /// <summary>
        /// Metedo para validar la contraseña
        /// </summary>
        private bool ValidarPassword() {
            String contraseña = txtPassword.Text;
            String contraseñaR = txtRepetirPassword.Text;

            if ((contraseña == contraseñaR) && contraseña != null)
            {
                return true;
            }
            else {
                return false;
            }
        }
        /// <summary>
        /// Este merodo me valida si el usuario es existente o no 
        /// </summary>
        private bool ValidarUsuario() {
            
            String usuario = txtNombreUsuario.Text;
            String usuarioDB = null;
            MySqlDataReader readerData = null;
            String data = "SELECT contrasenia, tipoUsuario FROM Usuarios WHERE nombreUsuario LIKE '" + usuario + "' LIMIT 1";
            MySqlConnection con = Conexion.conexion();

            try
            {
                MySqlCommand consultaData = new MySqlCommand(data, con);
                readerData = consultaData.ExecuteReader();

                if (readerData.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally {
                con.Close();
            }
        }
    }
}
