
namespace Clave1_Grupo6
{
    partial class Administracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBAdministracionDatos = new System.Windows.Forms.GroupBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.lLAdministrarUsuarios = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.gBAdministracionDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBAdministracionDatos
            // 
            this.gBAdministracionDatos.Controls.Add(this.btnInventario);
            this.gBAdministracionDatos.Controls.Add(this.btnProveedores);
            this.gBAdministracionDatos.Controls.Add(this.btnClientes);
            this.gBAdministracionDatos.Controls.Add(this.lblOpciones);
            this.gBAdministracionDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBAdministracionDatos.Location = new System.Drawing.Point(21, 33);
            this.gBAdministracionDatos.Name = "gBAdministracionDatos";
            this.gBAdministracionDatos.Size = new System.Drawing.Size(684, 174);
            this.gBAdministracionDatos.TabIndex = 1;
            this.gBAdministracionDatos.TabStop = false;
            this.gBAdministracionDatos.Text = "Administración de datos";
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(482, 99);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(116, 36);
            this.btnInventario.TabIndex = 6;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(250, 99);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(135, 36);
            this.btnProveedores.TabIndex = 5;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(40, 99);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(116, 36);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(173, 40);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(253, 20);
            this.lblOpciones.TabIndex = 0;
            this.lblOpciones.Text = "¿Que campo desea consultar?";
            this.lblOpciones.Click += new System.EventHandler(this.lblOpciones_Click);
            // 
            // lLAdministrarUsuarios
            // 
            this.lLAdministrarUsuarios.AutoSize = true;
            this.lLAdministrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLAdministrarUsuarios.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lLAdministrarUsuarios.Location = new System.Drawing.Point(17, 240);
            this.lLAdministrarUsuarios.Name = "lLAdministrarUsuarios";
            this.lLAdministrarUsuarios.Size = new System.Drawing.Size(198, 20);
            this.lLAdministrarUsuarios.TabIndex = 2;
            this.lLAdministrarUsuarios.TabStop = true;
            this.lLAdministrarUsuarios.Text = "Administrar usuarios >>";
            this.lLAdministrarUsuarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLAdministrarUsuarios_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(520, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lLAdministrarUsuarios);
            this.Controls.Add(this.gBAdministracionDatos);
            this.Name = "Administracion";
            this.Text = "Administración";
            this.gBAdministracionDatos.ResumeLayout(false);
            this.gBAdministracionDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBAdministracionDatos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.LinkLabel lLAdministrarUsuarios;
        private System.Windows.Forms.Button button1;
    }
}