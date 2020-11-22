
namespace Clave1_Grupo6
{
    partial class AdministracionUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.gBInformacionUsuarios = new System.Windows.Forms.GroupBox();
            this.dGVUsuarios = new System.Windows.Forms.DataGridView();
            this.gBDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.cBTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRepetirPasswprd = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepetirPassword = new System.Windows.Forms.TextBox();
            this.gBBuscarUsuarios = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardarNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.lLAtras = new System.Windows.Forms.LinkLabel();
            this.ePAdministracionUsuarios = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBInformacionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).BeginInit();
            this.gBDatosUsuarios.SuspendLayout();
            this.gBBuscarUsuarios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePAdministracionUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gBInformacionUsuarios
            // 
            this.gBInformacionUsuarios.Controls.Add(this.dGVUsuarios);
            this.gBInformacionUsuarios.Location = new System.Drawing.Point(12, 371);
            this.gBInformacionUsuarios.Name = "gBInformacionUsuarios";
            this.gBInformacionUsuarios.Size = new System.Drawing.Size(437, 183);
            this.gBInformacionUsuarios.TabIndex = 3;
            this.gBInformacionUsuarios.TabStop = false;
            this.gBInformacionUsuarios.Text = "Información de Usuarios";
            // 
            // dGVUsuarios
            // 
            this.dGVUsuarios.AllowUserToAddRows = false;
            this.dGVUsuarios.AllowUserToDeleteRows = false;
            this.dGVUsuarios.AllowUserToResizeColumns = false;
            this.dGVUsuarios.AllowUserToResizeRows = false;
            this.dGVUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsuarios.Location = new System.Drawing.Point(9, 19);
            this.dGVUsuarios.Name = "dGVUsuarios";
            this.dGVUsuarios.ReadOnly = true;
            this.dGVUsuarios.Size = new System.Drawing.Size(422, 150);
            this.dGVUsuarios.TabIndex = 0;
            this.dGVUsuarios.VirtualMode = true;
            // 
            // gBDatosUsuarios
            // 
            this.gBDatosUsuarios.Controls.Add(this.cBTipoUsuario);
            this.gBDatosUsuarios.Controls.Add(this.lblTipoUsuario);
            this.gBDatosUsuarios.Controls.Add(this.lblNombreUsuario);
            this.gBDatosUsuarios.Controls.Add(this.lblRepetirPasswprd);
            this.gBDatosUsuarios.Controls.Add(this.txtNombreUsuario);
            this.gBDatosUsuarios.Controls.Add(this.lblPassword);
            this.gBDatosUsuarios.Controls.Add(this.txtPassword);
            this.gBDatosUsuarios.Controls.Add(this.txtRepetirPassword);
            this.gBDatosUsuarios.Location = new System.Drawing.Point(12, 53);
            this.gBDatosUsuarios.Name = "gBDatosUsuarios";
            this.gBDatosUsuarios.Size = new System.Drawing.Size(249, 236);
            this.gBDatosUsuarios.TabIndex = 10;
            this.gBDatosUsuarios.TabStop = false;
            this.gBDatosUsuarios.Text = "Datos Usuario";
            this.gBDatosUsuarios.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cBTipoUsuario
            // 
            this.cBTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTipoUsuario.FormattingEnabled = true;
            this.cBTipoUsuario.Items.AddRange(new object[] {
            "Administrador ",
            "Vendedor"});
            this.cBTipoUsuario.Location = new System.Drawing.Point(113, 165);
            this.cBTipoUsuario.Name = "cBTipoUsuario";
            this.cBTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cBTipoUsuario.TabIndex = 10;
            this.cBTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(6, 168);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblTipoUsuario.TabIndex = 9;
            this.lblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(2, 42);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(89, 13);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre Usuario: ";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblRepetirPasswprd
            // 
            this.lblRepetirPasswprd.AutoSize = true;
            this.lblRepetirPasswprd.Location = new System.Drawing.Point(6, 128);
            this.lblRepetirPasswprd.Name = "lblRepetirPasswprd";
            this.lblRepetirPasswprd.Size = new System.Drawing.Size(103, 13);
            this.lblRepetirPasswprd.TabIndex = 8;
            this.lblRepetirPasswprd.Text = "Repetir contraseña: ";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(115, 42);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(119, 20);
            this.txtNombreUsuario.TabIndex = 3;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(119, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtRepetirPassword
            // 
            this.txtRepetirPassword.Location = new System.Drawing.Point(115, 125);
            this.txtRepetirPassword.Name = "txtRepetirPassword";
            this.txtRepetirPassword.PasswordChar = '*';
            this.txtRepetirPassword.Size = new System.Drawing.Size(119, 20);
            this.txtRepetirPassword.TabIndex = 5;
            this.txtRepetirPassword.TextChanged += new System.EventHandler(this.txtRepetirPassword_TextChanged);
            // 
            // gBBuscarUsuarios
            // 
            this.gBBuscarUsuarios.Controls.Add(this.btnBuscar);
            this.gBBuscarUsuarios.Controls.Add(this.txtBuscar);
            this.gBBuscarUsuarios.Location = new System.Drawing.Point(12, 295);
            this.gBBuscarUsuarios.Name = "gBBuscarUsuarios";
            this.gBBuscarUsuarios.Size = new System.Drawing.Size(437, 70);
            this.gBBuscarUsuarios.TabIndex = 15;
            this.gBBuscarUsuarios.TabStop = false;
            this.gBBuscarUsuarios.Text = "Busqueda por nombre de Usuario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(257, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(162, 33);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(9, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(225, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnGuardarNuevo);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnRecargar);
            this.groupBox2.Location = new System.Drawing.Point(267, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 236);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(27, 79);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(137, 33);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.Location = new System.Drawing.Point(27, 42);
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.Size = new System.Drawing.Size(137, 31);
            this.btnGuardarNuevo.TabIndex = 10;
            this.btnGuardarNuevo.Text = "Guardar";
            this.btnGuardarNuevo.UseVisualStyleBackColor = true;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(27, 118);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 33);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(27, 162);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(137, 33);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // lLAtras
            // 
            this.lLAtras.AutoSize = true;
            this.lLAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLAtras.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lLAtras.Location = new System.Drawing.Point(393, 21);
            this.lLAtras.Name = "lLAtras";
            this.lLAtras.Size = new System.Drawing.Size(56, 16);
            this.lLAtras.TabIndex = 17;
            this.lLAtras.TabStop = true;
            this.lLAtras.Text = "<< Atrás";
            this.lLAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLAtras_LinkClicked);
            // 
            // ePAdministracionUsuarios
            // 
            this.ePAdministracionUsuarios.ContainerControl = this;
            // 
            // AdministracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 578);
            this.Controls.Add(this.lLAtras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBBuscarUsuarios);
            this.Controls.Add(this.gBDatosUsuarios);
            this.Controls.Add(this.gBInformacionUsuarios);
            this.Name = "AdministracionUsuarios";
            this.Text = "Administracion de Usuarios";
            this.Load += new System.EventHandler(this.AdministracionUsuarios_Load);
            this.gBInformacionUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).EndInit();
            this.gBDatosUsuarios.ResumeLayout(false);
            this.gBDatosUsuarios.PerformLayout();
            this.gBBuscarUsuarios.ResumeLayout(false);
            this.gBBuscarUsuarios.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ePAdministracionUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBInformacionUsuarios;
        private System.Windows.Forms.DataGridView dGVUsuarios;
        private System.Windows.Forms.GroupBox gBDatosUsuarios;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblRepetirPasswprd;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepetirPassword;
        private System.Windows.Forms.GroupBox gBBuscarUsuarios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardarNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.LinkLabel lLAtras;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ErrorProvider ePAdministracionUsuarios;
        private System.Windows.Forms.ComboBox cBTipoUsuario;
    }
}