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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void lblOpciones_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores abrirForm = new frmProveedores();
            abrirForm.Show();
            Visible = false;
        }

        private void lLAdministrarUsuarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdministracionUsuarios abrirForm = new AdministracionUsuarios();
            abrirForm.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion abrirForm = new InicioSesion();
            abrirForm.Visible=true;
            Visible = false;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí va el apartado del Inventario");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí va el apartado de las ventas");
        }
    }
}
