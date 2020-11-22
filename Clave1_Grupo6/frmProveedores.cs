using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using consultaBD.Negocio;

namespace Clave1_Grupo6
{
    public partial class frmProveedores : Form
    {
        MantenimientoTablaProveedor contenedor = new MantenimientoTablaProveedor();
        public frmProveedores()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            actualizarDataGrid();
            dataGridView1.Columns[0].Visible = false;
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            btnModificar.Enabled = false;
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            actualizarDataGrid();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            DProveedores Proveedor = new DProveedores();
            Proveedor.Nombre = txtNombre.Text;
            Proveedor.Direccion = txtDireccion.Text;
            Proveedor.Telefono = Int32.Parse((txtTelefono.Text));
            Proveedor.Estado = 1;
            int agregado = MantenimientoTablaProveedor.QueryInsert(Proveedor);
            if (agregado == 1)
            {
                MessageBox.Show("Registro Agregado");
            }
            else
            {
                MessageBox.Show("Falló el registro");
            }
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            actualizarDataGrid();
            dataGridView1.Columns[0].Visible = false;
            btnModificar.Enabled = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardarNuevo.Enabled = false;
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Declaración de una variable con el resultado del Messagebox
            var opcion = MessageBox.Show("Realmente desea Eliminar el registro?", "Eliminar Registro",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //opcion guardará el botón cliqueado por el usuario
            if (opcion == DialogResult.Yes)
            {
                try
                {
                    int codigo = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    int eliminar = MantenimientoTablaProveedor.QueryDelete(codigo);
                    if (eliminar == 1)
                    {
                        MessageBox.Show("Proveedor Eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó el registro del proveedor");
                    }
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    actualizarDataGrid();
                    dataGridView1.Columns[0].Visible = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardarNuevo.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DProveedores Proveedor = new DProveedores();
            int codigo = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Proveedor.Nombre = txtNombre.Text;
            Proveedor.Direccion = txtDireccion.Text;
            Proveedor.Telefono = Int32.Parse((txtTelefono.Text));
            int actualizar = MantenimientoTablaProveedor.QueryUpdate(Proveedor, codigo);
            if (actualizar == 1)
            {
                MessageBox.Show("Registro Modificado");
            }
            else
            {
                MessageBox.Show("Registro no modificado");
            }
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            actualizarDataGrid();
            dataGridView1.Columns[0].Visible = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardarNuevo.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contenedor.QuerySearch(txtBuscar.Text);
            dataGridView1.Columns[0].Visible = false;
        }
        private void actualizarDataGrid()
        {
            dataGridView1.DataSource = contenedor.QuerySelect("Select id_Proveedor, nombreEmpresa, direccionProveedor, numeroProveedor from proveedores where estadoProveedor like 1");
            dataGridView1.Columns[1].HeaderText = lblNombre.Text;
            dataGridView1.Columns[2].HeaderText = lblDireccion.Text;
            dataGridView1.Columns[3].HeaderText = lblTelefono.Text;
        }

        private void lLAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Administracion abrirForm = new Administracion();
            abrirForm.Visible = true;
            Visible = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
